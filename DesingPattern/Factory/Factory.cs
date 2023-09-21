using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesingPattern.Factory
{
    //CREADOR 
    public abstract class SaleFactory
    {  
        public abstract ISale GetSale();
    }

    //CONCRETE CREATER
    public class StoreSaleFactory : SaleFactory
    {
        private decimal _extra;

        public StoreSaleFactory(decimal extra)
        {
            _extra = extra;
        }

        public override ISale GetSale()
        {
            return new StoreSale(_extra);
        }
    }


    public class InternetSaleFactory : SaleFactory
    {
        private decimal _discount;

        public InternetSaleFactory(decimal discount)
        {
            _discount = discount;
        }

        public override ISale GetSale()
        {
            return new InternetSale(_discount);
        }
    }


    //CONCRET PRODUCT
    public class StoreSale : ISale
    {

        private decimal _extra;

        public StoreSale(decimal extra)
        {
            _extra = extra; 
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en tienda tiene un total de {total+_extra}");
        }
    }


    public class InternetSale : ISale
    {

        private decimal _discount;

        public InternetSale(decimal extra)
        {
            _discount = extra;
        }

        public void Sell(decimal total)
        {
            Console.WriteLine($"La venta en internet tiene un total de {total - _discount}");
        }
    }


    //PRODUCTO
    public interface ISale
    {
        public void Sell(decimal total);
    }

}
