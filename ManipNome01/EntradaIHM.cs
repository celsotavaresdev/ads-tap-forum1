using System.Text.RegularExpressions;

namespace ManipNome01
{
    public partial class EntradaIHM : Form
    {
        public EntradaIHM()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            // remove espaços desnecessários do "txtNome"
            txtNome.Text = Regex.Replace(txtNome.Text.Trim(), " +", " ");

            if (!ManipNomeBLL.ValidaNome(txtNome.Text))
            {
                return;
            }

            ManipNome.setNome(txtNome.Text);
            new SaidaIHM().ShowDialog();
        }
    }
}