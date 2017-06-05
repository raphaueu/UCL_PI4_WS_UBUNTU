using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using PI4_WEBSERVICE.Modelo;
using System.Xml.Serialization;

namespace PI4_WEBSERVICE
{
    
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    
    public class WS : System.Web.Services.WebService
    {
        private RepositorioSala repsala;

      //  [XmlInclude(typeof(sala))]
      //  [XmlInclude(typeof(funcionario))]
      //  [XmlInclude(typeof(predio))]

        [WebMethod]
          
        public List<sala> GetSalas() {

            repsala = new RepositorioSala();

            return repsala.Getall();

        }

    }
}
