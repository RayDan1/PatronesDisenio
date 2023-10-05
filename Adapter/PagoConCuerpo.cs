namespace Adapter
{
    internal class PagoConCuerpo : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Pagando con cuerpo");
        }
    }
}
