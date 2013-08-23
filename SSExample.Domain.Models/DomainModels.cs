using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSExample.Domain.Models
{
    [Serializable]
    public class DemoRequest
    {
        public long Id { get; set; }
        public string Name { get; set; }
    }

    [Serializable]
    public class DemoResponse
    {
        public long Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}
