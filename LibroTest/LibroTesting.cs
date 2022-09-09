using CalidadT1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibroTest
{
    public class LibroTesting
    {
        [Test]
        public void TesterLibro()
        {
            var l1 = new Book();
            l1.Name = "l1";
            l1.Price = 14;
            var venta = new BookStore();
            venta.AddToCart(l1);
            var costo = venta.GetTotal();
            

        }
    }
}
