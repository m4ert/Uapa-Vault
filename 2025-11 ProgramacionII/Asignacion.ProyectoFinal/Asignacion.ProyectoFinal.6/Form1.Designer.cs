namespace Asignacion.ProyectoFinal._6
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
            codigoTbx = new TextBox();
            nombreTbx = new TextBox();
            label2 = new Label();
            apellidoTbx = new TextBox();
            label3 = new Label();
            direccionTbx = new TextBox();
            label4 = new Label();
            telefonoTbx = new TextBox();
            label5 = new Label();
            label6 = new Label();
            estatusCbx = new ComboBox();
            eliminarBtn = new Button();
            dataGridView1 = new DataGridView();
            saveBtn = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 47);
            label1.Name = "label1";
            label1.Size = new Size(58, 20);
            label1.TabIndex = 0;
            label1.Text = "Codigo";
            // 
            // codigoTbx
            // 
            codigoTbx.Location = new Point(27, 71);
            codigoTbx.Margin = new Padding(3, 4, 3, 4);
            codigoTbx.Name = "codigoTbx";
            codigoTbx.Size = new Size(199, 27);
            codigoTbx.TabIndex = 1;
            // 
            // nombreTbx
            // 
            nombreTbx.Location = new Point(27, 131);
            nombreTbx.Margin = new Padding(3, 4, 3, 4);
            nombreTbx.Name = "nombreTbx";
            nombreTbx.Size = new Size(199, 27);
            nombreTbx.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 107);
            label2.Name = "label2";
            label2.Size = new Size(64, 20);
            label2.TabIndex = 2;
            label2.Text = "Nombre";
            // 
            // apellidoTbx
            // 
            apellidoTbx.Location = new Point(27, 195);
            apellidoTbx.Margin = new Padding(3, 4, 3, 4);
            apellidoTbx.Name = "apellidoTbx";
            apellidoTbx.Size = new Size(199, 27);
            apellidoTbx.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 171);
            label3.Name = "label3";
            label3.Size = new Size(66, 20);
            label3.TabIndex = 4;
            label3.Text = "Apellido";
            // 
            // direccionTbx
            // 
            direccionTbx.Location = new Point(27, 255);
            direccionTbx.Margin = new Padding(3, 4, 3, 4);
            direccionTbx.Name = "direccionTbx";
            direccionTbx.Size = new Size(199, 27);
            direccionTbx.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(27, 231);
            label4.Name = "label4";
            label4.Size = new Size(72, 20);
            label4.TabIndex = 6;
            label4.Text = "Direccion";
            // 
            // telefonoTbx
            // 
            telefonoTbx.Location = new Point(27, 319);
            telefonoTbx.Margin = new Padding(3, 4, 3, 4);
            telefonoTbx.Name = "telefonoTbx";
            telefonoTbx.Size = new Size(199, 27);
            telefonoTbx.TabIndex = 9;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(27, 295);
            label5.Name = "label5";
            label5.Size = new Size(67, 20);
            label5.TabIndex = 8;
            label5.Text = "Telefono";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(27, 356);
            label6.Name = "label6";
            label6.Size = new Size(55, 20);
            label6.TabIndex = 10;
            label6.Text = "Estatus";
            // 
            // estatusCbx
            // 
            estatusCbx.FormattingEnabled = true;
            estatusCbx.Location = new Point(27, 380);
            estatusCbx.Margin = new Padding(3, 4, 3, 4);
            estatusCbx.Name = "estatusCbx";
            estatusCbx.Size = new Size(199, 28);
            estatusCbx.TabIndex = 11;
            // 
            // eliminarBtn
            // 
            eliminarBtn.Location = new Point(798, 419);
            eliminarBtn.Margin = new Padding(3, 4, 3, 4);
            eliminarBtn.Name = "eliminarBtn";
            eliminarBtn.Size = new Size(86, 31);
            eliminarBtn.TabIndex = 14;
            eliminarBtn.Text = "Eliminar";
            eliminarBtn.UseVisualStyleBackColor = true;
            eliminarBtn.Click += eliminarBtn_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(275, 71);
            dataGridView1.Margin = new Padding(3, 4, 3, 4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(609, 340);
            dataGridView1.TabIndex = 15;
            // 
            // saveBtn
            // 
            saveBtn.Location = new Point(27, 419);
            saveBtn.Margin = new Padding(3, 4, 3, 4);
            saveBtn.Name = "saveBtn";
            saveBtn.Size = new Size(86, 31);
            saveBtn.TabIndex = 16;
            saveBtn.Text = "Guardar";
            saveBtn.UseVisualStyleBackColor = true;
            saveBtn.Click += saveBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 540);
            Controls.Add(saveBtn);
            Controls.Add(dataGridView1);
            Controls.Add(eliminarBtn);
            Controls.Add(estatusCbx);
            Controls.Add(label6);
            Controls.Add(telefonoTbx);
            Controls.Add(label5);
            Controls.Add(direccionTbx);
            Controls.Add(label4);
            Controls.Add(apellidoTbx);
            Controls.Add(label3);
            Controls.Add(nombreTbx);
            Controls.Add(label2);
            Controls.Add(codigoTbx);
            Controls.Add(label1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox codigoTbx;
        private TextBox nombreTbx;
        private Label label2;
        private TextBox apellidoTbx;
        private Label label3;
        private TextBox direccionTbx;
        private Label label4;
        private TextBox telefonoTbx;
        private Label label5;
        private Label label6;
        private ComboBox estatusCbx;
        private Button eliminarBtn;
        private DataGridView dataGridView1;
        private Button saveBtn;
    }
}
