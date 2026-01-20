namespace Asignacion.ProyectoFinal._4
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
            label1 = new Label();
            valueTbx = new TextBox();
            comboBox1 = new ComboBox();
            button1 = new Button();
            resultLabel = new Label();
            historyLbx = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 39);
            label1.Name = "label1";
            label1.Size = new Size(89, 15);
            label1.TabIndex = 0;
            label1.Text = "Valor a calcular:";
            // 
            // valueTbx
            // 
            valueTbx.Location = new Point(22, 57);
            valueTbx.Name = "valueTbx";
            valueTbx.Size = new Size(219, 23);
            valueTbx.TabIndex = 1;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(22, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(219, 23);
            comboBox1.TabIndex = 2;
            // 
            // button1
            // 
            button1.Location = new Point(22, 115);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 3;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F);
            resultLabel.Location = new Point(22, 153);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(82, 21);
            resultLabel.TabIndex = 4;
            resultLabel.Text = "Resultado:";
            // 
            // historyLbx
            // 
            historyLbx.FormattingEnabled = true;
            historyLbx.Location = new Point(275, 39);
            historyLbx.Name = "historyLbx";
            historyLbx.Size = new Size(343, 139);
            historyLbx.TabIndex = 5;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(643, 204);
            Controls.Add(historyLbx);
            Controls.Add(resultLabel);
            Controls.Add(button1);
            Controls.Add(comboBox1);
            Controls.Add(valueTbx);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox valueTbx;
        private ComboBox comboBox1;
        private Button button1;
        private Label resultLabel;
        private ListBox historyLbx;
    }
}
