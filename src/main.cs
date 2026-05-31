using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("$ ");

            var command = Console.ReadLine();
            var splitCommand = command.Split(' ', 2);

            switch (splitCommand.First()) {
              case "exit":
                return;
              case "echo":
                Console.WriteLine(splitCommand[1]);
                break;
              default:
                Console.WriteLine($"{command}: command not found");
                break;
            };
        }
    }
}
