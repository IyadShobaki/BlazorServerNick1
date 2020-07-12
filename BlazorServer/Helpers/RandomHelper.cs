using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorServer.Helpers
{
    public class RandomHelper
    {
        [JSInvokable]
        public Task<int> GenerateRandomInt(int maxValue)
        {
            return Task.FromResult(new Random().Next(maxValue));
        }
    }
}
