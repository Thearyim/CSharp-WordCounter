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
      WordCounter WordCounter = new WordCounter();
      int result = wordCounter.GetWordCount(userText);
      Console.WriteLine("WordCounted: " + result);
    }
  }

}
