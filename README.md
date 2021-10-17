# C Sharp Basics with OOP
<h1 align="center">
  <br>
Traffic Sign Recognition
  <br>
  <img src="https://github.com/kfirlevi/C-Sharp-Basics-with-OOP/blob/main/source/Grocery_store_image.jfif" height="200">
</h1>
  <p align="center">
    <a href="https://github.com/kfirlevi"> Kfir Levi </a> 
  </p>

Learning to use object oriented programming in C#

The Main function is in file 'Program.cs'.

## Agenda

|File       | Topics Covered |
|----------------|---------|
|`Program.cs`| the main file of the project |
|`Person.cs`| a class that represents a person and it's properties |
|`Costumer.cs`| a class for costumer, inherits Person's properties and add some. Also includes costumers related functions |
|`Product.cs`| a class that represents a product and it's properties |
|`Register.cs`| a class that represents a register and it's properties |
|`Worker.cs`| a class that represents a worker and it's properties, also includes workers related functions |
|`EntranceQueue.cs`| functions for entrance queue managing|
|`QueueManagement.cs`| a sub console menu that uses the `EntranceQueue.cs` functions, accessed from the main menu |
|`RegistersQueue.cs`| functions for register queue managing|
|`RegisterManagement.cs`| a sub console menu that uses the `RegistersQueue.cs` functions, accessed from the main menu |
|`WorkersManagement.cs`| a sub console menu that uses the `Worker.cs` functions, accessed from the main menu |


## Running The Code
To run the code, please enter the `Program.cs` file. 
### Main Menu:
In the main menu, you can access one of 3 sub-menus: (and also can get back to the main menu from each sub menu)
#### Queue Management:
Here, you can accept a new costumer to the line (pending coronavirus rules clearance), accept a few costumers into the shop, and also check who are the costumers that currently occupy the queue. Each costumer's amount and kinds of products that he purchases, are chosen randomaly. After that, the costumer will choose the register with the shortest queue.
#### Register Management:
Here, you can access the clients that have visited the register, and all the products that were bought. In addition, you can access workers' shifts records and also check how long the queue in each register is.
#### Workers Management:
This menu is designated for the workers themselves. Each worker can start his shift (pending coronavirus rules clearance), end his shift, and also look at his shifts records from the past.
