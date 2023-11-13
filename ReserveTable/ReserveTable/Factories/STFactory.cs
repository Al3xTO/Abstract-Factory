using ReserveTable.Domain;
using System;

namespace ReserveTable.Factories
{
    internal class STFactory : ReserveFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public STFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override Reserve GetReserve()
        {
            ST membership = new ST(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
