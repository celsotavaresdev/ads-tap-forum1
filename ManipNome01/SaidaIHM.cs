using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManipNome01
{
    public partial class SaidaIHM : Form
    {
        public SaidaIHM()
        {
            InitializeComponent();
        }

        private void SaidaIHM_Load(object sender, EventArgs e)
        {
            txtUltimoEspaco.Text = ManipNome.PosicaoUltimoEspaco().ToString();
            txtSobrenome.Text = ManipNome.getSobrenome();
            txtNomeF1.Text = ManipNome.getNomeF1();
            txtNomeF2.Text = ManipNome.getNomeF2();
            txtNomeF3.Text = ManipNome.getNomeF3();
        }
    }
}
