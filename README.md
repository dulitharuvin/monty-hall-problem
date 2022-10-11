# Mont Hall Problem Simulation

## How to run the programe in your local machine

### Prerequisites

- .NET 6.0 installed
- node js runtime >= v16.00

### clone the repository in to your local machine, by opening a terminal/ command line prompt
- > git clone https://github.com/dulitharuvin/monty-hall-problem.git

### Change your directory to the project root
- > cd monty-hall-problem

### Change your directory to the back end project by
- > cd BackEnd
- > cd BackEnd.Api

### Run the back end by executing your 
- > dotnet build
- > dotnet run

### Change your directory back and in to again to the front-ent project directory
- > cd ../front-end

### Run the front end project to prop up the interface to invoke the backend which is already running on your local machine
- > npm start


### To run the unit test cases for the Backend of the application
navigate in to the BackEnd.Tests directory then run
- > dotnet test


#### this will open up a browser window with a webpage where you can enter the desired number of Monty Hall Problem games you want to simulate and whether to change the firstly selected door or not
