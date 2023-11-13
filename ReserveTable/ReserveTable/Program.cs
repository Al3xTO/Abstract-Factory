using ReserveTable.Domain;
using ReserveTable.Factories;
class Program
{
    static void Main()
    {
        Console.WriteLine("Оберіть тип сервування:");
        Console.WriteLine("S - Повсякденна");
        Console.WriteLine("N - Класична");
        Console.WriteLine("B- Елітна");

        string membershipType = Console.ReadLine();

        ReserveFactory factory = GetFactory(membershipType);

        Reserve membership = factory.GetReserve();

        Console.WriteLine("\nОбрано: \n");

        Console.WriteLine(
            $"\tТип сервування:\t\t{membership.Name}\n" +
            $"\tТип посуду:\t{membership.Description}\n" +
            $"\tЦіна:\t\t{membership.GetPrice()}");

        Console.ReadLine();


    }

    private static ReserveFactory GetFactory(string membershipType) =>
        membershipType.ToLower() switch
        {
            "s" => new STFactory(100, "Однотонний стандартний посуд"),
            "n" => new NTFactory(250, "З поштучним посудом, легким декором"),
            "b" => new BTFactory(900, "Ексклюзивний порцеляновий або кришталевий"),
            _ => null
        };
}
