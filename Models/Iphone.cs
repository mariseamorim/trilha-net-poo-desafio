namespace DesafioPOO.Models
{
    // Herda da classe "Smartphone"
    public class Iphone : Smartphone
    {
        public Iphone(string numero, string modelo, string imei, int memoria) : base(numero, modelo,
        imei, memoria)
        {

        }

        // Sobrescrevendo o método "InstalarAplicativo"
        public override void InstalarAplicativo(string nomeApp)
        {

            if (!string.IsNullOrEmpty(nomeApp))
            {
                Console.WriteLine("Instalando do aplicativo \"{0}\" no Iphone.", nomeApp);

            }
            else
            {
                Console.WriteLine("Informe um aplicativo válido!");

            }

        }

    }
}
