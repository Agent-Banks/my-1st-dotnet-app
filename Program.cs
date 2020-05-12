using System;

namespace my_1st_dotnet_app
{
  class Program
  {
    static void Main(string[] args)
    {
      //vars declared
      var numberOfCupsOfCoffee = 2;
      var fullName = "Cody Banks";
      DateTime today = DateTime.Today;

      // terminal outputs variables into string
      Console.WriteLine($"Hello, My Name is {fullName} and I have drank {numberOfCupsOfCoffee} cups of coffee today on {today.ToLongDateString()}.");
      
      // user inputs and terminal reads line
      Console.WriteLine("What is your name?");
      var userName = Console.ReadLine();

      // special response if username is Alice
      if (userName == "Alice")
      {
        Console.WriteLine($"{userName}?!? The force is with you!!!");
      }
      else{
        Console.WriteLine($"It is nice to meet you, {userName}");
      }

      // user inputs and terminal reads line
      Console.WriteLine($"{userName}, How old are you?");
      var firstNumberAsString = Console.ReadLine();

      // user inputs and terminal reads line
      Console.WriteLine($"{userName}, Whats your favorite number?");
      var secondNumberAsString = Console.ReadLine();

      // convert ints from user input into string
      var firstNumber = double.Parse(firstNumberAsString);
      var secondNumber = double.Parse(secondNumberAsString);

      // required math equations
      var sum = firstNumber + secondNumber;
      var difference = secondNumber - firstNumber;
      var product = firstNumber * secondNumber;
      var quotient = firstNumber / secondNumber;
      var remainder = firstNumber % secondNumber;

      // terminal displays outputs to user for better understanding of what is going on
      Console.WriteLine($"{userName}, {firstNumber} + {secondNumber} = {sum}");
      Console.WriteLine($"{userName}, {secondNumber} - {firstNumber} = {difference}");
      Console.WriteLine($"{userName}, {firstNumber} * {secondNumber} = {product}");
      Console.WriteLine($"{userName}, {firstNumber} / {secondNumber} = {quotient}");
      Console.WriteLine($"{userName}, When {firstNumber} and {secondNumber} are divided the remainder would = {remainder}");

    }
  }
}
