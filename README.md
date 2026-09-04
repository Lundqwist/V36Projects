# V36Projects

Console-based set of small sample projects and exercises (Product List Manager variants). The solution is a .NET 10 console application intended for learning and experimentation.

## Contents

- Source: MyProgram.cs and supporting files in the solution
- Purpose: interactive console menus that demonstrate input handling, lists, and simple UI layout in the terminal

## Requirements

- .NET 10 SDK
- Visual Studio 2026 or any editor that supports .NET development

## Building

From the repository root you can build the solution with the dotnet CLI:

```powershell
dotnet build V36Projects.slnx
```

Open the solution in Visual Studio to run and debug the app interactively.

## Running

Run from Visual Studio or use the CLI. If the console project is the startup project in the solution, you can run the solution; otherwise run the project directly:

```powershell
dotnet run --project <path-to-console-project.csproj>
```

When running the app you'll see a menu with product list manager options. Use the numeric options or type `exit` to quit.

## JSON serialization (example)

This project uses System.Text.Json for simple JSON tasks. Example model:

[
  "ASD-221",
  "ASDF-231"
]


## Notes

- The codebase is primarily educational. If you encounter nullable reference warnings (CS8602), ensure Console.ReadLine() results are null-checked before calling instance methods like Trim().

## Contributing

Feel free to fork and submit PRs for improvements or fixes.

## License

This repository does not include a license file. Add one if you intend to publish or share the code openly.

