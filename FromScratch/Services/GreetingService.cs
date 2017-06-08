using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FromScratch.Models;
using Microsoft.Extensions.Configuration;

namespace FromScratch.Services
{
    public interface IGreetingService
    {
        GreetingMessage GetTodaysGreeting();
    }

    public class GreetingService : IGreetingService
    {
        private int _id = 1;
        private IConfiguration _config;

        public GreetingService(IConfiguration config)
        {
            _config = config;
        }

        public GreetingMessage GetTodaysGreeting() => new GreetingMessage
        {
            Id = _id++,
            Text = _config.GetValue<string>("message")
        };
    }
}