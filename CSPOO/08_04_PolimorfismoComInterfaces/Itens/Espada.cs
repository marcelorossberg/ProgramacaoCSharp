namespace Itens
{
    class Espada : Item, IColecionavel
    {
        public int Dano {get; set;}
        public Espada(string nome, int x, int y, int dano) : base(nome, x, y)
        {
            Dano = dano;
        }

        public void Colecionar()
        {
            Console.WriteLine("Espada adicionada ao inventário");
        }
    }
}