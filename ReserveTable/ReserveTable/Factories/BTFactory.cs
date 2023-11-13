using ReserveTable.Domain;
using System;

namespace ReserveTable.Factories
{
    internal class BTFactory : ReserveFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public BTFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override Reserve GetReserve()
        {
            BT membership = new BT(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
