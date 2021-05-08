# Pierre's Bakery

#### _A place to order bread and pastries, 5/7/2021_

#### By _**Tiffany Greathead**_

## Description

Pierre's Bakery is a command line interface program built with C#. A user can choose whether they would like to buy loaves of bread or pastries by typing in "b" or "p" on their keyboard. Next, the program will ask how much of the product the user would like to buy and generate the total cost for that order. The user is allowed multiple chances to add anything else to their order until the user types "e" to exit. Once the user types "e", the program will return the overall total cost of all orders made and exit.

## Setup and Use

### Prerequisites

- [.NET 5 SDK](https://dotnet.microsoft.com/download/dotnet/5.0)
- A text editor like [VS Code](https://code.visualstudio.com/)
- A command line interface like Terminal or GitBash to run and interact with the console app.

### Installation

1. Clone the repository: `$ git clone https://github.com/TorchAblaze/PierresBakery.Solutions.git`
2. Navigate to the `PierresBakery.Solutions` directory on your computer
3. Open with your preferred text editor to view the code base
4. To run the console app:
   - Navigate to `PierresBakery.Solutions/PierresBakery` in your command line
   - Run the command `dotnet restore` to restore the dependencies that are listed in `PierresBakery.csproj`
   - Run the command `dotnet build` to build the project and its dependencies into a set of binaries
   - Finally, run the command `dotnet run` to run the project!
   - Note: `dotnet run` also restores and builds the project, so you can use this single command to start the console app
5. To run tests:
   - Navigate to `PierresBakery.Solutions/PierresBakery.Tests` in your command line.
   - Run the command `dotnet restore` to restore the dependencies that are listed in `PierresBakery.Tests.csproj`
   - Finally, run the command `dotnet test` to run the tests!

## Known Bugs

- No error handling for improper amount input

## Support and contact details

_Please reach out through my GitHub account._

## Technologies Used

- C#
- .NET 5 SDK
- VS Code

### License

MIT License.

Copyright (c) 2021 **_Tiffany Greathead_**
