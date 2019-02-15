using System;
using System.Collections.Generic;


namespace WordCount
{

  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Please enter any sentences and have the words counted: ");
      string userText = Console.ReadLine();
      WordCount WordCount = new WordCount();
      int result = WordCount.GetWordCount(userText);
      Console.WriteLine("WordCounted: " + result);
    }
  }

}
