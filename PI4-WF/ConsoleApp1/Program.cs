using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using PI4_WEBSERVICE.Modelo;

namespace ConsoleApp1
{
    class Program
    {
        

        static void Main(string[] args)
        {

            var repsala = new RepositorioSala();

            var aux = repsala.Getall();

            foreach (var item in aux)
            {

            }

        }
    }
}
