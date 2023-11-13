using ReserveTable.Domain;
using System;

namespace ReserveTable.Factories
{
    internal class NTFactory : ReserveFactory
    {
        private readonly decimal _price;
        private readonly string _description;

        public NTFactory(decimal price, string description)
        {
            _price = price;
            _description = description;
        }

        public override Reserve GetReserve()
        {
            NT membership = new NT(_price)
            {
                Description = _description
            };

            return membership;
        }
    }
}
