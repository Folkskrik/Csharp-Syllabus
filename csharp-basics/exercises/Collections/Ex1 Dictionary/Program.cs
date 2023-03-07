string[] array = { "Audi", "BMW", "Honda", "Mercedes", "VolksWagen", "Mercedes", "Tesla" };
Dictionary<string, string> dictionary = new Dictionary<string, string>();

foreach (string brand in array)
{
    switch (brand)
    {
        case "Audi":
        case "BMW":
        case "Mercedes":
        case "VolksWagen":
            dictionary.TryAdd(brand, "Germany");
            break;
        case "Honda":
            dictionary.TryAdd(brand, "Japan");
            break;
        case "Tesla":
            dictionary.TryAdd(brand, "USA");
            break;
        default:
            Console.WriteLine($"Unknown brand: {brand}");
            break;
    }
}

foreach (KeyValuePair<string, string> kvp in dictionary)
{
    Console.WriteLine("{0}: {1}", kvp.Key, kvp.Value);
}