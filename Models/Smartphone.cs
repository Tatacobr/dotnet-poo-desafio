namespace DesafioPOO.Models
{
    public abstract class Smartphone
    {
        public string Numero { get; set; }
        public string Modelo { get; set; }
        public string IMEI { get; set; }
        public int Memoria { get; set; }

        public Smartphone(string numero, string modelo, string imei, int memoria){
            Numero = numero;
            Modelo = modelo;
            IMEI = imei;
            Memoria = memoria;
        }

        public void Ligar(Smartphone aparelho)
        {
            Console.WriteLine($"Ligando para {aparelho.Numero}...");
            ReceberLigacao();
        }

        private void ReceberLigacao()
        {
            Console.WriteLine($"Recebendo ligação de {Numero}");
        }

        public abstract void InstalarAplicativo(string nomeApp);
    }
}