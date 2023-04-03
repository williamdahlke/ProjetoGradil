using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGradil
{
    public partial class Frm_Calcular : Form
    {
        public Frm_Calcular()
        {
            InitializeComponent();
            Cb_Cor.Items.Clear();
            Cb_Cor.Items.Add("Sem pintura");
            Cb_Cor.Items.Add("Branca");
            Cb_Cor.Items.Add("Preta");
            Cb_Cor.Items.Add("Verde");
        }

        private void Txt_Comprimento_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != 44)
            {
                e.Handled = true;
            }
            else if (e.KeyChar == 44)
            {
                TextBox txt = (TextBox)sender;
                if (txt.Text.Contains(","))
                {
                    e.Handled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Txt_Comprimento.Text == "")
            {
                MessageBox.Show("O comprimento da cerca deve ser informado. Favor verificar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((String)Cb_Cor.SelectedItem == null)
            {
                MessageBox.Show("A cor da cerca deve ser selecionada. Favor verificar!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            double nComprimentoPadrao = Convert.ToDouble(ConfigurationManager.AppSettings["ComprimentoPadrao"]);

            Cerca cerca = new Cerca();
            cerca.setComprimento(Convert.ToDouble(Txt_Comprimento.Text));
            cerca.setCor((String)Cb_Cor.SelectedItem);
            cerca.setAltura(Convert.ToDouble(Gb_Altura.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text));

            Txt_ComprimentoComprar.Text = Convert.ToString(cerca.CalcularComprimento(nComprimentoPadrao));
            Txt_DiferencaComprimento.Text = Convert.ToString(cerca.CalcularDiferenca());

            Acessorio poste = new Acessorio();
            poste.nome = "Poste";
            poste.quantidade = CalcularNumeroPostes(cerca.getComprimento(), nComprimentoPadrao);

            Acessorio fixador = new Acessorio();
            fixador.nome = "Fixador";
            fixador.quantidade = CalcularNumeroFixador(cerca.getAltura(), poste.quantidade);

            Acessorio parafuso = new Acessorio();
            parafuso.nome = "Parafuso";
            parafuso.quantidade = CalcularNumeroParafusos(poste.quantidade);

            List<Acessorio> acessorios = new List<Acessorio>();
            acessorios.Add(poste);
            acessorios.Add(fixador);
            acessorios.Add(parafuso);
            cerca.Acessorio = acessorios;

            Dgv_ListaMateriais.Columns.Clear();
            Dgv_ListaMateriais.DataSource = acessorios;

        }

        public int CalcularNumeroPostes(double pComprimento, double pComprimentoPadrao)
        {
            int nNumeroPoste = (int)Math.Ceiling(pComprimento / pComprimentoPadrao);
            return nNumeroPoste;
        }

        public int CalcularNumeroFixador(double pAltura, int pNumeroPostes)
        {
            int fixador1 = Convert.ToInt32(ConfigurationManager.AppSettings["FixadorAltura1"]);
            int fixador2 = Convert.ToInt32(ConfigurationManager.AppSettings["FixadorAltura2"]);
            int fixador3 = Convert.ToInt32(ConfigurationManager.AppSettings["FixadorAltura3"]);

            if (pAltura == 1.03)
            {
                return pNumeroPostes * fixador1;
            }
            else if (pAltura == 1.53)
            {
                return pNumeroPostes * fixador2;
            }
            else
            {
                return pNumeroPostes * fixador3;
            }
        }

        public int CalcularNumeroParafusos(int pNumeroPostes)
        {
            int nParafusosPoste = Convert.ToInt32(ConfigurationManager.AppSettings["NumeroParafusos"]);
            return pNumeroPostes * nParafusosPoste;
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {

            if (Txt_ComprimentoComprar.Text != "")
            {
                try
                {
                    CercaRepository cerca = new CercaRepository();
                    cerca.comprimento = Convert.ToDouble(Txt_ComprimentoComprar.Text);
                    cerca.cor = Convert.ToString(Cb_Cor.SelectedItem);
                    cerca.altura = (Convert.ToDouble(Gb_Altura.Controls.OfType<RadioButton>().SingleOrDefault(RadioButton => RadioButton.Checked).Text));

                    DateTime dDtConfirmacao = DateTime.Now;
                    cerca.dt_confirmacao = dDtConfirmacao.ToString();

                    SistemaContext context = new();
                    context.Cercas.Add(cerca);

                    context.SaveChanges();

                    MessageBox.Show("Pedido registrado com sucesso!");
                }
                catch (Exception error)
                {
                    MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        private void Btn_Limpar_Click(object sender, EventArgs e)
        {
            Txt_Comprimento.Text = null;
            Cb_Cor.SelectedItem = null;
            Txt_ComprimentoComprar.Text = null;
            Txt_DiferencaComprimento.Text = null;
            Dgv_ListaMateriais.Columns.Clear();

            foreach (RadioButton rb in Gb_Altura.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    rb.Checked = false;
                }
            }
            Rb_Altura1.Checked = true;

        }
        private void Btn_Desenho_Click(object sender, EventArgs e)
        {
            if (Txt_ComprimentoComprar.Text == "")
            {
                MessageBox.Show("É necessário calcular a cerca antes de gerar o desenho!", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Image bmp = new Bitmap(4200, 2000);
                Graphics desenhador = Graphics.FromImage(bmp);
                desenhador.Clear(Color.White);

                desenharLinhaHorizontal(desenhador);

                int nPoste = Convert.ToInt32(Dgv_ListaMateriais.Rows[0].Cells[1].Value.ToString());

                float nPosicao = 50.0f;

                for (int i = 1; i <= nPoste; i++)
                {
                    nPosicao += 200.0f;

                    if (i < nPoste)
                    {
                        float nPosicao2 = nPosicao + 200f;
                        desenharCerca(desenhador, nPosicao, nPosicao2);
                    }
                    desenharPoste(desenhador, nPosicao);
                }

                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "jpg files (*.jpg)|*.jpg";
                sfd.FilterIndex = 1;
                sfd.RestoreDirectory = true;
                sfd.InitialDirectory = "c:\\";
                sfd.DefaultExt = "jpg";
                sfd.ShowDialog();

                bmp.Save(sfd.FileName);

                MessageBox.Show("Arquivo Salvo com Sucesso!");
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

        }

        private void desenharLinhaHorizontal(Graphics desenhador)
        {
            Pen CanetaH = new Pen(Color.Gray, 3);

            PointF pointH1 = new PointF(25.0F, 1000.0F);
            PointF pointH2 = new PointF(4150.0F, 1000.0F);
            desenhador.DrawLine(CanetaH, pointH1, pointH2);
        }

        private void desenharPoste(Graphics desenhador, float posicao)
        {

            Pen CanetaPoste = new Pen(Color.Black, 30);

            PointF point1 = new PointF(posicao, 500.0F);
            PointF point2 = new PointF(posicao, 1000.0F);
            desenhador.DrawLine(CanetaPoste, point1, point2);
        }

        private void desenharCerca(Graphics desenhador, float posicao, float posicao2)
        {
            Pen CanetaCerca = new Pen(Color.Black, 15);
            PointF point1 = new PointF(posicao, 550.0f);
            PointF point2 = new PointF(posicao2, 550.0f);
            desenhador.DrawLine(CanetaCerca, point1, point2);

            PointF point3 = new PointF(posicao, 900.0F);
            PointF point4 = new PointF(posicao2, 900.0F);
            desenhador.DrawLine(CanetaCerca, point3, point4);
        }
    }
}
