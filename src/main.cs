class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("$ ");

            var fullInput = Console.ReadLine();

            if (fullInput is not null)
            {
                var command = string.Split(fullInput).First();
            }

            switch (command) {
              case "exit":
                break;
              case "echo":
                Console.WriteLine(command);
                break;
              default:
                Console.WriteLine($"{command}: command not found");
                break;
            };
        }
    }
}
