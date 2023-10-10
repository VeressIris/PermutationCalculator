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
            this.calculator_bttn = new System.Windows.Forms.Button();
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
            this.result_lbl = new System.Windows.Forms.Label();
            this.rightBrackets = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // calculator_bttn
            // 
            this.calculator_bttn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.calculator_bttn.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.calculator_bttn.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculator_bttn.Location = new System.Drawing.Point(501, 229);
            this.calculator_bttn.Name = "calculator_bttn";
            this.calculator_bttn.Size = new System.Drawing.Size(118, 49);
            this.calculator_bttn.TabIndex = 1;
            this.calculator_bttn.Text = "calculate";
            this.calculator_bttn.UseVisualStyleBackColor = false;
            this.calculator_bttn.Click += new System.EventHandler(this.calculator_bttn_Click);
            // 
            // perm1_txtBox
            // 
            this.perm1_txtBox.AcceptsReturn = true;
            this.perm1_txtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.perm1_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.perm1_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perm1_txtBox.Location = new System.Drawing.Point(95, 71);
            this.perm1_txtBox.Multiline = true;
            this.perm1_txtBox.Name = "perm1_txtBox";
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
            this.label1.Location = new System.Drawing.Point(12, 73);
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
            this.label2.Location = new System.Drawing.Point(417, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 39);
            this.label2.TabIndex = 3;
            this.label2.Text = "β =";
            // 
            // perm2_txtBox
            // 
            this.perm2_txtBox.AcceptsReturn = true;
            this.perm2_txtBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.perm2_txtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.perm2_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perm2_txtBox.Location = new System.Drawing.Point(501, 73);
            this.perm2_txtBox.Multiline = true;
            this.perm2_txtBox.Name = "perm2_txtBox";
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
            this.leftBrackets.Location = new System.Drawing.Point(60, 53);
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
            this.leftBrackets2.Location = new System.Drawing.Point(465, 53);
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
            this.rightBrackets2.Location = new System.Drawing.Point(611, 55);
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
            this.resultLetter_lbl.Location = new System.Drawing.Point(14, 219);
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
            this.label4.Location = new System.Drawing.Point(60, 201);
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
            this.resultRightBrackets.Location = new System.Drawing.Point(196, 201);
            this.resultRightBrackets.Name = "resultRightBrackets";
            this.resultRightBrackets.Size = new System.Drawing.Size(36, 110);
            this.resultRightBrackets.TabIndex = 4;
            this.resultRightBrackets.Text = "⎤\r\n⎦\r\n";
            // 
            // n_txtBox
            // 
            this.n_txtBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.n_txtBox.Location = new System.Drawing.Point(300, 12);
            this.n_txtBox.Name = "n_txtBox";
            this.n_txtBox.Size = new System.Drawing.Size(100, 44);
            this.n_txtBox.TabIndex = 5;
            this.n_txtBox.TextChanged += new System.EventHandler(this.n_txtBox_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(220, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 39);
            this.label3.TabIndex = 6;
            this.label3.Text = "n = ";
            // 
            // result_lbl
            // 
            this.result_lbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.result_lbl.AutoSize = true;
            this.result_lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result_lbl.Location = new System.Drawing.Point(85, 219);
            this.result_lbl.Name = "result_lbl";
            this.result_lbl.Size = new System.Drawing.Size(0, 31);
            this.result_lbl.TabIndex = 7;
            // 
            // rightBrackets
            // 
            this.rightBrackets.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.rightBrackets.AutoSize = true;
            this.rightBrackets.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rightBrackets.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rightBrackets.Location = new System.Drawing.Point(213, 55);
            this.rightBrackets.Name = "rightBrackets";
            this.rightBrackets.Size = new System.Drawing.Size(36, 110);
            this.rightBrackets.TabIndex = 4;
            this.rightBrackets.Text = "⎤\r\n⎦\r\n";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.result_lbl);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.n_txtBox);
            this.Controls.Add(this.rightBrackets);
            this.Controls.Add(this.resultRightBrackets);
            this.Controls.Add(this.rightBrackets2);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.leftBrackets2);
            this.Controls.Add(this.leftBrackets);
            this.Controls.Add(this.resultLetter_lbl);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.perm2_txtBox);
            this.Controls.Add(this.perm1_txtBox);
            this.Controls.Add(this.calculator_bttn);
            this.Name = "Form1";
            this.Text = "Permutation Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button calculator_bttn;
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
        private System.Windows.Forms.Label result_lbl;
        private System.Windows.Forms.Label rightBrackets;
    }
}

