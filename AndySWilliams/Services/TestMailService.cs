using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.Logging;

namespace AndySWilliams.Services
{
    public class TestMailService : ITestMailService
    {
        private readonly ILogger<TestMailService> _logger;

        public TestMailService(ILogger<TestMailService> logger)
        {
            _logger = logger;
        }

        public void SendEmailMessage(string emailTo, string emailSubject, string emailBody)
        {
            _logger.LogInformation($"To:{emailTo} Subject: {emailSubject} Body{emailBody}");
        }
    }
}
