using System.Collections.Generic;

namespace WordCount
{
  public class WordCounter
  {
    public string GetWordCount(string word)
    {
      //gathers both a word and sentence from a user
      //then checks how frequently the word appears
      //in the sentence
      //i.e. Put the garbage out for the garbage truck
      //the: 2
      //garbage: 2
      //put: 2

      ContainsKey(string);
      sentence =;
      //create a dictionary which takes in strings and int
      Dictionary<string, int>//(StringCompare.OrdinalIgnorCase)

      //split sentence into strings of words
      string[] words = sentence.Split(stringSplitOption.RemoveEmptyEntries)

      //forEach word in words
      wordLc = word.ToLower()
      if dictionary.ContainsKey(wordLc)
      {
        dictionary[wordLc]++;
      }
      else
      {
        dictionary.Add(wordLc, 1)
      }

      //KeyValuePair<string, int>
      forEach(var entry in dictionary)
      {
        Output entry.Key(word)Count;
      }

    }
  }
}
