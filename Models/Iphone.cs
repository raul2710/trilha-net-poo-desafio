namespace DesafioPOO.Models
{
    // TODO: Herdar da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria)
        {
        }

        // Implementação do método InstalarAplicativo para Iphone
        public override void InstalarAplicativo(string nomeApp)
        {
            Console.WriteLine($"Instalano aplicativo \"{nomeApp}\" no Iphone");
        }
    }
}