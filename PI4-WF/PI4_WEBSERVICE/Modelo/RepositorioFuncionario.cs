using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PI4_WEBSERVICE.Modelo
{
    public class RepositorioFuncionario
    {

        private PI4_WSEntities db;

        public RepositorioFuncionario()
        {

            db = new PI4_WSEntities();

        }

        public List<funcionario> Getall()
        {

            return this.db.funcionario.ToList<funcionario>();

        }
    }
}