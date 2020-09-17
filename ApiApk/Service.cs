using AutoMapper;
using Microsoft.Owin.Hosting;
using Sanegeo.ApiApk.Classes;
using Cos.Core.AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ApiApk
{
    partial class Service : ServiceBase
    {
        public Service()
        {
            InitializeComponent();
        }
        protected override void OnStart(string[] args)
        {
            Mapper.Initialize(x =>
            {
                x.AddProfile<GlobalModelMapping>();
            });

            ThreadPool.QueueUserWorkItem(o => APIStart());
        }
        protected override void OnStop()
        {
            // TODO: Add code here to perform any tear-down necessary to stop your service.
        }

        private void APIStart()
        {
            WebApp.Start<Startup>("http://+:1100");
        }
    }
}
