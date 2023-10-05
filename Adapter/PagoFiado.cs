
namespace Adapter
{
    internal class PagoFiado : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Mañana Paga");
        }
    }
}
