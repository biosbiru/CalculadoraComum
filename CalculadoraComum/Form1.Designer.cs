namespace CalculadoraComum
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtResult = new TextBox();
            btnBackSpace = new Button();
            btnClear = new Button();
            btnPow = new Button();
            btnDivision = new Button();
            btn9 = new Button();
            btn8 = new Button();
            btn7 = new Button();
            ntbPercent = new Button();
            btnMultiply = new Button();
            btn6 = new Button();
            btn5 = new Button();
            btn4 = new Button();
            btnSubtract = new Button();
            btn3 = new Button();
            btn2 = new Button();
            btn1 = new Button();
            btnEquals = new Button();
            btnPlus = new Button();
            btnComma = new Button();
            btn0 = new Button();
            SuspendLayout();
            // 
            // txtResult
            // 
            txtResult.Location = new Point(12, 12);
            txtResult.Multiline = true;
            txtResult.Name = "txtResult";
            txtResult.Size = new Size(212, 50);
            txtResult.TabIndex = 0;
            // 
            // btnBackSpace
            // 
            btnBackSpace.Font = new Font("Impact", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnBackSpace.Location = new Point(12, 68);
            btnBackSpace.Name = "btnBackSpace";
            btnBackSpace.Size = new Size(82, 36);
            btnBackSpace.TabIndex = 1;
            btnBackSpace.Text = "◄-";
            btnBackSpace.UseVisualStyleBackColor = true;
            btnBackSpace.Click += btnBackSpace_Click;
            // 
            // btnClear
            // 
            btnClear.Location = new Point(100, 68);
            btnClear.Name = "btnClear";
            btnClear.Size = new Size(124, 36);
            btnClear.TabIndex = 3;
            btnClear.Text = "C";
            btnClear.UseVisualStyleBackColor = true;
            btnClear.Click += btnClear_Click;
            // 
            // btnPow
            // 
            btnPow.Location = new Point(188, 110);
            btnPow.Name = "btnPow";
            btnPow.Size = new Size(38, 36);
            btnPow.TabIndex = 10;
            btnPow.Text = "X²";
            btnPow.UseVisualStyleBackColor = true;
            btnPow.Click += btnPow_Click;
            // 
            // btnDivision
            // 
            btnDivision.Location = new Point(144, 110);
            btnDivision.Name = "btnDivision";
            btnDivision.Size = new Size(38, 36);
            btnDivision.TabIndex = 9;
            btnDivision.Text = "/";
            btnDivision.UseVisualStyleBackColor = true;
            btnDivision.Click += btnDivision_Click;
            // 
            // btn9
            // 
            btn9.Location = new Point(100, 110);
            btn9.Name = "btn9";
            btn9.Size = new Size(38, 36);
            btn9.TabIndex = 8;
            btn9.Text = "9";
            btn9.UseVisualStyleBackColor = true;
            btn9.Click += btn9_Click;
            // 
            // btn8
            // 
            btn8.Location = new Point(56, 110);
            btn8.Name = "btn8";
            btn8.Size = new Size(38, 36);
            btn8.TabIndex = 7;
            btn8.Text = "8";
            btn8.UseVisualStyleBackColor = true;
            btn8.Click += btn8_Click;
            // 
            // btn7
            // 
            btn7.Location = new Point(12, 110);
            btn7.Name = "btn7";
            btn7.Size = new Size(38, 36);
            btn7.TabIndex = 6;
            btn7.Text = "7";
            btn7.UseVisualStyleBackColor = true;
            btn7.Click += btn7_Click;
            // 
            // ntbPercent
            // 
            ntbPercent.Location = new Point(188, 152);
            ntbPercent.Name = "ntbPercent";
            ntbPercent.Size = new Size(38, 36);
            ntbPercent.TabIndex = 15;
            ntbPercent.Text = "%";
            ntbPercent.UseVisualStyleBackColor = true;
            ntbPercent.Click += ntbPercent_Click;
            // 
            // btnMultiply
            // 
            btnMultiply.Location = new Point(144, 152);
            btnMultiply.Name = "btnMultiply";
            btnMultiply.Size = new Size(38, 36);
            btnMultiply.TabIndex = 14;
            btnMultiply.Text = "*";
            btnMultiply.UseVisualStyleBackColor = true;
            btnMultiply.Click += btnMultiply_Click;
            // 
            // btn6
            // 
            btn6.Location = new Point(100, 152);
            btn6.Name = "btn6";
            btn6.Size = new Size(38, 36);
            btn6.TabIndex = 13;
            btn6.Text = "6";
            btn6.UseVisualStyleBackColor = true;
            btn6.Click += btn6_Click;
            // 
            // btn5
            // 
            btn5.Location = new Point(56, 152);
            btn5.Name = "btn5";
            btn5.Size = new Size(38, 36);
            btn5.TabIndex = 12;
            btn5.Text = "5";
            btn5.UseVisualStyleBackColor = true;
            btn5.Click += btn5_Click;
            // 
            // btn4
            // 
            btn4.Location = new Point(12, 152);
            btn4.Name = "btn4";
            btn4.Size = new Size(38, 36);
            btn4.TabIndex = 11;
            btn4.Text = "4";
            btn4.UseVisualStyleBackColor = true;
            btn4.Click += btn4_Click;
            // 
            // btnSubtract
            // 
            btnSubtract.Location = new Point(144, 194);
            btnSubtract.Name = "btnSubtract";
            btnSubtract.Size = new Size(38, 36);
            btnSubtract.TabIndex = 19;
            btnSubtract.Text = "-";
            btnSubtract.UseVisualStyleBackColor = true;
            btnSubtract.Click += btnSubtract_Click;
            // 
            // btn3
            // 
            btn3.Location = new Point(100, 194);
            btn3.Name = "btn3";
            btn3.Size = new Size(38, 36);
            btn3.TabIndex = 18;
            btn3.Text = "3";
            btn3.UseVisualStyleBackColor = true;
            btn3.Click += btn3_Click;
            // 
            // btn2
            // 
            btn2.Location = new Point(56, 194);
            btn2.Name = "btn2";
            btn2.Size = new Size(38, 36);
            btn2.TabIndex = 17;
            btn2.Text = "2";
            btn2.UseVisualStyleBackColor = true;
            btn2.Click += btn2_Click;
            // 
            // btn1
            // 
            btn1.Location = new Point(12, 194);
            btn1.Name = "btn1";
            btn1.Size = new Size(38, 36);
            btn1.TabIndex = 16;
            btn1.Text = "1";
            btn1.UseVisualStyleBackColor = true;
            btn1.Click += btn1_Click;
            // 
            // btnEquals
            // 
            btnEquals.Location = new Point(188, 194);
            btnEquals.Name = "btnEquals";
            btnEquals.Size = new Size(38, 78);
            btnEquals.TabIndex = 25;
            btnEquals.Text = "=";
            btnEquals.UseVisualStyleBackColor = true;
            btnEquals.Click += btnEquals_Click;
            // 
            // btnPlus
            // 
            btnPlus.Location = new Point(144, 236);
            btnPlus.Name = "btnPlus";
            btnPlus.Size = new Size(38, 36);
            btnPlus.TabIndex = 24;
            btnPlus.Text = "+";
            btnPlus.UseVisualStyleBackColor = true;
            btnPlus.Click += btnPlus_Click;
            // 
            // btnComma
            // 
            btnComma.Location = new Point(100, 236);
            btnComma.Name = "btnComma";
            btnComma.Size = new Size(38, 36);
            btnComma.TabIndex = 23;
            btnComma.Text = ",";
            btnComma.UseVisualStyleBackColor = true;
            btnComma.Click += btnComma_Click;
            // 
            // btn0
            // 
            btn0.Location = new Point(12, 236);
            btn0.Name = "btn0";
            btn0.Size = new Size(82, 36);
            btn0.TabIndex = 21;
            btn0.Text = "0";
            btn0.UseVisualStyleBackColor = true;
            btn0.Click += btn0_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoSizeMode = AutoSizeMode.GrowAndShrink;
            ClientSize = new Size(236, 281);
            Controls.Add(btnEquals);
            Controls.Add(btnPlus);
            Controls.Add(btnComma);
            Controls.Add(btn0);
            Controls.Add(btnSubtract);
            Controls.Add(btn3);
            Controls.Add(btn2);
            Controls.Add(btn1);
            Controls.Add(ntbPercent);
            Controls.Add(btnMultiply);
            Controls.Add(btn6);
            Controls.Add(btn5);
            Controls.Add(btn4);
            Controls.Add(btnPow);
            Controls.Add(btnDivision);
            Controls.Add(btn9);
            Controls.Add(btn8);
            Controls.Add(btn7);
            Controls.Add(btnClear);
            Controls.Add(btnBackSpace);
            Controls.Add(txtResult);
            Name = "Form1";
            Text = "Calculator";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtResult;
        private Button btnBackSpace;
        private Button btnClear;
        private Button btnPow;
        private Button btnDivision;
        private Button btn9;
        private Button btn8;
        private Button btn7;
        private Button ntbPercent;
        private Button btnMultiply;
        private Button btn6;
        private Button btn5;
        private Button btn4;
        private Button btnSubtract;
        private Button btn3;
        private Button btn2;
        private Button btn1;
        private Button btnEquals;
        private Button btnPlus;
        private Button btnComma;
        private Button btn0;
    }
}
