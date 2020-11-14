using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

namespace PureQuantamWinFormsApp
{
    /// <summary>
    /// Represents a matrix of a user defined type and user defined dimensions
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class Matrix<T>
    {        
        public Matrix(int rows, int columns, MutuallyExclusive exclusivity = MutuallyExclusive.None)
        {
            Rows = rows;
            Columns = columns;
            _exclusivity = exclusivity;
            listRows = new List<T[]>();          
        }

        readonly MutuallyExclusive _exclusivity;
        readonly List<T[]> listRows;

        public int Rows { get; } = 0;

        public int Columns { get; } = 0;


        public void AddRow(T[] row)
        {
            if (listRows.Count() >= Rows)
                IncorrectRowLength();

            if (row.Length != Columns)
                IncorrectColumnLength();

            listRows.Add(row);
        }

        public void AddRow(List<T> row)
        {
            if (listRows.Count() >= Rows)
                IncorrectRowLength();

            if (row.Count() != Columns)
                IncorrectColumnLength();

            listRows.Add(row.ToArray());
        }


        void IncorrectRowLength()
        {
            throw new InvalidOperationException("Maximmum rows already added to the matrix");
        }

        void IncorrectColumnLength()
        {
            throw new InvalidOperationException("Incorrect array length passed in for the matrix");
        }

        public enum MutuallyExclusive
        {
            None,
            Rows,
            Columns,
        }

        /// <summary>
        /// Creates the rows of the matrix
        /// </summary>
        /// <param name="getValue">function used to aquire the data for each row element</param>
        public void CreateRows(Func<T> getValue)
        {
            for (int row = 0; row < Rows; row++)
            {
                List<T> tmpListRow = new List<T>();

                for (int column = 0; column < Columns; column++)
                {
                    while (true)
                    {
                        var nextVal = getValue();

                        if (_exclusivity == MutuallyExclusive.Rows)
                        {

                            if (!tmpListRow.Contains(nextVal))
                            {
                                tmpListRow.Add(nextVal);
                                break;
                            }
                        }
                        else
                        {
                            tmpListRow.Add(nextVal);
                        }
                    }
                }

                AddRow(tmpListRow);
            }
        }

        /// <summary>
        /// Generates the matrix
        /// </summary>
        /// <param name="arrays"></param>
        /// <returns></returns>
        public static T[,] GenerateMatrix(IList<T[]> arrays)
        {            
            int minorLength = arrays[0].Length;
            T[,] ret = new T[arrays.Count, minorLength];
            for (int i = 0; i < arrays.Count; i++)
            {
                var array = arrays[i];
                if (array.Length != minorLength)
                {
                    throw new ArgumentException
                        ("All arrays must be the same length");
                }
                for (int j = 0; j < minorLength; j++)
                {
                    ret[i, j] = array[j];
                }
            }

            return ret;
        }

        /// <summary>
        /// Generates the matrix
        /// </summary>
        /// <returns></returns>
        public T[,] GenerateMatrix()
        {
            return (GenerateMatrix(listRows));
        }

        public static void PrintMatrix(int[,] array)
        {
            foreach (int x in array)
            {
                Trace.WriteLine(x);         
            }

            Trace.WriteLine(array[1, 2]);            
        }

        public T[] GetColumn(T[,] matrix, int columnNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(0))
                    .Select(x => matrix[x, columnNumber])
                    .ToArray();
        }

        public T[] GetRow(T[,] matrix, int rowNumber)
        {
            return Enumerable.Range(0, matrix.GetLength(1))
                    .Select(x => matrix[rowNumber, x])
                    .ToArray();
        }

    }
}
