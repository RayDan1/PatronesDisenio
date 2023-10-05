namespace Adapter
{
    internal class PagoBolsaSal : IPago
    {
        public void Cobrar()
        {
            Console.WriteLine("Cobrando en bolsa de sal");
        }
    }   
    
    }

