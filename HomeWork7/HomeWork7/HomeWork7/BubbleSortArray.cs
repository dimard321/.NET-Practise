namespace HomeWork7
{
    public class BubbleSortArray
    {
        public int[,] BubbleSortByCondition(int[,] matrix, Comparison<int> comparer, Func<int[,], int, int, int, (int, int)> sortType)
        {
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
                {
                    int comparativeValue1 = 0;

                    int comparativeValue2 = 0;

                    (comparativeValue1, comparativeValue2) = sortType(matrix, comparativeValue1, comparativeValue2, j);

                    if (comparer(comparativeValue1, comparativeValue2) > 0)
                    {
                        SwapRows(matrix, j, j + 1);
                    }
                }
            }
            return matrix;
        }

        public(int, int) MinElements(int[,] matrix, int min1, int min2, int j)
        {
            min1 = int.MaxValue;

            min2 = int.MaxValue;

            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[j, k] < min1)
                {
                    min1 = matrix[j, k];
                }
                if (matrix[j + 1, k] < min2)
                {
                    min2 = matrix[j + 1, k];
                }
            }

            return (min1, min2);
        }

        public (int, int) MaxElements(int[,] matrix, int max1, int max2, int j)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                if (matrix[j, k] > max1)
                {
                    max1 = matrix[j, k];
                }
                if (matrix[j + 1, k] > max2)
                {
                    max2 = matrix[j + 1, k];
                }
            }

            return (max1, max2);
        }

        public (int, int) SumInRows(int[,] matrix, int sum1, int sum2, int j)
        {
            for (int k = 0; k < matrix.GetLength(1); k++)
            {
                sum1 += matrix[j, k];

                sum2 += matrix[j + 1, k];
            }

            return (sum1, sum2);
        }

        public int[,] BubbleSortByMaxElementInRowAsc(int[,] matrix)
        {
            return BubbleSortByCondition(matrix, (min, max) => min.CompareTo(max), MaxElements);
        }

        public int[,] BubbleSortByMaxElementInRowDesc(int[,] matrix)
        {
            return BubbleSortByCondition(matrix, (min, max) => max.CompareTo(min), MaxElements);
        }

        public int[,] BubbleSortBySumElementsInRowAsc(int[,] matrix)
        {
            return BubbleSortByCondition(matrix, (x, y) => x.CompareTo(y), SumInRows);
        }

        public int[,] BubbleSortBySumElementsInRowDesc(int[,] matrix)
        {
            return BubbleSortByCondition(matrix, (x, y) => y.CompareTo(x), SumInRows);
        }

        public int[,] BubbleSortByMinElementsInRowAsc(int[,] matrix)
        {
            return BubbleSortByCondition(matrix, (x, y) => x.CompareTo(y), MinElements);
        }

        public int[,] BubbleSortByMinElementsInRowDesc(int[,] matrix)
        {
            return BubbleSortByCondition(matrix, (x, y) => y.CompareTo(x), MinElements);
        }

        private void SwapRows(int[,] matrix, int row1, int row2)
        {
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                (matrix[row2, i], matrix[row1, i]) = (matrix[row1, i], matrix[row2, i]);
            }
        }

        /* public int[,] SortSumOfMatrixRowElementsAsc(int[,] matrix)
         {
             for (int i = 0; i < matrix.GetLength(0) - 1; i++)
             {
                 for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
                 {
                     int sum1 = 0;

                     int sum2 = 0;

                     for (int k = 0; k < matrix.GetLength(1); k++)
                     {
                         sum1 += matrix[j, k];

                         sum2 += matrix[j + 1, k];
                     }

                     if (sum1 > sum2)
                     {
                         SwapRows(matrix, j, j + 1);
                     }
                 }
             }
             Console.WriteLine("Матрица, отсортированная по возрастанию суммы строк:");

             return matrix;
         }
         public int[,] SortSumOfMatrixRowElementsDesc(int[,] matrix)
         {
             for (int i = 0; i < matrix.GetLength(0) - 1; i++)
             {
                 for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
                 {
                     int sum1 = 0;

                     int sum2 = 0;

                     for (int k = 0; k < matrix.GetLength(1); k++)
                     {
                         sum1 += matrix[j, k];

                         sum2 += matrix[j + 1, k];
                     }

                     if (sum1 < sum2)
                     {
                         SwapRows(matrix, j, j + 1);
                     }
                 }
             }
             Console.WriteLine("Матрица, отсортированная по убыванию суммы строк:");

             return matrix;
         }

         public int[,] SortOfMaxElementInARowOfTheMatrixAsc(int[,] matrix)
         {
             for (int i = 0; i < matrix.GetLength(0) - 1; i++)
             {
                 for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
                 {
                     int max1 = 0;

                     int max2 = 0;

                     for (int k = 0; k < matrix.GetLength(1); k++)
                     {
                         if (matrix[j, k] > max1)
                         {
                             max1 = matrix[j, k];
                         }
                         if (matrix[j + 1, k] > max2)
                         {
                             max2 = matrix[j + 1, k];
                         }
                     }

                     if (max1 > max2)
                     {
                         SwapRows(matrix, j, j + 1);
                     }
                 }
             }
             Console.WriteLine("Матрица, отсортированная в порядке возрастания по max элементу в строке:");

             return matrix;
         }

         public int[,] SortOfMaxElementInARowOfTheMatrixDesc(int[,] matrix)
         {
             for (int i = 0; i < matrix.GetLength(0) - 1; i++)
             {
                 for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
                 {
                     int max1 = 0;

                     int max2 = 0;

                     for (int k = 0; k < matrix.GetLength(1); k++)
                     {
                         if (matrix[j, k] > max1)
                         {
                             max1 = matrix[j, k];
                         }
                         if (matrix[j + 1, k] > max2)
                         {
                             max2 = matrix[j + 1, k];
                         }
                     }

                     if (max1 < max2)
                     {
                         SwapRows(matrix, j, j + 1);
                     }
                 }
             }
             Console.WriteLine("Матрица, отсортированная в порядке убывания по max элементу в строке:");

             return matrix;
         }

         public int[,] SortOfMinElementInARowOfTheMatrixAsc(int[,] matrix)
         {
             for (int i = 0; i < matrix.GetLength(0) - 1; i++)
             {
                 for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
                 {
                     int min1 = Int32.MaxValue;

                     int min2 = Int32.MaxValue;

                     for (int k = 0; k < matrix.GetLength(1); k++)
                     {
                         if (matrix[j, k] < min1)
                         {
                             min1 = matrix[j, k];
                         }
                         if (matrix[j + 1, k] < min2)
                         {
                             min2 = matrix[j + 1, k];
                         }
                     }

                     if (min1 > min2)
                     {
                         SwapRows(matrix, j, j + 1);
                     }
                 }
             }
             Console.WriteLine("Матрица, отсортированная в порядке возрастания по min элементу в строке:");

             return matrix;
         }

         public int[,] SortOfMinElementInARowOfTheMatrixDesc(int[,] matrix)
         {
             for (int i = 0; i < matrix.GetLength(0) - 1; i++)
             {
                 for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
                 {
                     int min1 = Int32.MaxValue;

                     int min2 = Int32.MaxValue;

                     for (int k = 0; k < matrix.GetLength(1); k++)
                     {
                         if (matrix[j, k] < min1)
                         {
                             min1 = matrix[j, k];
                         }
                         if (matrix[j + 1, k] < min2)
                         {
                             min2 = matrix[j + 1, k];
                         }
                     }

                     if (min1 < min2)
                     {
                         SwapRows(matrix, j, j + 1);
                     }
                 }
             }
             Console.WriteLine("Матрица, отсортированная в порядке убывания по min элементу в строке:");

             return matrix;
         }

         */

        //public int[,] BubbleSortMatrix(int[,] matrix, OperationType opType, SortType sortType)
        //{
        //    for (int i = 0; i < matrix.GetLength(0) - 1; i++)
        //    {
        //        for (int j = 0; j < matrix.GetLength(0) - i - 1; j++)
        //        {
        //            switch (opType)
        //            {
        //                case OperationType.SortSumOfMatrixRowElements:

        //                    int sum1 = 0;

        //                    int sum2 = 0;

        //                    for (int k = 0; k < matrix.GetLength(1); k++)
        //                    {
        //                        sum1 += matrix[j, k];

        //                        sum2 += matrix[j + 1, k];
        //                    }
        //                    switch (sortType)
        //                    {
        //                        case SortType.ASC:
        //                            if (sum1 > sum2)
        //                            {
        //                                SwapRows(matrix, j, j + 1);
        //                            }
        //                            Console.WriteLine("Матрица, отсортированная по возрастанию суммы строк:");

        //                            MatrixHelper.PrintMatrix(matrix);

        //                            break;

        //                        case SortType.DESC:
        //                            if (sum1 < sum2)
        //                            {
        //                                SwapRows(matrix, j, j + 1);
        //                            }
        //                            Console.WriteLine("Матрица, отсортированная по убыванию суммы строк:");

        //                            MatrixHelper.PrintMatrix(matrix);

        //                            break;
        //                    }
        //                    break;

        //                case OperationType.SortOfMinElementInARowOfTheMatrix:

        //                    int min1 = Int32.MaxValue;

        //                    int min2 = Int32.MaxValue;

        //                    for (int k = 0; k < matrix.GetLength(1); k++)
        //                    {
        //                        if (matrix[j, k] < min1)
        //                        {
        //                            min1 = matrix[j, k];
        //                        }
        //                        if (matrix[j + 1, k] < min2)
        //                        {
        //                            min2 = matrix[j + 1, k];
        //                        }
        //                    }
        //                    switch (sortType)
        //                    {
        //                        case SortType.ASC:
        //                            if (min1 < min2)
        //                            {
        //                                SwapRows(matrix, j, j + 1);
        //                            }

        //                            Console.WriteLine("Матрица, отсортированная в порядке возрастания по min элементу в строке:");

        //                            MatrixHelper.PrintMatrix(matrix);

        //                            break;

        //                        case SortType.DESC:
        //                            if (min1 > min2)
        //                            {
        //                                SwapRows(matrix, j, j + 1);
        //                            }

        //                            Console.WriteLine("Матрица, отсортированная в порядке убывания по min элементу в строке:");

        //                            MatrixHelper.PrintMatrix(matrix);

        //                            break;
        //                    }
        //                    break;

        //                case OperationType.SortOfMaxElementInARowOfTheMatrix:

        //                    int max1 = 0;

        //                    int max2 = 0;

        //                    for (int k = 0; k < matrix.GetLength(1); k++)
        //                    {
        //                        if (matrix[j, k] > max1)
        //                        {
        //                            max1 = matrix[j, k];
        //                        }
        //                        if (matrix[j + 1, k] > max2)
        //                        {
        //                            max2 = matrix[j + 1, k];
        //                        }
        //                    }
        //                    switch (sortType)
        //                    {
        //                        case SortType.ASC:
        //                            if (max1 > max2)
        //                            {
        //                                SwapRows(matrix, j, j + 1);
        //                            }

        //                            Console.WriteLine("Матрица, отсортированная в порядке возрастания по max элементу в строке:");

        //                            MatrixHelper.PrintMatrix(matrix);

        //                            break;

        //                        case SortType.DESC:
        //                            if (max1 < max2)
        //                            {
        //                                SwapRows(matrix, j, j + 1);
        //                            }
        //                            Console.WriteLine("Матрица, отсортированная в порядке убывания по max элементу в строке:");

        //                            MatrixHelper.PrintMatrix(matrix);

        //                            break;
        //                    }
        //                    break;

        //                default:
        //                    break;
        //            }
        //            return null;

        //        }

        //    }

    }
}



