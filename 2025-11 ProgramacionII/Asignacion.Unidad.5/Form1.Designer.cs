namespace Asignacion.Unidad._5
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
            resultsDg = new System.Windows.Forms.DataGridView();
            addBtn = new System.Windows.Forms.Button();
            accountTbx = new System.Windows.Forms.TextBox();
            accountNameTbx = new System.Windows.Forms.TextBox();
            totalTbx = new System.Windows.Forms.TextBox();
            label1 = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            typeCbx = new System.Windows.Forms.ComboBox();
            label3 = new System.Windows.Forms.Label();
            label4 = new System.Windows.Forms.Label();
            totalCreditLabel = new System.Windows.Forms.Label();
            totalCreditsCbx = new System.Windows.Forms.TextBox();
            totalDebitLabel = new System.Windows.Forms.Label();
            totalDebitCbx = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)resultsDg).BeginInit();
            SuspendLayout();
            // 
            // resultsDg
            // 
            resultsDg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resultsDg.Location = new System.Drawing.Point(21, 92);
            resultsDg.Name = "resultsDg";
            resultsDg.Size = new System.Drawing.Size(602, 235);
            resultsDg.TabIndex = 0;
            resultsDg.Text = "dataGridView1";
            // 
            // addBtn
            // 
            addBtn.Location = new System.Drawing.Point(550, 63);
            addBtn.Name = "addBtn";
            addBtn.Size = new System.Drawing.Size(73, 23);
            addBtn.TabIndex = 1;
            addBtn.Text = "Agregar";
            addBtn.UseVisualStyleBackColor = true;
            // 
            // accountTbx
            // 
            accountTbx.Location = new System.Drawing.Point(21, 63);
            accountTbx.Name = "accountTbx";
            accountTbx.Size = new System.Drawing.Size(49, 23);
            accountTbx.TabIndex = 2;
            // 
            // accountNameTbx
            // 
            accountNameTbx.Location = new System.Drawing.Point(76, 63);
            accountNameTbx.Name = "accountNameTbx";
            accountNameTbx.Size = new System.Drawing.Size(259, 23);
            accountNameTbx.TabIndex = 3;
            // 
            // totalTbx
            // 
            totalTbx.Location = new System.Drawing.Point(423, 63);
            totalTbx.Name = "totalTbx";
            totalTbx.Size = new System.Drawing.Size(88, 23);
            totalTbx.TabIndex = 4;
            // 
            // label1
            // 
            label1.Location = new System.Drawing.Point(21, 46);
            label1.Name = "label1";
            label1.Size = new System.Drawing.Size(49, 17);
            label1.TabIndex = 5;
            label1.Text = "Cuenta";
            // 
            // label2
            // 
            label2.Location = new System.Drawing.Point(76, 46);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(155, 17);
            label2.TabIndex = 6;
            label2.Text = "Nombre Cuenta";
            // 
            // typeCbx
            // 
            typeCbx.FormattingEnabled = true;
            typeCbx.Location = new System.Drawing.Point(341, 63);
            typeCbx.Name = "typeCbx";
            typeCbx.Size = new System.Drawing.Size(76, 23);
            typeCbx.TabIndex = 7;
            // 
            // label3
            // 
            label3.Location = new System.Drawing.Point(341, 43);
            label3.Name = "label3";
            label3.Size = new System.Drawing.Size(49, 17);
            label3.TabIndex = 8;
            label3.Text = "Tipo";
            // 
            // label4
            // 
            label4.Location = new System.Drawing.Point(423, 43);
            label4.Name = "label4";
            label4.Size = new System.Drawing.Size(49, 17);
            label4.TabIndex = 9;
            label4.Text = "Monto";
            // 
            // totalCreditLabel
            // 
            totalCreditLabel.Location = new System.Drawing.Point(507, 336);
            totalCreditLabel.Name = "totalCreditLabel";
            totalCreditLabel.Size = new System.Drawing.Size(116, 17);
            totalCreditLabel.TabIndex = 11;
            totalCreditLabel.Text = "Total Credito";
            totalCreditLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalCreditsCbx
            // 
            totalCreditsCbx.Location = new System.Drawing.Point(507, 356);
            totalCreditsCbx.Name = "totalCreditsCbx";
            totalCreditsCbx.Size = new System.Drawing.Size(116, 23);
            totalCreditsCbx.TabIndex = 10;
            // 
            // totalDebitLabel
            // 
            totalDebitLabel.Location = new System.Drawing.Point(385, 336);
            totalDebitLabel.Name = "totalDebitLabel";
            totalDebitLabel.Size = new System.Drawing.Size(116, 17);
            totalDebitLabel.TabIndex = 13;
            totalDebitLabel.Text = "Total Debito";
            totalDebitLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // totalDebitCbx
            // 
            totalDebitCbx.Location = new System.Drawing.Point(385, 356);
            totalDebitCbx.Name = "totalDebitCbx";
            totalDebitCbx.Size = new System.Drawing.Size(116, 23);
            totalDebitCbx.TabIndex = 12;
            // 
            // Form1
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(800, 450);
            Controls.Add(totalDebitLabel);
            Controls.Add(totalDebitCbx);
            Controls.Add(totalCreditLabel);
            Controls.Add(totalCreditsCbx);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(typeCbx);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(totalTbx);
            Controls.Add(accountNameTbx);
            Controls.Add(accountTbx);
            Controls.Add(addBtn);
            Controls.Add(resultsDg);
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)resultsDg).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        private System.Windows.Forms.Label totalDebitLabel;
        private System.Windows.Forms.TextBox totalDebitCbx;

        private System.Windows.Forms.Label totalCreditLabel;
        private System.Windows.Forms.TextBox totalCreditsCbx;

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox typeCbx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.DataGridView resultsDg;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.TextBox accountTbx;
        private System.Windows.Forms.TextBox accountNameTbx;
        private System.Windows.Forms.TextBox totalTbx;

        #endregion
    }
}
