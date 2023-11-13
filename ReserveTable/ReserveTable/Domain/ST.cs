namespace ReserveTable.Domain
{
    internal class ST : Reserve
    {
        private readonly string _name;
        private readonly decimal _price;
        
        public ST(decimal price)
        {
            _price = price;
            _name = " Повсякденна";
        }

        public string Name => _name;
        public string Description { get; set; }
        public decimal GetPrice() => _price;
    }

}
