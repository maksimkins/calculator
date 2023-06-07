namespace Calculator
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
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
            button5 = new Button();
            button6 = new Button();
            button7 = new Button();
            button8 = new Button();
            button9 = new Button();
            button0 = new Button();
            buttonDot = new Button();
            buttonDelete = new Button();
            buttonPlus = new Button();
            buttonMinus = new Button();
            buttonMultiplication = new Button();
            buttonDivision = new Button();
            buttonEqual = new Button();
            labelInputandRes = new Label();
            labelHistory = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button1.Location = new Point(28, 243);
            button1.Name = "button1";
            button1.Size = new Size(50, 46);
            button1.TabIndex = 0;
            button1.Text = "1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += ButtonClickedNumber;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button2.Location = new Point(84, 243);
            button2.Name = "button2";
            button2.Size = new Size(50, 46);
            button2.TabIndex = 1;
            button2.Text = "2";
            button2.UseVisualStyleBackColor = true;
            button2.Click += ButtonClickedNumber;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button3.Location = new Point(140, 243);
            button3.Name = "button3";
            button3.Size = new Size(50, 46);
            button3.TabIndex = 2;
            button3.Text = "3";
            button3.UseVisualStyleBackColor = true;
            button3.Click += ButtonClickedNumber;
            // 
            // button4
            // 
            button4.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button4.Location = new Point(28, 191);
            button4.Name = "button4";
            button4.Size = new Size(50, 46);
            button4.TabIndex = 3;
            button4.Text = "4";
            button4.UseVisualStyleBackColor = true;
            button4.Click += ButtonClickedNumber;
            // 
            // button5
            // 
            button5.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button5.Location = new Point(84, 191);
            button5.Name = "button5";
            button5.Size = new Size(50, 46);
            button5.TabIndex = 4;
            button5.Text = "5";
            button5.UseVisualStyleBackColor = true;
            button5.Click += ButtonClickedNumber;
            // 
            // button6
            // 
            button6.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button6.Location = new Point(140, 191);
            button6.Name = "button6";
            button6.Size = new Size(50, 46);
            button6.TabIndex = 5;
            button6.Text = "6";
            button6.UseVisualStyleBackColor = true;
            button6.Click += ButtonClickedNumber;
            // 
            // button7
            // 
            button7.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button7.Location = new Point(28, 139);
            button7.Name = "button7";
            button7.Size = new Size(50, 46);
            button7.TabIndex = 6;
            button7.Text = "7";
            button7.UseVisualStyleBackColor = true;
            button7.Click += ButtonClickedNumber;
            // 
            // button8
            // 
            button8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button8.Location = new Point(84, 139);
            button8.Name = "button8";
            button8.Size = new Size(50, 46);
            button8.TabIndex = 7;
            button8.Text = "8";
            button8.UseVisualStyleBackColor = true;
            button8.Click += ButtonClickedNumber;
            // 
            // button9
            // 
            button9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button9.Location = new Point(140, 139);
            button9.Name = "button9";
            button9.Size = new Size(50, 46);
            button9.TabIndex = 8;
            button9.Text = "9";
            button9.UseVisualStyleBackColor = true;
            button9.Click += ButtonClickedNumber;
            // 
            // button0
            // 
            button0.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            button0.Location = new Point(28, 295);
            button0.Name = "button0";
            button0.Size = new Size(50, 46);
            button0.TabIndex = 9;
            button0.Text = "0";
            button0.UseVisualStyleBackColor = true;
            button0.Click += ButtonClickedNumber;
            // 
            // buttonDot
            // 
            buttonDot.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDot.Location = new Point(84, 295);
            buttonDot.Name = "buttonDot";
            buttonDot.Size = new Size(50, 46);
            buttonDot.TabIndex = 10;
            buttonDot.Text = ".";
            buttonDot.UseVisualStyleBackColor = true;
            buttonDot.Click += ButtonClickedDot;
            // 
            // buttonDelete
            // 
            buttonDelete.BackColor = Color.LightCoral;
            buttonDelete.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDelete.ForeColor = SystemColors.ControlText;
            buttonDelete.Location = new Point(140, 295);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(50, 46);
            buttonDelete.TabIndex = 11;
            buttonDelete.Text = "C";
            buttonDelete.UseVisualStyleBackColor = false;
            buttonDelete.Click += ButtonClickedDeleteButton;
            // 
            // buttonPlus
            // 
            buttonPlus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonPlus.Location = new Point(196, 139);
            buttonPlus.Name = "buttonPlus";
            buttonPlus.Size = new Size(50, 46);
            buttonPlus.TabIndex = 12;
            buttonPlus.Text = "+";
            buttonPlus.UseVisualStyleBackColor = true;
            buttonPlus.Click += ButtonClickedOperations;
            // 
            // buttonMinus
            // 
            buttonMinus.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMinus.Location = new Point(196, 191);
            buttonMinus.Name = "buttonMinus";
            buttonMinus.Size = new Size(50, 46);
            buttonMinus.TabIndex = 13;
            buttonMinus.Text = "-";
            buttonMinus.UseVisualStyleBackColor = true;
            buttonMinus.Click += ButtonClickedOperations;
            // 
            // buttonMultiplication
            // 
            buttonMultiplication.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonMultiplication.Location = new Point(196, 243);
            buttonMultiplication.Name = "buttonMultiplication";
            buttonMultiplication.Size = new Size(50, 46);
            buttonMultiplication.TabIndex = 14;
            buttonMultiplication.Text = "*";
            buttonMultiplication.UseVisualStyleBackColor = true;
            buttonMultiplication.Click += ButtonClickedOperations;
            // 
            // buttonDivision
            // 
            buttonDivision.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonDivision.Location = new Point(196, 295);
            buttonDivision.Name = "buttonDivision";
            buttonDivision.Size = new Size(50, 46);
            buttonDivision.TabIndex = 15;
            buttonDivision.Text = "/";
            buttonDivision.UseVisualStyleBackColor = true;
            buttonDivision.Click += ButtonClickedOperations;
            // 
            // buttonEqual
            // 
            buttonEqual.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            buttonEqual.Location = new Point(140, 87);
            buttonEqual.Name = "buttonEqual";
            buttonEqual.Size = new Size(106, 46);
            buttonEqual.TabIndex = 16;
            buttonEqual.Text = "=";
            buttonEqual.UseVisualStyleBackColor = true;
            buttonEqual.Click += ButtonClickedOperations;
            // 
            // labelInputandRes
            // 
            labelInputandRes.AutoSize = true;
            labelInputandRes.BackColor = SystemColors.ButtonShadow;
            labelInputandRes.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelInputandRes.ForeColor = SystemColors.ControlText;
            labelInputandRes.Location = new Point(26, 24);
            labelInputandRes.MinimumSize = new Size(220, 46);
            labelInputandRes.Name = "labelInputandRes";
            labelInputandRes.Size = new Size(220, 46);
            labelInputandRes.TabIndex = 17;
            // 
            // labelHistory
            // 
            labelHistory.AutoSize = true;
            labelHistory.BackColor = SystemColors.ButtonShadow;
            labelHistory.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelHistory.Location = new Point(378, 24);
            labelHistory.MinimumSize = new Size(300, 310);
            labelHistory.Name = "labelHistory";
            labelHistory.Size = new Size(300, 310);
            labelHistory.TabIndex = 18;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(699, 362);
            Controls.Add(labelHistory);
            Controls.Add(labelInputandRes);
            Controls.Add(buttonEqual);
            Controls.Add(buttonDivision);
            Controls.Add(buttonMultiplication);
            Controls.Add(buttonMinus);
            Controls.Add(buttonPlus);
            Controls.Add(buttonDelete);
            Controls.Add(buttonDot);
            Controls.Add(button0);
            Controls.Add(button9);
            Controls.Add(button8);
            Controls.Add(button7);
            Controls.Add(button6);
            Controls.Add(button5);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Button button5;
        private Button button6;
        private Button button7;
        private Button button8;
        private Button button9;
        private Button button0;
        private Button buttonDot;
        private Button buttonDelete;
        private Button buttonPlus;
        private Button buttonMinus;
        private Button buttonMultiplication;
        private Button buttonDivision;
        private Button buttonEqual;
        private Label labelInputandRes;
        private Label labelHistory;
    }
}