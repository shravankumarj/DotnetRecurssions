using System;

namespace Graph
{
  class Program
  {
    static void Main(string[] args)
    {


      int[][] matrix = new int[][]{
        new int[]{1,1,0,1},
        new int[]{0,1,0,0},
        new int[]{0,0,1,1},
        new int[]{1,0,1,0}
      };    //graph.dfs();
      int numberofislands = numberofIslands(matrix);
      System.Console.WriteLine(numberofislands);
      Console.ReadLine();
    }

    private static int numberofIslands(int[][] matrix)
    {
      //Loop over the Matrix for rows and columns

      int count = 0;
      for (int i = 0; i < matrix.Length; i++)
      {
        for (int j = 0; j < matrix[0].Length; j++)
        {
          if (matrix[i][j] == 1)
          {
            //if Matrix value is 1
            // Change the value from 1 to 0
            // Check the adjacency rows and columns that is i-1,i+1, j-1, j+1
            //Increment the counter
            exploit(matrix, i, j);
            count++;
          }
        }

      }
      return count;
    }

    private static void exploit(int[][] matrix, int i, int j)
    {
      //Edge case for the rows if it Less than 0 or greater than the rows; we consider as water and return by default
      if (i < 0 || i >= matrix.Length)
        return;

      //Edge case for the columns if it Less than 0 or greater than the columns; we consider as water and return by default
      if (j < 0 || j >= matrix[i].Length)
        return;

      ///if the matrix value is 0; nothing to return 
      if (matrix[i][j] == 0)
        return;

      //if none of the above conditions are true, by default value be 1 and make it zero
      matrix[i][j] = 0;

      //Now check the adjacency rows and colums 

      exploit(matrix, i + 1, j);
      exploit(matrix, i - 1, j);
      exploit(matrix, i, j + 1);
      exploit(matrix, i, j - 1);

    }
  }
}
