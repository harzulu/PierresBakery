# Pierre's Bakery

#### Go bakery shopping!, 12.08.2020

#### By Ben McFarland

## Description

Go shopping at Pierre's Bakery and see what baked goods you'd like and how much they'd cost.

## Technologies used

* Microsoft Visual Studio Code
* Git/GitHub
* C# v 7.3
* .NET Core v 2.2
* REPL
* MSTest

## Installation Requirements

#### For Both Mac & Windows systems

- Once you have Git installed on your computer, go to this (GitHub repository)[https://github.com/harzulu/PierresBakery], click the "Fork" button in the upper right hand corner of the page, and clone this application with the following command:`git clone https://github.com/harzulu/PierresBakery.git`.


#### Installing C#, .NET, dotnet script, & MySQL

###### This program requires C# and the .NET Framework to be installed on your machine:

###### For Mac
 * Download this .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.106-macos-x64-installer]. Clicking this link will prompt a .pkg file download from Microsoft.
* Open the .pkg file. This will launch an installer which will walk you through installation steps. Use the default settings the installer suggests.
* Confirm the installation is successful by opening your terminal and running the command `$ dotnet --version`, which should return something like: `2.2.105`. 

###### For Windows (10+)
* Download this 64-bit .NET Core SDK (Software Development Kit)[https://dotnet.microsoft.com/download/thank-you/dotnet-sdk-2.2.203-windows-x64-installer]. Clicking these links will prompt a .exe file download from Microsoft.
* Open the file and follow the steps provided by the installer for your OS.
* Confirm the installation is successful by opening a new Windows PowerShell window and running the command `dotnet --version`. You should see something a response like this: `2.2.105`.

#### For Mac & Windows Operating Systems
* Install dotnet script with the following terminal command `dotnet tool install -g dotnet-script`.

#### Opening the Project on your Local System
* Once the project has been cloned to your computer and you have all the necessary items on your local computer, open the project in the application of your choice ((Visual Code Studio)[https://code.visualstudio.com/] was used and is recommended by the application builder), and run the following...

* `dotnet build` will get bin/ and obj/ folders downloaded.
* `dotnet run` will run the application. 


### Specs

| Spec                                            | Input                        | Output                        |
| :---------------------------------------------- | :--------------------------- | :---------------------------- |
| **Returns user input for number of bread loaves and pastries** | {7, 5} | {7, 5} |
| **Returns the price of one bread loaf** |  | 5 |
| **Returns the price of one pastry** |  | 2 |
| **Returns the cost of the number of loaves the user entered** | 7 | 35 |
| **Returns the cost of the number of pastries the user entered** | 5 | 10 |
| **Returns the total cost of bread and pastries** | {7, 5} | 25 |
| **Return the how many groups of 3 are there of bread** | 7 | 2 |
| **Returns cost of bread with every 3rd free** | 7 | 25 |
| **Returns how many groups of 3 there are of pastries** | 5 | 1 |
| **Return cost of one group of 3** | 3 | 5 |
| **Returns the total price of all groups of 3** | 5 | 5 |
| **Returns the remainder of psatries added to the last total** | 5 | 9 |
| **Returns the total for bread and pastries** | {7, 5} | 34 |

### Tests

Describe: InputReturn(list)
Test: "Return the given input"
Expect: InputReturn({7, 5}).toEqual({7, 5})

Describe: BreadPrice()
Test: "Return the price of one loaf of bread"
Expect: BreadPrice().toEqual(5)

Describe: PastryPrice()
Test: "Return the price of one pastry"
Expect: PastryPrice().toEqual(2)

Describe: BreadCost(7)
Test: "Return the cost of number of loaves of bread entered"
Expect: BreadCost(7).toEqual(35)

Describe: PastryCost(5)
Test: "Return the cost of number of pastries entered"
Expect: PastryCost(5).toEqual(10)

Describe: NoDealTotal({7, 5})
Test: "Return the total cost of bread and pastries without deals"
Expect: NoDealTotal({7, 5}).toEqual(45)

Describe: BreadGroupOfThree(7)
Test: "Return the number of groups of 3 of bread"
Expect: BreadGroupOfThree(7).toEqual(2)

Describe: BreadEveryThirdFree(7)
Test: "Return the cost of bread with every 3rd free"
Expect: BreadEveryThirdFree(7).toEqual(25)

Describe: PastryGroupOfThree(5)
Test: "Return the number of groups of 3 of pastries"
Expect: PastryGroupOfThree(5).toEqual(1)

Describe: PastryCostOfOneGroup()
Test: "Return the cost of 3 of pastries"
Expect: PastryCostOfOneGroup().toEqual(5)

Describe: PastryCostOfGroups(5)
Test: "Return the cost of all groups of 3 of pastries"
Expect: PastryCostOfGroups(5).toEqual(5)

Describe: PastryAddRemainder(5)
Test: "Return the cost with remainder of pastries not in group of 3"
Expect: PastryAddRemainder(5).toEqual(9)

Describe: BakeryTotal({7, 5})
Test: "Return the total cost of all bread and patries with deals"
Expect: BakeryTotal({7, 5}).toEqual(34)

## Bugs / Issues

No known bugs or issues

### License & Copyright

_MIT_ Copyright (c) 2020 *_Ben McFarland_*