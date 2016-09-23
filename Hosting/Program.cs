using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.ServiceModel;
using System.ServiceModel.Description;
using SCF.Common;
using SCF.Model;
using SCF.WcfService;

namespace Hosting
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(BookService)))
            {
                host.AddServiceEndpoint(typeof(IBookService), new WSHttpBinding(),"http://127.0.0.1:8888/BookService");
                if (host.Description.Behaviors.Find<ServiceMetadataBehavior>() == null)

                {
                    ServiceMetadataBehavior behavior = new ServiceMetadataBehavior();
                    behavior.HttpGetEnabled = true;
                    behavior.HttpGetUrl = new Uri("http://127.0.0.1:8888/BookService/metadata");
                    host.Description.Behaviors.Add(behavior);
                }
                host.Opened += delegate

                {
                    Console.WriteLine("BookService，按任意键终止服务！");
                };

                host.Open();
                Console.Read();

            }
        }
    }
}
