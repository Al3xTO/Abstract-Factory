namespace ReserveTable.Domain
{
    internal class NT : Reserve
    {
        private readonly string _name;
        private readonly decimal _price;

        public NT(decimal price)
        {
            _price = price;
            _name = "Класична";
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }

}
