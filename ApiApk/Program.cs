using ApiApk;
using AutoMapper;
using Microsoft.Owin.Hosting;
using Sanegeo.ApiApk.Classes;
using Cos.Core.AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;

namespace Sanegeo.ApiApk
{
    class Program
    {
        static void Main()
        {
            //using (var service = new Service())
            //ServiceBase.Run(service);

            Mapper.Initialize(x =>
            {
                x.AddProfile<GlobalModelMapping>();
            });

            ThreadPool.QueueUserWorkItem(o => APIStart());

            Console.ReadKey();
        }

        private static void APIStart()
        {
            WebApp.Start<Startup>("http://+:1100");
        }
    }
}
