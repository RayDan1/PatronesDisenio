namespace Adapter
{
    internal class PagoDracma : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Se pago con Dracmas" );
        }
    }
}
