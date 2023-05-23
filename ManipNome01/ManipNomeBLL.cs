namespace ManipNome01
{
    class ManipNomeBLL
    {
        public static bool ValidaNome(String nome)
        {
            // verificar se o nome é nulo/vazio
            if (String.IsNullOrEmpty(nome.Trim()))
            {
                MessageBox.Show("O nome não pode ser vazio", "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            // verificar se é nome completo
            if (nome.Trim().Split(' ').Length == 1)
            {
                MessageBox.Show("Necessário digitar o nome completo", "Erro",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                return false;
            }

            return true;
        }
    }
}