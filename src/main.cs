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
    var path = Directory.GetCurrentDirectory();
    Console.WriteLine(path);
    // var environmentPaths = Environment.GetEnvironmentVariables();

    // foreach (var path in environmentPaths)
    // {
    //   Path.
    //   if (path is null) continue;

    //   var directoryFiles = Directory.EnumerateFiles(path.ToString());

    //   foreach (var file in directoryFiles)
    //   {
    //     Console.WriteLine(file);
    //   }
    // }

    return true;
  }
}
