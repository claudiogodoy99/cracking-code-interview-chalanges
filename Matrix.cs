
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
      
        public static void  Rotate(int[][] matrix) {
            int total_rows = matrix.Length;
            int total_colunms = matrix[0].Length;
            int tmp = 0;


            for (int i = 0; i < total_rows; i++)
            {
                if (matrix[i].Length != total_colunms) throw new Exception("All columns should have the same  length");

                for (int j = i; j < total_colunms; j++)
                {

                    if (i != j)
                    {
                        tmp = matrix[i][j];
                        matrix[i][j] = matrix[j][i];
                        matrix[j][i] = tmp;
                    }

                }
            }

            int last_index_colunm;
            for (int i = 0; i < total_rows; i++)
            {
                for (int j = 0; j < total_colunms / 2; j++)
                {
                    last_index_colunm = total_colunms - 1 - j;

                    tmp = matrix[i][j];

                    matrix[i][j] = matrix[i][last_index_colunm];
                    matrix[i][last_index_colunm] = tmp;
                }
            }
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
