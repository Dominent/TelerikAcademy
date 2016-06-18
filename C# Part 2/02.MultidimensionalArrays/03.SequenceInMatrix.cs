using System;
using System.Linq;

namespace SequenceInMatrix
{
    class SequenceInMatrix
    {
        private static void Main()
        {
            int[] dimensions = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

            int rows = dimensions[0];
            int cols = dimensions[1];

            int bestLeftDiagonalSeqLength = 0;
            int bestRightDiagonalSeqLength = 0;

            string currentNum = "?";
            string previousNum = "?";

            int count = 1;
            int bestCount = 0;

            string[,] matrix = new string[rows, cols];

            string[] input = Console.ReadLine().Split(' ').ToArray();

            for (int i = 0; i <= rows - 1; i++)
            {
                /*---------------- Horizontal Lines Algorithm----------------*/

                previousNum = input[0];
                for (int j = 0; j < cols; j++)
                {
                    currentNum = input[j];
                    if (previousNum == currentNum) count++;
                    else
                    {
                        if (count > bestCount) bestCount = count;
                        count = 1;
                        previousNum = currentNum;
                    }
                    matrix[i, j] = input[j];
                }
                if (count > bestCount) bestCount = count;
                count = 1;

                if (i < rows - 1) input = Console.ReadLine().Split(' ').ToArray();
            }

            /*---------------- Vertical Lines Algorithm----------------*/

            previousNum = matrix[0, 0];
            int x = 0, y = 0;
            for (y = 0; y < cols; y++)
            {
                for (x = 0; x < rows; x++)
                {
                    currentNum = matrix[x, y];
                    if (previousNum == currentNum) count++;
                    else
                    {
                        if (count > bestCount) bestCount = count;
                        count = 1;
                        previousNum = currentNum;
                    }
                }
                if (count > bestCount) bestCount = count;
                count = 1;
            }

            /*----------------Diagonal Algorithm----------------*/ //ToDo Not working atm, dont have time :(

            //int leftDiagonalSeqLength = 0;
            //int rightDiagonalSeqLength = 0;

            //string currentLeftDNum = "?";
            //string currentRightDNum = "?";

            //string previousLeftDNum = "?";
            //string previousRightDNum = "?";

            //for (int i = 0; i < cols; i++)
            //{
            //    int xLeft = 0;
            //    int yLeft = i;

            //    int xRight = 0;
            //    int yRight = (cols - 1) - i;

            //    previousLeftDNum = matrix[xLeft, yLeft];
            //    previousRightDNum = matrix[xRight, yRight];

            //    while ((xLeft < rows && xRight < rows) && (yLeft < cols && yRight >= 0))
            //    {
            //        currentLeftDNum = matrix[xLeft, yLeft];
            //        ++xLeft;
            //        ++yLeft;
            //        if (currentLeftDNum == previousLeftDNum) leftDiagonalSeqLength++;
            //        else
            //        {
            //            if (bestLeftDiagonalSeqLength < leftDiagonalSeqLength)
            //                bestLeftDiagonalSeqLength = leftDiagonalSeqLength;
            //            previousLeftDNum = currentLeftDNum;
            //            leftDiagonalSeqLength = 0;
            //        }

            //        currentRightDNum = matrix[xRight, yRight];
            //        ++xRight;
            //        --yRight;
            //        if (currentRightDNum == previousRightDNum) rightDiagonalSeqLength++;
            //        else
            //        {
            //            if (bestRightDiagonalSeqLength < rightDiagonalSeqLength)
            //                bestRightDiagonalSeqLength = rightDiagonalSeqLength;
            //            previousRightDNum = currentRightDNum;
            //            rightDiagonalSeqLength = 0;
            //        }

            //        if (leftDiagonalSeqLength > bestLeftDiagonalSeqLength) bestLeftDiagonalSeqLength = leftDiagonalSeqLength;
            //        if (rightDiagonalSeqLength > bestRightDiagonalSeqLength) bestRightDiagonalSeqLength = rightDiagonalSeqLength;
            //    }

            //}

            //int maxDiagonal = Math.Max(bestLeftDiagonalSeqLength, bestRightDiagonalSeqLength);

            //if (maxDiagonal > bestCount)
            //    bestCount = maxDiagonal;

            Console.WriteLine(bestCount);
        }
    }
}
