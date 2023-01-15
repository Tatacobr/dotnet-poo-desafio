namespace DesafioPOO.Models
{
    public class Nokia : Smartphone    {
        public Nokia(string numero, string modelo, string imei, int memoria) : base(numero, modelo, imei, memoria){
        }

        public override void InstalarAplicativo(string appNome){
            Console.WriteLine("Instalando "+appNome+"...");
        }
    }
}