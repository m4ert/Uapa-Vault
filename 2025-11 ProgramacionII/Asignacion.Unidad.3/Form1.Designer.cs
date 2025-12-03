namespace Asignacion.Unidad._3
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new System.Windows.Forms.Label();
            firstNumber = new System.Windows.Forms.TextBox();
            secondNumber = new System.Windows.Forms.TextBox();
            button1 = new System.Windows.Forms.Button();
            button2 = new System.Windows.Forms.Button();
            button3 = new System.Windows.Forms.Button();
            button4 = new System.Windows.Forms.Button();
            resultLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Cursor = System.Windows.Forms.Cursors.Default;
            label1.Location = new System.Drawing.Point(31, 75);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(102, 23);
            label1.TabIndex = 1;
            label1.Text = "Segundo Numero";
            label1.Click += label1_Click_1;
            // 
            // firstNumber
            // 
            firstNumber.Location = new System.Drawing.Point(148, 31);
            firstNumber.Name = "firstNumber";
            firstNumber.Size = new System.Drawing.Size(150, 23);
            firstNumber.TabIndex = 2;
            // 
            // secondNumber
            // 
            secondNumber.Location = new System.Drawing.Point(148, 75);
            secondNumber.Name = "secondNumber";
            secondNumber.Size = new System.Drawing.Size(150, 23);
            secondNumber.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new System.Drawing.Point(36, 144);
            button1.Name = "button1";
            button1.Size = new System.Drawing.Size(80, 40);
            button1.TabIndex = 4;
            button1.Text = "+";
            button1.UseVisualStyleBackColor = true;
            button1.Click += OnAppend;
            // 
            // button2
            // 
            button2.Location = new System.Drawing.Point(122, 144);
            button2.Name = "button2";
            button2.Size = new System.Drawing.Size(80, 40);
            button2.TabIndex = 5;
            button2.Text = "-";
            button2.UseVisualStyleBackColor = true;
            button2.Click += OnSubtract;
            // 
            // button3
            // 
            button3.Location = new System.Drawing.Point(208, 144);
            button3.Name = "button3";
            button3.Size = new System.Drawing.Size(80, 40);
            button3.TabIndex = 6;
            button3.Text = "*";
            button3.UseVisualStyleBackColor = true;
            button3.Click += OnMultiply;
            // 
            // button4
            // 
            button4.Location = new System.Drawing.Point(294, 144);
            button4.Name = "button4";
            button4.Size = new System.Drawing.Size(80, 40);
            button4.TabIndex = 7;
            button4.Text = "/";
            button4.UseVisualStyleBackColor = true;
            button4.Click += OnDivide;
            // 
            // resultLabel
            // 
            resultLabel.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            resultLabel.Location = new System.Drawing.Point(31, 235);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new System.Drawing.Size(151, 70);
            resultLabel.TabIndex = 8;
            resultLabel.Text = "Result:";
            // 
            // label2
            // 
            label2.Cursor = System.Windows.Forms.Cursors.Default;
            label2.Location = new System.Drawing.Point(31, 31);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(102, 23);
            label2.TabIndex = 9;
            label2.Text = "Primer Numero";
            label2.Click += label2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(label2);
            Controls.Add(resultLabel);
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(secondNumber);
            Controls.Add(firstNumber);
            Controls.Add(label1);
            Text = "Unidad III";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.Label resultLabel;

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;

        private System.Windows.Forms.TextBox firstNumber;
        private System.Windows.Forms.TextBox secondNumber;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}
