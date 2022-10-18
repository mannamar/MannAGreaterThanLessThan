// Amardeep Mann
// 10-17-22
// Mini Challenge #4 "Greater Than Or Less Than"
// Ask the user to input two numbers. Then output to the console wether the first is greater than, less than, or equal to the second. Then the same for the second compared to the first

Console.Clear();

bool playAgain = true;

while (playAgain) {

  Console.WriteLine("Hey friend. We're going to compare some numbers\n");

  string numOne;
  bool isNumOneValid = false;
  double num1 = 0;

  Console.WriteLine("Please enter the first number");

  while (!isNumOneValid) {
    numOne = Console.ReadLine();
    isNumOneValid = Double.TryParse(numOne, out num1);
    if (!isNumOneValid) {
      Console.WriteLine("Please enter a valid number");
    }
  }

  string numTwo;
  bool isNumTwoValid = false;
  double num2 = 0;

  Console.WriteLine("Please enter the second number");

  while (!isNumTwoValid) {
    numTwo = Console.ReadLine();
    isNumTwoValid = Double.TryParse(numTwo, out num2);
    if (!isNumTwoValid) {
      Console.WriteLine("Please enter a valid number");
    }
  }

  //string numTwo = Console.ReadLine();

  Console.WriteLine("");

  //int num1 = Convert.ToInt32(numOne);
  //int num2 = Convert.ToInt32(numTwo);

  if ( num1 > num2 ) {
    Console.WriteLine(num1 + " is greater than " + num2);
  } else if ( num1 < num2 ) {
    Console.WriteLine(num1 + " is less than " + num2);
  } else {
    Console.WriteLine(num1 + " equals " + num2);
  }

  if ( num2 > num1 ) {
    Console.WriteLine(num2 + " is greater than " + num1);
  } else if ( num2 < num1 ) {
    Console.WriteLine(num2 + " is less than " + num1);
  } else {
    // Console.WriteLine(num2 + " equals " + num1);
  }

  string response = "";

  while (response != "yes" && response != "no" && response != "y" && response != "n") {
    Console.WriteLine("\nDo you want to play again? (Please type \"y\" or \"n\")");
    response = Console.ReadLine().ToLower();
  }

  if (response == "no" || response == "n") {
    playAgain = false;
    Console.WriteLine("\nGoodbye!");
  } else {
    Console.WriteLine("");
  }
}
