using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI4_WEBSERVICE.Modelo
{
    public class RepositorioPredio
    {
        private PI4_WSEntities db;

        public RepositorioPredio()
        {

            db = new PI4_WSEntities();

        }

        public List<predio> Getall()
        {

            return this.db.predio.ToList<predio>();

        }


    }
}