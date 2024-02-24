using System;

class Program {
  public static void Main (string[] args) {

    int prevNum = 0;
    string mess = "";

    Console.WriteLine("Enter something: ");

    while(true){
      Console.Write("Ënter a value: ");
      string input = Console.ReadLine();

      if (input.ToLower() == "exit"){
        Console.WriteLine("Closing the program...");
        break;
      }
      int num = bool isNumeric = int.TryParse(input, out num);

      if (isNumeric){
        int currNum = int.Parse(input);
        int sum = prevNum + currNum;

        Console.WriteLine($"Sum of {prevNum} and {currNum} is {sum}");
        prevNum = currNum;
      }
      else{
        message += input + "";
        Console.WriteLine("Current message is: " + message);

      }
    }
  }
}