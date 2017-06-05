using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace PI4_WEBSERVICE.Modelo
{
    public class RepositorioSala
    {
        private PI4_WSEntities db;

        public RepositorioSala() {

            db = new PI4_WSEntities();

        }

        public List<sala> Getall() {

            return this.db.sala.ToList<sala>();

        }

    }
}