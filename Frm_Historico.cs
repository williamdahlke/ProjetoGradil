using Microsoft.EntityFrameworkCore;
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
    public partial class Frm_Historico : Form
    {
        public Frm_Historico()
        {
            InitializeComponent();

            SistemaContext contexto = new SistemaContext();
            var x = contexto.Cercas.FromSql($"select * from cercas").OrderByDescending(b=> b.dt_confirmacao).ToList();
            Dgv_Historico.Columns.Clear();
            Dgv_Historico.DataSource = x;
        }
    }
}
