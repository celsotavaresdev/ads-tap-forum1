namespace ManipNome01
{
    class ManipNome
    {
        private static String nome;

        public static void setNome(String _nome) { nome = _nome; }

        public static String getNome() { return nome; }

        public static String getSobrenome()
        {
            return nome.Split(' ').Last();
        }

        public static String getNomeF1()
        {
            string[] nomeSeparado = nome.Split(' ');
            string nomeF1 = nomeSeparado.Last() + ", ";
            nomeF1 += string.Join(" ", nomeSeparado.SkipLast(1));
            
            return nomeF1;
        }

        public static String getNomeF2()
        {
            string[] nomeSeparado = nome.Split(' ');
            string nomeF2 = nomeSeparado.Last() + ", ";

            foreach (string nome in nomeSeparado.SkipLast(1))
            {
                nomeF2 += nome[0] + ". ";
            }

            return nomeF2;
        }

        public static String getNomeF3()
        {
            string nomeF3 = new string(nome.Reverse().ToArray());
            return nomeF3;
        }

        public static int PosicaoUltimoEspaco()
        {
            return nome.LastIndexOf(' ');
        }
    }
}