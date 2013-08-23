using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SSExample.Domain.Models;

namespace SSExample.Domain
{
    public interface IBusinessLogic
    {
        DemoResponse GetDemo(DemoRequest request);
    }
    
    public class BusinessLogic : IBusinessLogic
    {
        public DemoResponse GetDemo(DemoRequest request)
        {
            return new DemoResponse() { Id = request.Id, Description = "a return model", Name = request.Name + " hello" };
        }
    }
}
