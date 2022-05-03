using System;
using System.Collections;
using System.Collections.Generic;

namespace C_Sharp_Lesson_3_Homework
{
    public class Homework
    {
        public void GetCentralElementFromMatrix(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result             |
             * |-------------------|--------------------|
             * | {                 |                    |
             * |  { 1,   3,  5},   |    The central     |
             * |  {-1, 100, 11},   |  element is 100    |
             * |  { 2,  15, 44}    |                    |
             * |  }                |                    |
             * |----------------------------------------|
             * |{                  |                    |
             * | { 1,  6, 21,  8 },| This matrix doesn't|
             * | { 5, -4,  5,  7 },| have a central     |
             * | {77,  5,  0, 74 } |  element           |
             * | }                 |                    |
             * ------------------------------------------
             *    
             */
            //your code here

             for (int i = 0; i < matrixOfIntegers.GetLength(0) / 2; i++)

                    for (int j = 0; j < matrixOfIntegers.GetLength(1) / 2; j++)
                    {
                        if ((matrixOfIntegers.GetLength(0) % 2 != 0) && (matrixOfIntegers.GetLength(1) % 2 != 0))
                        {

                            Console.WriteLine(" The central element of this matrix is " + matrixOfIntegers[i + 1, j + 1]);
                        }
                        else
                            Console.WriteLine("This matrix doesn't have a central element.");

                    }

        }
        public void GetSummOfDiagonalsElements(int[,] matrixOfIntegers)
        {
            /*print to console the central element from matrixOfIntegers, if not exist print: "This matrix doesn't have a central element"
             * |   input           | result              |
             * |-------------------|---------------------|
             * | {                 |                     |
             * |  { 1,   3,  5},   | First diagonal: 145 |
             * |  {-1, 100, 11},   | Second diagonal: 107|
             * |  { 2,  15, 44}    |                     |
             * |  }                |                     |
             * |-----------------------------------------|
             * |{                  |                     |
             * | { 1,  6, 21,  8 },| This matrix doesn't |
             * | { 5, -4,  5,  7 },| have a diagonals    |
             * | {77,  5,  0, 74 } |                     |
             * | }                 |                     |
             * ------------------------------------------
             *    
             */

            int sumFirst = 0;
            int sumSecond = 0;
            int x = 0;
            int rows = matrixOfIntegers.GetLength(0);
            int columns = matrixOfIntegers.GetLength(1);

            if (rows.Equals(columns) && rows > 1)
            {
                for (int i = 0; i < rows; i++)
                    sumFirst = sumFirst + matrixOfIntegers[i, i];

                Console.WriteLine("First diagonal: "+ sumFirst);


                for (int j = rows - 1; j >= 0; j--)
                    sumSecond = sumSecond + matrixOfIntegers[x++, j];

                Console.WriteLine("Second diagonal is: " + sumSecond);
            }
            else
            {
                Console.WriteLine("This matrix doesn't have a diagonal.");
            }
        }
        public void StarPrinter(int triangleHight)
        {
            /* Write a programm that will print a triagle of stars  with hight = triangleHight
             *  Example: triangleHight = 3;
             *  Result:   *
             *           * *
             *          * * * 
             */
            //your code here
            int hight = triangleHight;


            for (int i = 1; i <= hight; i++)
            {
                for (int j = 1; j <= hight - i; j++)
                {
                    Console.Write(" ");
                    
                }
                for (int j = 1; j <= (2 * i) - 1; j++)
                {
                    Console.Write("*");
                    
                }
                Console.WriteLine();


            }
           
        }
        public void SortList(IList<int> listOfNumbers)
        {
            //Print to console elements of  listOfNumbers in ascending order
            //your code here

            int temp;
            for (int i = 0; i < listOfNumbers.Count-1; i++)

                for (int j = i+1; j < listOfNumbers.Count; j++)

                    if (listOfNumbers[i] > listOfNumbers[j])
                    {

                        temp = listOfNumbers[i];
                        listOfNumbers[i] = listOfNumbers[j];
                        listOfNumbers[j] = temp;

                    }
            Console.WriteLine("Sorted: ");
            foreach (int num in listOfNumbers)
            {
                Console.Write(num + " ");
            }
        }
        public static void Main(String[] args)
        {
            Homework homework = new Homework();

            IList<int> list = new List<int>() { -5, 8, -7, 0, 44, 121, -7 };

            int[,] matrix = new int[3, 3] {
                { 1,   3,  5},
                { 2, 3, 5},
                {100, 56 , -54} };
            int[,] matrix2 = new int[3, 4] {
                { 1,   3,  5,   6},
                { 2,   3,  5,  78},
                {100, 56 , -54, 6} };

            homework.GetCentralElementFromMatrix(matrix);
            homework.GetCentralElementFromMatrix(matrix2);
            homework.GetSummOfDiagonalsElements(matrix);
            homework.GetSummOfDiagonalsElements(matrix2);
            homework.StarPrinter(5);
            homework.SortList(list);




           
        }

    }
}
    