using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Carinderia_Kiosk_System
{
    class GetProducts
    {
        private static List<GetProducts> products;

        public static List<GetProducts> Products
        {
            get
            {
                if (products.Count == 0)
                {
                   // Load();
                }
                return products;
            }
            set { products = value; }
        }

        public int Id { get; private set; }

        public static int GetNewId()
        {
            return Products.Count == 0 ? 1 : Products[products.Count - 1].Id + 1;
        }
    }
}
