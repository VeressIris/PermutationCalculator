using System.Windows.Forms;

namespace PermutationCalculatorWIN
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.multiply_bttn = new System.Windows.Forms.Button();
            this.perm1_txtBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.perm2_txtBox = new System.Windows.Forms.TextBox();
            this.leftBrackets = new System.Windows.Forms.Label();
            this.leftBrackets2 = new System.Windows.Forms.Label();
            this.rightBrackets2 = new System.Windows.Forms.Label();
            this.resultLetter_lbl = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.resultRightBrackets = new System.Windows.Forms.Label();
            this.n_txtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rightBrackets = new System.Windows.Forms.Label();
            this.result_txt = new System.Windows.Forms.TextBox();
            this.inverse_bttn = new System.Windows.Forms.Button();
            this.inverseResult_lbl = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.inverseResultRightBracket = new System.Windows.Forms.Label();
            this.inverseResult_txtBox = new System.Windows.Forms.TextBox();
            this.inverse_txtBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.inverseRightBracket = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // multiply_bttn
            // 
            this.multiply_bttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.multiply_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(69)))), ((int)(((byte)(39)))), ((int)(((byte)(160)))));
            this.multiply_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.multiply_bttn.ForeColor = System.Drawing.SystemColors.Window;
            this.multiply_bttn.Location = new System.Drawing.Point(529, 272);
            this.multiply_bttn.Name = "multiply_bttn";
            this.multiply_bttn.Size = new System.Drawing.Size(118, 49);
            this.multiply_bttn.TabIndex = 1;
            this.multiply_bttn.Text = "Multiply";
            this.multiply_bttn.UseVisualStyleBackColor = false;
            this.multiply_bttn.Click += new System.EventHandler(this.calculator_bttn_Click);
            // 
            // perm1_txtBox
            // 
            this.perm1_txtBox.AcceptsReturn = true;
            this.perm1_txtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.perm1_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.perm1_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.perm1_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perm1_txtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.perm1_txtBox.Location = new System.Drawing.Point(111, 112);
            this.perm1_txtBox.MaximumSize = new System.Drawing.Size(417, 85);
            this.perm1_txtBox.Multiline = true;
            this.perm1_txtBox.Name = "perm1_txtBox";
            this.perm1_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.perm1_txtBox.Size = new System.Drawing.Size(112, 85);
            this.perm1_txtBox.TabIndex = 2;
            this.perm1_txtBox.Text = "1 2 3 4 5\r\n3 4 1 2 5";
            this.perm1_txtBox.WordWrap = false;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(28, 114);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 39);
            this.label1.TabIndex = 3;
            this.label1.Text = "α =";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(705, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "β =";
            // 
            // perm2_txtBox
            // 
            this.perm2_txtBox.AcceptsReturn = true;
            this.perm2_txtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.perm2_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.perm2_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.perm2_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perm2_txtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.perm2_txtBox.Location = new System.Drawing.Point(789, 112);
            this.perm2_txtBox.MaximumSize = new System.Drawing.Size(417, 85);
            this.perm2_txtBox.Multiline = true;
            this.perm2_txtBox.Name = "perm2_txtBox";
            this.perm2_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.perm2_txtBox.Size = new System.Drawing.Size(118, 85);
            this.perm2_txtBox.TabIndex = 2;
            this.perm2_txtBox.Text = "1 2 3 4 5\r\n2 5 4 3 1";
            this.perm2_txtBox.WordWrap = false;
            // 
            // leftBrackets
            // 
            this.leftBrackets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftBrackets.AutoSize = true;
            this.leftBrackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBrackets.ForeColor = System.Drawing.SystemColors.Window;
            this.leftBrackets.Location = new System.Drawing.Point(76, 94);
            this.leftBrackets.Name = "leftBrackets";
            this.leftBrackets.Size = new System.Drawing.Size(36, 110);
            this.leftBrackets.TabIndex = 4;
            this.leftBrackets.Text = "⎡\r\n⎣";
            // 
            // leftBrackets2
            // 
            this.leftBrackets2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.leftBrackets2.AutoSize = true;
            this.leftBrackets2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leftBrackets2.ForeColor = System.Drawing.SystemColors.Window;
            this.leftBrackets2.Location = new System.Drawing.Point(753, 92);
            this.leftBrackets2.Name = "leftBrackets2";
            this.leftBrackets2.Size = new System.Drawing.Size(36, 110);
            this.leftBrackets2.TabIndex = 4;
            this.leftBrackets2.Text = "⎡\r\n⎣";
            // 
            // rightBrackets2
            // 
            this.rightBrackets2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightBrackets2.AutoSize = true;
            this.rightBrackets2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBrackets2.ForeColor = System.Drawing.SystemColors.Window;
            this.rightBrackets2.Location = new System.Drawing.Point(899, 94);
            this.rightBrackets2.Name = "rightBrackets2";
            this.rightBrackets2.Size = new System.Drawing.Size(36, 110);
            this.rightBrackets2.TabIndex = 4;
            this.rightBrackets2.Text = "⎤\r\n⎦\r\n";
            // 
            // resultLetter_lbl
            // 
            this.resultLetter_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultLetter_lbl.AutoSize = true;
            this.resultLetter_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultLetter_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.resultLetter_lbl.Location = new System.Drawing.Point(28, 243);
            this.resultLetter_lbl.Name = "resultLetter_lbl";
            this.resultLetter_lbl.Size = new System.Drawing.Size(66, 39);
            this.resultLetter_lbl.TabIndex = 3;
            this.resultLetter_lbl.Text = "σ =";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(76, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(36, 110);
            this.label4.TabIndex = 4;
            this.label4.Text = "⎡\r\n⎣";
            // 
            // resultRightBrackets
            // 
            this.resultRightBrackets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.resultRightBrackets.AutoSize = true;
            this.resultRightBrackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultRightBrackets.ForeColor = System.Drawing.SystemColors.Window;
            this.resultRightBrackets.Location = new System.Drawing.Point(212, 231);
            this.resultRightBrackets.Name = "resultRightBrackets";
            this.resultRightBrackets.Size = new System.Drawing.Size(36, 110);
            this.resultRightBrackets.TabIndex = 4;
            this.resultRightBrackets.Text = "⎤\r\n⎦\r\n";
            // 
            // n_txtBox
            // 
            this.n_txtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.n_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.n_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_txtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.n_txtBox.Location = new System.Drawing.Point(575, 33);
            this.n_txtBox.Name = "n_txtBox";
            this.n_txtBox.Size = new System.Drawing.Size(100, 44);
            this.n_txtBox.TabIndex = 5;
            this.n_txtBox.TextChanged += new System.EventHandler(this.n_txtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(420, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "length = ";
            // 
            // rightBrackets
            // 
            this.rightBrackets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightBrackets.AutoSize = true;
            this.rightBrackets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rightBrackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBrackets.ForeColor = System.Drawing.SystemColors.Window;
            this.rightBrackets.Location = new System.Drawing.Point(229, 96);
            this.rightBrackets.Name = "rightBrackets";
            this.rightBrackets.Size = new System.Drawing.Size(36, 110);
            this.rightBrackets.TabIndex = 4;
            this.rightBrackets.Text = "⎤\r\n⎦\r\n";
            // 
            // result_txt
            // 
            this.result_txt.AcceptsReturn = true;
            this.result_txt.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_txt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.result_txt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.result_txt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_txt.ForeColor = System.Drawing.SystemColors.Window;
            this.result_txt.Location = new System.Drawing.Point(101, 249);
            this.result_txt.Multiline = true;
            this.result_txt.Name = "result_txt";
            this.result_txt.ReadOnly = true;
            this.result_txt.Size = new System.Drawing.Size(122, 92);
            this.result_txt.TabIndex = 7;
            this.result_txt.WordWrap = false;
            // 
            // inverse_bttn
            // 
            this.inverse_bttn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(54)))), ((int)(((byte)(12)))));
            this.inverse_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverse_bttn.ForeColor = System.Drawing.SystemColors.Window;
            this.inverse_bttn.Location = new System.Drawing.Point(529, 459);
            this.inverse_bttn.Name = "inverse_bttn";
            this.inverse_bttn.Size = new System.Drawing.Size(118, 49);
            this.inverse_bttn.TabIndex = 8;
            this.inverse_bttn.Text = "Inverse";
            this.inverse_bttn.UseVisualStyleBackColor = false;
            this.inverse_bttn.Click += new System.EventHandler(this.inverse_bttn_Click);
            // 
            // inverseResult_lbl
            // 
            this.inverseResult_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inverseResult_lbl.AutoSize = true;
            this.inverseResult_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverseResult_lbl.ForeColor = System.Drawing.SystemColors.Window;
            this.inverseResult_lbl.Location = new System.Drawing.Point(28, 517);
            this.inverseResult_lbl.Name = "inverseResult_lbl";
            this.inverseResult_lbl.Size = new System.Drawing.Size(54, 39);
            this.inverseResult_lbl.TabIndex = 3;
            this.inverseResult_lbl.Text = "ι =";
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(76, 505);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 110);
            this.label6.TabIndex = 4;
            this.label6.Text = "⎡\r\n⎣";
            // 
            // inverseResultRightBracket
            // 
            this.inverseResultRightBracket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inverseResultRightBracket.AutoSize = true;
            this.inverseResultRightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverseResultRightBracket.ForeColor = System.Drawing.SystemColors.Window;
            this.inverseResultRightBracket.Location = new System.Drawing.Point(212, 505);
            this.inverseResultRightBracket.Name = "inverseResultRightBracket";
            this.inverseResultRightBracket.Size = new System.Drawing.Size(36, 110);
            this.inverseResultRightBracket.TabIndex = 4;
            this.inverseResultRightBracket.Text = "⎤\r\n⎦\r\n";
            // 
            // inverseResult_txtBox
            // 
            this.inverseResult_txtBox.AcceptsReturn = true;
            this.inverseResult_txtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inverseResult_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.inverseResult_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inverseResult_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverseResult_txtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.inverseResult_txtBox.Location = new System.Drawing.Point(101, 523);
            this.inverseResult_txtBox.Multiline = true;
            this.inverseResult_txtBox.Name = "inverseResult_txtBox";
            this.inverseResult_txtBox.ReadOnly = true;
            this.inverseResult_txtBox.Size = new System.Drawing.Size(122, 92);
            this.inverseResult_txtBox.TabIndex = 7;
            this.inverseResult_txtBox.WordWrap = false;
            // 
            // inverse_txtBox
            // 
            this.inverse_txtBox.AcceptsReturn = true;
            this.inverse_txtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inverse_txtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.inverse_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.inverse_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverse_txtBox.ForeColor = System.Drawing.SystemColors.Window;
            this.inverse_txtBox.Location = new System.Drawing.Point(111, 399);
            this.inverse_txtBox.MaximumSize = new System.Drawing.Size(417, 85);
            this.inverse_txtBox.Multiline = true;
            this.inverse_txtBox.Name = "inverse_txtBox";
            this.inverse_txtBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.inverse_txtBox.Size = new System.Drawing.Size(112, 85);
            this.inverse_txtBox.TabIndex = 2;
            this.inverse_txtBox.Text = "1 2 3 4 5\r\n3 4 1 2 5";
            this.inverse_txtBox.WordWrap = false;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(28, 401);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 39);
            this.label5.TabIndex = 3;
            this.label5.Text = "ζ =";
            // 
            // label8
            // 
            this.label8.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(76, 381);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(36, 110);
            this.label8.TabIndex = 4;
            this.label8.Text = "⎡\r\n⎣";
            // 
            // inverseRightBracket
            // 
            this.inverseRightBracket.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.inverseRightBracket.AutoSize = true;
            this.inverseRightBracket.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.inverseRightBracket.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.inverseRightBracket.ForeColor = System.Drawing.SystemColors.Window;
            this.inverseRightBracket.Location = new System.Drawing.Point(229, 383);
            this.inverseRightBracket.Name = "inverseRightBracket";
            this.inverseRightBracket.Size = new System.Drawing.Size(36, 110);
            this.inverseRightBracket.TabIndex = 4;
            this.inverseRightBracket.Text = "⎤\r\n⎦\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(1280, 720);
            this.Controls.Add(this.inverse_bttn);
            this.Controls.Add(this.inverseResult_txtBox);
            this.Controls.Add(this.result_txt);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_txtBox);
            this.Controls.Add(this.inverseResultRightBracket);
            this.Controls.Add(this.inverseRightBracket);
            this.Controls.Add(this.rightBrackets);
            this.Controls.Add(this.resultRightBrackets);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.rightBrackets2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftBrackets2);
            this.Controls.Add(this.inverseResult_lbl);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.leftBrackets);
            this.Controls.Add(this.resultLetter_lbl);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.inverse_txtBox);
            this.Controls.Add(this.perm2_txtBox);
            this.Controls.Add(this.perm1_txtBox);
            this.Controls.Add(this.multiply_bttn);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Permutation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button multiply_bttn;
        private System.Windows.Forms.TextBox perm1_txtBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox perm2_txtBox;
        private System.Windows.Forms.Label leftBrackets;
        private System.Windows.Forms.Label leftBrackets2;
        private System.Windows.Forms.Label rightBrackets2;
        private System.Windows.Forms.Label resultLetter_lbl;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label resultRightBrackets;
        private System.Windows.Forms.TextBox n_txtBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label rightBrackets;
        private TextBox result_txt;
        private Button inverse_bttn;
        private Label inverseResult_lbl;
        private Label label6;
        private Label inverseResultRightBracket;
        private TextBox inverseResult_txtBox;
        private TextBox inverse_txtBox;
        private Label label5;
        private Label label8;
        private Label inverseRightBracket;
    }
}

