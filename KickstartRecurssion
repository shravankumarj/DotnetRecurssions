using System;

// namespace Recurssion
// {
//   class Program
//   {
//     static int[] board = new int[8];
//     static int MaxRows = 3, MaxCols = 3;
//     static void Main(string[] args)
//     {
 

//       KickstartRecurssion kickstart = new KickstartRecurssion();

//       Console.WriteLine(kickstart.PalindromwithSubString("test"));

//       Console.ReadLine();
 
//       Console.ReadLine();


//     }
//}


using System;

public class KickstartRecurssion
{

  public Boolean PalindromwithSubString(String s)
  {

    if (s.Length == 0 || s.Length == 1)
    {
      return true;
    }

    if (s[0] != s[s.Length - 1])
    {
      return false;
    }

    return PalindromwithSubString(s.Substring(1, s.Length - 2));
  }



}
