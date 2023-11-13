namespace ReserveTable.Domain
{
    internal class BT : Reserve
    {
        private readonly string _name;
        private readonly decimal _price;

        public BT(decimal price)
        {
            _price = price;
            _name = "Елітна";
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }

}
