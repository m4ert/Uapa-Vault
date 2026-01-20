namespace Asignacion.ProyectoFinal._5
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
            productCodeTbx = new TextBox();
            nameTbx = new TextBox();
            label2 = new Label();
            label3 = new Label();
            quantityTbx = new TextBox();
            label4 = new Label();
            label5 = new Label();
            button1 = new Button();
            dataGridView1 = new DataGridView();
            button2 = new Button();
            inboundLabel = new Label();
            outboundLabel = new Label();
            datePicker = new DateTimePicker();
            typeCbx = new ComboBox();
            stockNetoLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 37);
            label1.Name = "label1";
            label1.Size = new Size(114, 15);
            label1.TabIndex = 0;
            label1.Text = "Codigo de Producto";
            // 
            // productCodeTbx
            // 
            productCodeTbx.Location = new Point(26, 55);
            productCodeTbx.Name = "productCodeTbx";
            productCodeTbx.Size = new Size(170, 23);
            productCodeTbx.TabIndex = 1;
            // 
            // nameTbx
            // 
            nameTbx.Location = new Point(26, 107);
            nameTbx.Name = "nameTbx";
            nameTbx.Size = new Size(170, 23);
            nameTbx.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 89);
            label2.Name = "label2";
            label2.Size = new Size(51, 15);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 140);
            label3.Name = "label3";
            label3.Size = new Size(31, 15);
            label3.TabIndex = 4;
            label3.Text = "Tipo";
            // 
            // quantityTbx
            // 
            quantityTbx.Location = new Point(26, 207);
            quantityTbx.Name = "quantityTbx";
            quantityTbx.Size = new Size(170, 23);
            quantityTbx.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(26, 189);
            label4.Name = "label4";
            label4.Size = new Size(55, 15);
            label4.TabIndex = 6;
            label4.Text = "Cantidad";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(26, 240);
            label5.Name = "label5";
            label5.Size = new Size(38, 15);
            label5.TabIndex = 8;
            label5.Text = "Fecha";
            // 
            // button1
            // 
            button1.Location = new Point(26, 297);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 6;
            button1.Text = "Agregar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(267, 37);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(493, 324);
            dataGridView1.TabIndex = 11;
            // 
            // button2
            // 
            button2.Location = new Point(685, 367);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 12;
            button2.Text = "Eliminar";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // inboundLabel
            // 
            inboundLabel.AutoSize = true;
            inboundLabel.Location = new Point(267, 371);
            inboundLabel.Name = "inboundLabel";
            inboundLabel.Size = new Size(87, 15);
            inboundLabel.TabIndex = 13;
            inboundLabel.Text = "Total entradas: ";
            // 
            // outboundLabel
            // 
            outboundLabel.AutoSize = true;
            outboundLabel.Location = new Point(424, 371);
            outboundLabel.Name = "outboundLabel";
            outboundLabel.Size = new Size(77, 15);
            outboundLabel.TabIndex = 14;
            outboundLabel.Text = "Total salidas: ";
            // 
            // datePicker
            // 
            datePicker.Location = new Point(26, 258);
            datePicker.Name = "datePicker";
            datePicker.Size = new Size(170, 23);
            datePicker.TabIndex = 5;
            // 
            // typeCbx
            // 
            typeCbx.FormattingEnabled = true;
            typeCbx.Location = new Point(26, 158);
            typeCbx.Name = "typeCbx";
            typeCbx.Size = new Size(170, 23);
            typeCbx.TabIndex = 3;
            // 
            // stockNetoLabel
            // 
            stockNetoLabel.AutoSize = true;
            stockNetoLabel.Location = new Point(549, 371);
            stockNetoLabel.Name = "stockNetoLabel";
            stockNetoLabel.Size = new Size(66, 15);
            stockNetoLabel.TabIndex = 17;
            stockNetoLabel.Text = "Stock neto:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(stockNetoLabel);
            Controls.Add(typeCbx);
            Controls.Add(datePicker);
            Controls.Add(outboundLabel);
            Controls.Add(inboundLabel);
            Controls.Add(button2);
            Controls.Add(dataGridView1);
            Controls.Add(button1);
            Controls.Add(label5);
            Controls.Add(quantityTbx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(nameTbx);
            Controls.Add(label2);
            Controls.Add(productCodeTbx);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox productCodeTbx;
        private TextBox nameTbx;
        private Label label2;
        private Label label3;
        private TextBox quantityTbx;
        private Label label4;
        private Label label5;
        private Button button1;
        private DataGridView dataGridView1;
        private Button button2;
        private Label inboundLabel;
        private Label outboundLabel;
        private DateTimePicker datePicker;
        private ComboBox typeCbx;
        private Label stockNetoLabel;
    }
}
