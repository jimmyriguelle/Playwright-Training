using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDESdemo1.POM
{
    internal class AddProductPage
    {
        public string ProductNameErrorMessage;
        public string ProductPriceErrorMessage;
        public string ProductDateErrorMessage;

        public AddProductPage(string productNameErrorMessage, string productPriceErrorMessage, string productDateErrorMessage)
        {
            ProductNameErrorMessage = productNameErrorMessage;
            ProductPriceErrorMessage = productPriceErrorMessage;
            ProductDateErrorMessage = productDateErrorMessage;
        }
    }
}
