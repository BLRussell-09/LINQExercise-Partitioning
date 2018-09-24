using System;
using System.Collections.Generic;
using System.Linq;

namespace PartitioningOps
{
  class Program
  {
    static void Main(string[] args)
    {
      /*
        Store each number in the following List until a perfect square
        is detected.

        Ref: https://msdn.microsoft.com/en-us/library/system.math.sqrt(v=vs.110).aspx
      */
      List<int> wheresSquaredo = new List<int>()
      {
          66, 12, 8, 27, 82, 34, 7, 50, 19, 46, 81, 23, 30, 4, 68, 14
      };

      var findSquare = from number in wheresSquaredo
                       let n = Math.Sqrt(number)
                       where n % 1 == 0
                       select n;

      foreach (var number in findSquare)
      {
        Console.WriteLine(number);
      }

      Console.ReadLine();
    }
  }
}
