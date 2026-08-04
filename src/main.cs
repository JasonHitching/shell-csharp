using System.ComponentModel.Design;

class Program
{
  static readonly List<string> builtins = ["echo", "exit", "type"];

  static void Main()
  {
    while (true)
    {
      Console.Write("$ ");
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

          if (CheckForBuiltin(secondCommand)) // recognised supported command
          {
            Console.WriteLine($"{secondCommand} is a shell builtin");
          }
          else
          {
            CheckForPath(secondCommand);
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

  static bool CheckForBuiltin(string secondCommand)
  {
    if (builtins.Contains(secondCommand)) // recognised supported command
    {
      return true;
    }

    return false;
  }

  static bool CheckForPath(string secondCommand)
  {
    var path = Environment.GetEnvironmentVariable("PATH"); ;

    var folderPaths = path?.Split(':');

    foreach (var folderPath in folderPaths!)
    {
      Console.WriteLine(folderPath);
    }

    return true;
  }
}
