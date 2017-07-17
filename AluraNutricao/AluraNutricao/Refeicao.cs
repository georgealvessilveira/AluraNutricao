namespace AluraNutricao
{
    public class Refeicao
    {
        public string Descricao { get; set; }
        public double Calorias { get; set; }

        public Refeicao(string descricao, double calorias)
        {
            Descricao = descricao;
            Calorias = calorias;
        }
    }
}
