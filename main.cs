using System;
using System.Collections.Generic;

class Program {
  public static void Main (string[] args) {
    Kata.TestStrings();
  }
}

//-------------------My Answer-------------------
public static class Kata
{
  //Code to test students answers
  public static void TestStrings()
  {
    //Strings to test
    string[] str = {
      //Missing the letter "n"
      "abcdefghijklmopqrstuvwxyz",
      //Pangram
      "Raw Danger! (Zettai Zetsumei Toshi 2) for the PlayStation 2 is a bit quaint, but an alright game I guess, uh... CJ kicks and vexes Tenpenny precariously? This should be a pangram now, probably.",
      //Missing multiple letters
      "A pangram is a sentence that contains every single letter of the alphabet at least once."
      };
    

    //Correct Answers
    bool[] answer = {false, true, false};

    //Student Answers
    bool[] yourAnswer = {IsPangram(str[0]), IsPangram(str[1]), IsPangram(str[2])};
    
    //Output
    Console.WriteLine("------------------------------------------------------------------------");
    Console.WriteLine($"Test #1 \"{str[0]}\"");
    if(yourAnswer[0] != answer[0])
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Green;
    }
    Console.WriteLine($"Your Answer: {yourAnswer[0]}");
    Console.ResetColor();
    Console.WriteLine($"Correct Answer: {answer[0]}\n");

    Console.WriteLine("------------------------------------------------------------------------");
    Console.WriteLine($"Test #2 \"{str[1]}\"");
    if(yourAnswer[1] != answer[1])
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Green;
    }
    Console.WriteLine($"Your Answer: {yourAnswer[1]}");
    Console.ResetColor();
    Console.WriteLine($"Correct Answer: {answer[1]}\n");

    Console.WriteLine("------------------------------------------------------------------------");
    Console.WriteLine($"Test #3 \"{str[2]}\"");
    if(yourAnswer[2] != answer[2])
    {
      Console.ForegroundColor = ConsoleColor.DarkRed;
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Green;
    }
    Console.WriteLine($"Your Answer: {yourAnswer[2]}");
    Console.ResetColor();
    Console.WriteLine($"Correct Answer: {answer[2]}\n");
    
  }

  //Code for students to write
  public static bool IsPangram(string str)
  {
    string alph = "abcdefghijklmnopqrstuvwxyz";
    bool answer = false;
    Dictionary<string, int> pangram = new Dictionary<string, int>();
    
    for(int i = 0; i < str.Length; i++)
    {
      char a = str[i];
      string b = a.ToString();
      string c = b.ToLower();
      if(!pangram.ContainsKey(c))
      {
        pangram.Add(c, 1);
      }
      else
      {
        int value = pangram[c];
        pangram[c] = value + 1;
      }
    }
    
    int count = 0;
    foreach(char cha in alph)
    {
      string s = cha.ToString();
      if(!pangram.ContainsKey(s))
      {
        continue;
      }
      else
      {
        count++;
      }
    }
    
    if(count == 26)
    {
      answer = true;
    }
    
    return answer;
  }
}

//-------------------Top Answer-------------------
// using System;
// using System.Linq;
// public static class Kata
// {
//   public static bool IsPangram(string str)
//   {
//     return str.Where(ch => Char.IsLetter(ch)).Select(ch => Char.ToLower(ch)).Distinct().Count() == 26;
//   }
// }