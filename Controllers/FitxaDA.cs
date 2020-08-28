using WebApplicaction.Models;

namespace WebApplicaction.Controllers
{
    public class FitxaDA
    {
        public FitxaE getfitxa(int customerId)
        {
            //simulacio de bbdd
            //introduir dades de client i producte a la fitxa
            CustomerDA clientdades = new CustomerDA();
            ProducteDA clientproductes = new ProducteDA();

            FitxaE efitxa = new FitxaE();

            efitxa.customer = clientdades.getCustomer(1);
            efitxa.productes = clientproductes.getProducte(1);


            return efitxa;
        }
    }
}