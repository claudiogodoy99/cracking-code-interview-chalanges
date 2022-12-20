
using Microsoft.Diagnostics.Tracing.Parsers.ApplicationServer;
using Microsoft.Diagnostics.Tracing.Parsers.MicrosoftWindowsWPF;
using System.Collections;
using System.Collections.Generic;

namespace data_structures
{
    struct Found
    {
        public int row, colum, qntdColum;
    }

    public class Matrix
    {

        public static int[][] Rotate(int[][] matrix) {

            int rows = matrix.Length;
            int cols = matrix[0].Length;

            int tmp = 0;

            for (int i = 0; i < rows; i++)
            {
                for (int j = i; j < cols; j++)
                {
                    if (i != j) { 
                        tmp = matrix[i][j];

                        matrix[i][j] = matrix[j][i];
                        matrix[j][i] = tmp;
                    }
                }
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols/2; j++)
                {
                    tmp = matrix[i][j];

                    matrix[i][j] = matrix[i][cols - 1 - j];
                    matrix[i][cols - 1 - j] = tmp;
                }
            }

            return matrix;
        }

        public static int[][] Transform(int[][] matrix) {

            bool[] rows = new bool[matrix.Length];
            bool[] columns= new bool[matrix[0].Length];

            for (int i = 0; i < matrix.Length; i++)
            {
                for (int c = 0; c < matrix[0].Length; c++) {
                    if (matrix[i][c] == 0) {
                        rows[i] = true;
                        columns[c] = true;
                    }
                }
            }

            for (int i = 0; i < rows.Length; i++)
            {
                if (rows[i] == true) {
                    for (int c = 0; c < matrix[0].Length; c++)
                    {
                        matrix[i][c] = 0;
                    }
                }
            }

            for (int c = 0; c < columns.Length; c++)
            {
                if (columns[c] == true)
                {
                    for (int i = 0; i < matrix.Length; i++)
                    {
                        matrix[i][c] = 0;
                    }
                }
            }

            return matrix;
        }
    }
}
