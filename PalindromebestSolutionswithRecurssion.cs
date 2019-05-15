using System;

public class KickstartRecurssion
{
public Boolean PalindromebestSolutionswithRecurssion(string s)
  {
    return PalindromebestSolutionswithRecurssion(s, 0, s.Length - 1);
  }

  private bool PalindromebestSolutionswithRecurssion(string s, int left, int right)
  {
    if (left == right || left == right - 1)
    {
      return true;
    }
    if (s[left] != s[right])
    {
      return false;
    }
    return PalindromebestSolutionswithRecurssion(s, left + 1, right - 1);
  }
}
