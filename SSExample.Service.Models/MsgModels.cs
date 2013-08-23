using System;
using AutoMapper;
using ServiceStack.ServiceHost;
using SSExample.Domain.Models;

namespace SSExample.Service.Models
{

    [Serializable]
    [Api("GetDemo")]
    [Route("/demo/{Id}", Verbs = "GET", Summary = "Returns the demo response.")]
    [Route("/v2/demo/{Id}/{Name}", Verbs = "GET", Summary = "Returns the named demo response.")]
    public class DemoRequestMsg : IReturn<DemoResponse>
    {
        public DemoRequestMsg()
        {
            Name = string.Empty;
        }

        [ApiMember(Name = "Id", AllowMultiple = false, DataType = "long",
            IsRequired = true, ParameterType = "path",
            Description = "Id is the internal global identifier.")]
        public long Id { get; set; }

        [ApiMember(Name = "Name", AllowMultiple = false, DataType = "string",
            IsRequired = false, ParameterType = "path",
            Description = "Name is the internal name.")]
        public string Name { get; set; }
    }

    //conversion extensions
    public static class Mappings
    {
        static Mappings()
        {
            Mapper.CreateMap<DemoRequestMsg, DemoRequest>();
        }

        public static DemoRequest ToDemoRequest(this DemoRequestMsg request)
        {
            return Mapper.Map<DemoRequest>(request);
        }
    }
}
