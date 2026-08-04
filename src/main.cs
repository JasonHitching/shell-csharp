using System.ComponentModel.Design;

class Program
{
  static void Main()
  {
    while (true)
    {
      Console.Write("$ ");

      var builtins = new List<string> { "echo", "exit", "type" };

      var command = Console.ReadLine();
      var splitCommand = command.Split(' ', 2);

      switch (splitCommand.First())
      {
        case "exit":
          return;
        case "echo":
          Console.WriteLine(splitCommand[1]);
          break;
        case "type":
          string secondCommand = splitCommand[1];
          if (builtins.Contains(secondCommand)) // recognised supported command
          {
            Console.WriteLine($"{secondCommand} is a shell builtin");
          }
          else
          {
            Console.WriteLine($"{secondCommand}: not found");
          }
          break;
        default:
          Console.WriteLine($"{command}: command not found");
          break;
      }
      ;
    }
  }
}
