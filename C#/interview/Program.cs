// using System;
// using System.IO;
// using System.Collections.Generic;
// using System.Text;

// public static class Program
// {

//     public static bool IsValid(string input)
//     {
//         int[] array = Array.ConvertAll(input.Split(','), Int32.Parse);

//         int[,] board = new int[9, 9];
//         int k = 0;

//         // Adding from the array to a 9 x 9 board.
//         for (int i = 0; i < board.GetLength(0); i++)
//         {
//             for (int j = 0; j < board.GetLength(1); j++)
//             {
//                 board[i, j] = array[k];
//                 k++;
//             }

//         }
//         for (int i = 0; i < board.GetLength(0); i++)
//         {
//             // temporary variable to hold set of values in col and row
//             HashSet<int> rowSets = new HashSet<int>();
//             HashSet<int> colSets = new HashSet<int>();

//             for (int j = 0; j < board.GetLength(1); j++)
//             {
//                 // checking if it's empty
//                 if (board[i, j] == 0 || board[j, i] == 0) continue;

//                 // Checking each row and column if they only contain one value.
//                 /*
//                 1. Check each cell of th of the soduku board, if the current value
//                 of the current cell is in the row set or collumn set,
//                 if so duplicate is detected and the soduku board is not valid

//                 ELSE: add the value to the row and column set ans move on to the next cell.

//                 And repear cycle till end of board is reached
//                 */
//                 if (rowSets.Contains(board[i, j] - 1) || colSets.Contains(board[j, i] - 1))
//                 {

//                     return false;
//                 }
//                 else
//                 {

//                     rowSets.Add(board[i, j] - 1);
//                     colSets.Add(board[j, i] - 1);
//                 }

//             }
//         }

//         //Checking 3x3
//         /*

//         Repeating the same steps as above to now on a 3x3 scale.
//         Instead of keeping track of whople row and column, we're now storing sets of 3x3 
//         matrix.

//         */
//         for (int a = 0; a < 9; a += 3)
//         {
//             for (int b = 0; b < 9; b += 3)
//             {

//                 HashSet<int> threeBythree = new HashSet<int>();
//                 // 3 x 3 board
//                 for (int c = a; c < a + 3; c++)
//                 {
//                     for (int d = b; d < b + 3; d++)
//                     {
//                         if (board[c, d] == 0) continue;
//                         if (threeBythree.Contains(board[c, d] - 1))
//                         {
//                             return false;
//                         }
//                         else
//                         {
//                             threeBythree.Add(board[c, d] - 1);
//                         }
//                     }
//                 }
//             }

//             return true;
//         }
//         return false;   // default value; 

//     }

//     static void Main()
//     {
//         using (StreamReader reader = new StreamReader(Console.OpenStandardInput()))
//             while (!reader.EndOfStream)
//             {
//                 string line = reader.ReadLine();
//                 bool res = IsValid(line);
//                 Console.WriteLine(res);
//             }
//     }
// }