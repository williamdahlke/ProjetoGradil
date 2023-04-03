using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjetoGradil
{
    public partial class Frm_Desenho : Form
    {
        public Frm_Desenho()
        {
            InitializeComponent();
        }

        private void Btn_Desenhar_Click(object sender, EventArgs e)
        {
            Image bmp = new Bitmap(4200, 2000);
            Graphics desenhador = Graphics.FromImage(bmp);
            desenhador.Clear(Color.White);

            desenharLinhaHorizontal(desenhador);

            int nPoste = 12;
            float nPosicao = 50.0f;

            for (int i=1; i <= nPoste; i++)
            {
                nPosicao += 200.0f;

                if (i < nPoste)
                {
                    float nPosicao2 = nPosicao + 200f;
                    desenharCerca(desenhador, nPosicao, nPosicao2);
                }
                desenharPoste(desenhador, nPosicao);
            }                     

            Pb_Desenho.BackgroundImage = bmp;

            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "jpg files (*.jpg)|*.jpg";
            sfd.FilterIndex = 1;
            sfd.RestoreDirectory = true;
            sfd.InitialDirectory = "c:\\";
            sfd.DefaultExt = "jpg";
            sfd.ShowDialog();

            bmp.Save(sfd.FileName);
        }

        private void Btn_Salvar_Click(object sender, EventArgs e)
        {

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
