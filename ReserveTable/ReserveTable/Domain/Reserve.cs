namespace ReserveTable.Domain
{
    internal interface Reserve
    {
        string Name { get; }
        string Description { get; set; }
        decimal GetPrice();
    }
}
