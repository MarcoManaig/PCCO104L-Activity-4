using System;

class Program {
  public static void Main (string[] args) {

    int prevNum = 0;
    string mess = "";

    while(true){
      Console.Write("Enter a value: ");
      string input = Console.ReadLine();

      if (input.ToLower() == "exit"){
        Console.WriteLine("Closing the program...");
        break;
      }
      int num;
      bool isNumeric = int.TryParse(input, out num);

      if (isNumeric){
        int currNum = int.Parse(input);
        int sum = prevNum + currNum;

        Console.WriteLine($"Sum of {prevNum} and {currNum} is {sum}");
        prevNum = currNum;
      }
      else{
        mess += input + "";
        Console.WriteLine("Current message is: " + mess);

      }
    }
  }
}