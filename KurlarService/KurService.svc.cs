﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;

namespace KurlarService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class KurService : IKurService
    {

    
        public List<double> KurlariGetir(string kurTipi)
        {
            Random randomKur = new Random();
            List<double> kurlarListesi = new List<double>();
            for (int i = 0; i < 15; i++)
            {
                kurlarListesi.Add(randomKur.NextDouble() + 2);
            }
            return kurlarListesi;
        } 

        public List<string> ParaBirimleriGetir()
        {
            List<string> paraBirimleri = new List<string>();
            paraBirimleri.Add("TL");
            paraBirimleri.Add("Dolar");
            paraBirimleri.Add("Euro");
            paraBirimleri.Add("Pound");

            return paraBirimleri;
        }
    }
}
