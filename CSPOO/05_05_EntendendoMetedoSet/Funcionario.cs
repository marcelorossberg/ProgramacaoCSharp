namespace RH
{
    public class Funcionario
    {
        public string Nome;
        private string cpf; // Atributo
        public string CPF // Propriedade
        {
            get
            {
                return cpf.Replace(".", "").Replace("-", "");
            }
            set
            {
                if (value.Length == 0)
                    return;
                cpf = value;
            }
        }

        public Funcionario(string nome, string _cpf)
        {
            Nome = nome;
            cpf = _cpf;
        }
    }
}