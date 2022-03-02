# Pizza API

# Quick Start
Make sure that you have the latest version of .NET installed on your machine. When done, cd into the clone repo directory and run:
- dotnet run

After, if you haven't already, install the httprepl from Microsoft using the following command:
- dotnet tool install -g Microsoft.dotnet-httprepl

Finally, when the HTTP Repl has been installed, run
- httprepl https://localhost:7283/
- cd Pizza

# Commands
- get (retrieves all pizzas)
- get [pizza id] (retrieves a pizza by its specific ID. Please see services/PizzaService.cs for the available options)
- delete [pizza id] (deletes the pizza, maybe?)
- put [pizza id] -c {pizza object} (Updates a pizza's attributes. Please see models/pizza.cs to learn what a pizza object consists of)
- post -c {pizza object} (Creates a new pizza and stores in memory. Do not specify an ID for the pizza here, the pizza service will automatically handle this)
