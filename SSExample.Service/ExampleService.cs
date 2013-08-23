using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSExample.Domain;
using SSExample.Domain.Models;
using SSExample.Service.Models;

namespace SSExample.Service
{
    public class ExampleService : ServiceStack.ServiceInterface.Service
    {
        private IBusinessLogic _businessLogic;

        public ExampleService(IBusinessLogic businessLogic)
        {
            //can have dependencies injected here using Funq or other IOC container
            _businessLogic = businessLogic;
        }

        public DemoResponse Get(DemoRequestMsg request)
        {
            var demoRequest = request.ToDemoRequest();
            var result = _businessLogic.GetDemo(demoRequest);
            return result;
        }
    }
}
