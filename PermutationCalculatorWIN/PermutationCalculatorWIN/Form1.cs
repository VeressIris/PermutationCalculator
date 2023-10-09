using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PermutationCalculatorWIN
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calculator_bttn_Click(object sender, EventArgs e)
        {
            //get data:
            int n = int.Parse(n_txtBox.Text);
            int[,] a = new int[2, n];
            int[,] b = new int[2, n];
            int[,] result = new int[2, n];
            GetPermutation(a, perm1_txtBox.Text, n);
            GetPermutation(b, perm2_txtBox.Text, n);
            
            Multiply(a, b, n, result);
            OutputPerm(result, n);
        }

        private void Multiply(int[,] a, int[,] b, int n, int[,] result)
        {
            GenerateFirstLine(result, n);

            for (int index = 0; index < n; index++)
            {
                //i had no clue how else to name these variables. very unfortunate naming...
                int step1 = b[1, index];
                int step2 = a[1, step1 - 1];
                result[1, index] = step2;
            }
        }

        private void GetPermutation(int[,] perm, string input, int n)
        {
            GenerateFirstLine(perm, n);
            
            int newLineIndex = input.IndexOf('\n');
            if (newLineIndex != -1)
            {
                int j = 0;
                for (int k = newLineIndex + 1; k < input.Length; k+=2)
                {
                    perm[1, j] = input[k] - '0';
                    j++;
                }
            }
        }

        private void GenerateFirstLine(int[,] perm, int n)
        {
            for (int i = 0; i < n; i++)
                perm[0, i] = i + 1;
        }

        private string GenerateFirstLine(int n)
        {
            string str = string.Empty;
            for (int i = 0; i < n; i++)
                str += i + 1 + " ";
            str += "\n";

            return str;
        }

        private void OutputPerm(int[,] result, int n)
        {
            result_lbl.Text = GenerateFirstLine(n);
            for (int i = 0; i < n; i++)
            {
                result_lbl.Text += result[1, i] + " ";
            }
        }

        //!can get rid of later!
        private void printPerm(int[,] perm)
        {
            for (int i = 0; i <  perm.GetLength(0); i++)
            {
                for (int j = 0; j < perm.GetLength(1); j++)
                {
                    Debug.Write(perm[i, j] + " ");
                }
                Debug.Write("\n");
            }
        }
    }
}
