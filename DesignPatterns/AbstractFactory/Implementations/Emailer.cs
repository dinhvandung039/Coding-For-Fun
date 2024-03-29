﻿using AbstractFactory.Interfaces;
using RealisticDependencies.Interfaces;

namespace AbstractFactory.Implementations
{
    public class Emailer : ISendEmail
    {
        private readonly IApplicationLogger _logger;

        public Emailer(IApplicationLogger logger) { _logger = logger; }

        public async Task SendMessage(EmailMessage message)
        {
            await Task.Delay(1000);
            _logger.LogInfo($"Sent email to: {message.To} with Message: {message.Content}", ConsoleColor.Cyan);
        }
    }
}
