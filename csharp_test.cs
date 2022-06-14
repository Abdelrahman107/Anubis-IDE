using System;

namespace HelloWorld {
  class Program {
    static void Main(string[] args) {
      int x = 20;
      int y = 18;

      for (int i = 0; i < 5; i++) {
        Console.WriteLine(i);
      }
      if (x > y) {
        Console.WriteLine("x is greater than y");
      }
      Console.WriteLine("The end");
    }
  }
}