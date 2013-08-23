using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ServiceStack.WebHost.Endpoints;
using SSExample.Domain;
using SSExample.Service;

namespace SSExample
{
    public class ServiceHost : AppHostBase
    {
        public ServiceHost() : base("ServiceHost", typeof(ExampleService).Assembly) { }

        public override void Configure(Funq.Container container)
        {
            container.RegisterAutoWired<ExampleService>();
 	        container.RegisterAutoWired<BusinessLogic>();
            container.RegisterAutoWiredAs<BusinessLogic, IBusinessLogic>();
        }
    }
}
