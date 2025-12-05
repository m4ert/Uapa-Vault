namespace Asignacion.Unidad._4
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
            comboBox1 = new System.Windows.Forms.ComboBox();
            cbxLabel = new System.Windows.Forms.Label();
            selectedMonth = new System.Windows.Forms.Label();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new System.Drawing.Point(33, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new System.Drawing.Size(142, 23);
            comboBox1.TabIndex = 0;
            // 
            // cbxLabel
            // 
            cbxLabel.Location = new System.Drawing.Point(33, 24);
            cbxLabel.Name = "cbxLabel";
            cbxLabel.Size = new System.Drawing.Size(142, 20);
            cbxLabel.TabIndex = 1;
            cbxLabel.Text = "Mes";
            // 
            // selectedMonth
            // 
            selectedMonth.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)0));
            selectedMonth.Location = new System.Drawing.Point(32, 97);
            selectedMonth.Name = "selectedMonth";
            selectedMonth.Size = new System.Drawing.Size(142, 47);
            selectedMonth.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(selectedMonth);
            Controls.Add(cbxLabel);
            Controls.Add(comboBox1);
            Text = "Form1";
            ResumeLayout(false);
        }

        private System.Windows.Forms.Label selectedMonth;

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label cbxLabel;

        #endregion
    }
}
