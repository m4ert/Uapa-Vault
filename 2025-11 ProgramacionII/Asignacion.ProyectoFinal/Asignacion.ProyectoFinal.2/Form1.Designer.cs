namespace Asignacion.ProyectoFinal._2
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
            kgTbx = new TextBox();
            button1 = new Button();
            resultLabel = new Label();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(32, 23);
            label1.Name = "label1";
            label1.Size = new Size(67, 15);
            label1.TabIndex = 0;
            label1.Text = "Kilogramos";
            // 
            // kgTbx
            // 
            kgTbx.Location = new Point(32, 41);
            kgTbx.Name = "kgTbx";
            kgTbx.Size = new Size(186, 23);
            kgTbx.TabIndex = 1;
            // 
            // button1
            // 
            button1.Location = new Point(32, 70);
            button1.Name = "button1";
            button1.Size = new Size(106, 26);
            button1.TabIndex = 2;
            button1.Text = "Convertir";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // resultLabel
            // 
            resultLabel.AutoSize = true;
            resultLabel.Font = new Font("Segoe UI", 12F);
            resultLabel.Location = new Point(37, 128);
            resultLabel.Name = "resultLabel";
            resultLabel.Size = new Size(55, 21);
            resultLabel.TabIndex = 3;
            resultLabel.Text = "Libras:";
            // 
            // button2
            // 
            button2.Location = new Point(144, 70);
            button2.Name = "button2";
            button2.Size = new Size(74, 26);
            button2.TabIndex = 4;
            button2.Text = "Reiniciar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 209);
            Controls.Add(button2);
            Controls.Add(resultLabel);
            Controls.Add(button1);
            Controls.Add(kgTbx);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox kgTbx;
        private Button button1;
        private Label resultLabel;
        private Button button2;
    }
}
