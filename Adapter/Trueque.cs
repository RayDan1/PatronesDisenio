
namespace Adapter
{
    internal class Trueque : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Pagando con una cabra");
        }

    }
}
