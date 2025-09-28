using System;

class Program
{
static void Main(string[] args)
{
Console.WriteLine("HEllo . Welcome to the spare parts inventory!");

```
    List<string> inventory = new List<string>
    {
        "hydraulic pump",
        "PLC module",
        "servo motor"
    };

    bool partAvailable = false;

    while (!partAvailable)
    {
        Console.Write("\ Which part do you need?. ");
        string input = Console.ReadLine();

        if (inventory.Contains(input))
        {
            Console.WriteLine($"I have got "" for here you. Bye!");
            partAvailable = true;
        }
        else
        {
            Console.WriteLine($"I am afraid we don’t have any "" in the inventory.");
        }
    }
}
```

}
