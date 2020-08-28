using System.Collections.Generic;
using WebApplicaction.Models;

namespace WebApplicaction.Controllers
{
    public class ProducteDA
    {
        public List<ProducteE> getProducte(int customerId)
        {
            List<ProducteE> productes = new List<ProducteE>();
            //Simulacio acces base de dades
            //buscar a bbdd tots els productes contractats per customerid
            //retornar-los en un array,col.leccio,o el que vagi 
            //List<Productes> productes = consulta per treure els productes.ToList();

            return productes;
        }
    }
}