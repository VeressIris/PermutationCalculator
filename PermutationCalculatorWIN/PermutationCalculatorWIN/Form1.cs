using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
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

        int n;
        private void calculator_bttn_Click(object sender, EventArgs e)
        {
            //get data:
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
            if (newLineIndex == -1)
                return;

            int j = 0;
            for (int k = newLineIndex + 1; k < input.Length; k += 2)
            {
                perm[1, j] = input[k] - '0';
                j++;
            }
        }

        private void GenerateFirstLine(int[,] perm, int n)
        {
            for (int i = 0; i < n; i++)
                perm[0, i] = i + 1;
        }

        private string GenerateFirstLine(string input, int n)
        {
            string str = string.Empty;

            for (int i = 0; i < n; i++)
                str += i + 1 + " ";
            str += "\r\n";

            int newLineIndex = input.IndexOf('\n');
            string line2 = input.Substring(newLineIndex + 1);
            if (!string.IsNullOrEmpty(line2))
            {
                str += line2 + " ";
            }

            return str;
        }

        private void OutputPerm(int[,] result, int n)
        {
            for (int i = 0; i < n; i++)
            {
                result_txt.Text += result[1, i] + " ";
            }
        }

        //!can get rid of later!
        //private void printPerm(int[,] perm)
        //{
        //    for (int i = 0; i <  perm.GetLength(0); i++)
        //    {
        //        for (int j = 0; j < perm.GetLength(1); j++)
        //        {
        //            Debug.Write(perm[i, j] + " ");
        //        }
        //        Debug.Write("\n");
        //    }
        //}

        private void n_txtBox_TextChanged(object sender, EventArgs e)
        {
            if (n_txtBox.Text != string.Empty)
            {
                n = int.Parse(n_txtBox.Text);
                //Generate the first lines of the permutations:
                perm1_txtBox.Text = GenerateFirstLine(perm1_txtBox.Text, n);
                perm2_txtBox.Text = GenerateFirstLine(perm2_txtBox.Text,n);
                result_txt.Text = GenerateFirstLine(result_txt.Text, n);

                //Scale textboxes:
                ScaleTextBox(perm1_txtBox, n);
                ScaleTextBox(perm2_txtBox, n);
                ScaleTextBox(result_txt, n);

                //Adjust right bracket positions, depending on size of textbox
                MoveRightBracket(rightBrackets, perm1_txtBox);
                MoveRightBracket(rightBrackets2, perm2_txtBox);
                MoveRightBracket(resultRightBrackets, result_txt);
            }
        }

        private void ScaleTextBox(TextBox tb, int n)
        {
            int offset = 0;
            if (n >= 10)
            {
                n++;
                offset = 12;
            }
            else
            {
                offset = 8;
            }

            Font font = tb.Font;
            float fontSize = font.Size;
            tb.Size = new Size((int)Math.Round(fontSize * (n)) + offset, tb.Size.Height);

            SetMaxLength(tb);
        }

        private void MoveRightBracket(Label bracket, TextBox tb)
        {
            if (bracket.Name == "resultRightBrackets")
                bracket.Location = new Point(tb.Location.X + tb.Width - 12, bracket.Location.Y);
            else
             bracket.Location = new Point(tb.Location.X + tb.Width, bracket.Location.Y);
        }

        //sets the maximum length of the textbox depending on the length of the permutation
        //in order to avoid a longer input on the 2nd line
        private void SetMaxLength(TextBox tb)
        {
            int spaceCount = n * 2;
            int digitCount = n * 2;
            tb.MaxLength = spaceCount + digitCount + 1; //+1 for the new line char
        }

        private void CaluclateInverse(int[,] perm, int n, int[,] result)
        {
            for (int i = 0; i < n; i++)
            {

            }
        }
    }
}
