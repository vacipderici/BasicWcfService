using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace KurlarService
{
    
    [ServiceContract]
    public interface IKurService
    {
        
        [OperationContract]
        List<string> ParaBirimleriGetir();

        [OperationContract]
        List<double> KurlariGetir(string kurTipi);

        // TODO: Add your service operations here
    }


    }

