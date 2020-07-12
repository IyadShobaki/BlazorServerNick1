using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Services
{
    public class RandomService
    {
        public Guid RandomId { get; } = Guid.NewGuid();
    }
}
