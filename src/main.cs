using System.ComponentModel.Design;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.Write("$ ");

            var command = Console.ReadLine();
            var splitCommand = command.Split(' ');

            switch (splitCommand.First()) {
              case "exit":
                break;
              case "echo":
                Console.WriteLine(splitCommand[1..].ToString());
                break;
              default:
                Console.WriteLine($"{command.First()}: command not found");
                break;
            };
        }
    }
}
