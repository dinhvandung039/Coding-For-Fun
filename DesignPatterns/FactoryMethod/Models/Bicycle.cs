﻿using FactoryMethod.Creators.CreatorInterfaces;

namespace FactoryMethod.Models
{
    public class Bicycle : IDeliversFood
    {
        public string Color { get; set; }
        public string Style { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }

        public async Task Deliver(int orderId)
        {
            // Logic for delivering food
            await Task.FromResult($"Delivered Order: {orderId} via bicycle!");
        }
    }
}