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
    public partial class Frm_Principal : Form
    {
        public Frm_Principal()
        {
            InitializeComponent();
        }

        private void Btn_Calcular_Click(object sender, EventArgs e)
        {
            var form = new Frm_Calcular();   
            form.ShowDialog();
        }

        private void Btn_Consultar_Click(object sender, EventArgs e)
        {
            var form = new Frm_Historico();
            form.ShowDialog();
        }

        private void Frm_Principal_Load(object sender, EventArgs e)
        {
            Btn_Calcular.Focus();

        }
    }
}
