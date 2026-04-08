namespace Asignacion.Unidad6;

partial class MainForm
{
    private System.ComponentModel.IContainer components = null;

    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    private void InitializeComponent()
    {
        this.txtId = new System.Windows.Forms.TextBox();
        this.txtName = new System.Windows.Forms.TextBox();
        this.txtEmail = new System.Windows.Forms.TextBox();
        this.txtPhone = new System.Windows.Forms.TextBox();
        this.lblId = new System.Windows.Forms.Label();
        this.lblName = new System.Windows.Forms.Label();
        this.lblEmail = new System.Windows.Forms.Label();
        this.lblPhone = new System.Windows.Forms.Label();
        this.btnSave = new System.Windows.Forms.Button();
        this.btnShow = new System.Windows.Forms.Button();
        this.btnDelete = new System.Windows.Forms.Button();
        this.btnClear = new System.Windows.Forms.Button();
        this.dgvData = new System.Windows.Forms.DataGridView();
        this.panelInput = new System.Windows.Forms.Panel();
        
        ((System.ComponentModel.ISupportInitialize)(this.dgvData)).BeginInit();
        this.panelInput.SuspendLayout();
        this.SuspendLayout();
        
        // panelInput
        this.panelInput.Controls.Add(this.txtId);
        this.panelInput.Controls.Add(this.lblId);
        this.panelInput.Controls.Add(this.txtName);
        this.panelInput.Controls.Add(this.lblName);
        this.panelInput.Controls.Add(this.txtEmail);
        this.panelInput.Controls.Add(this.lblEmail);
        this.panelInput.Controls.Add(this.txtPhone);
        this.panelInput.Controls.Add(this.lblPhone);
        this.panelInput.Controls.Add(this.btnSave);
        this.panelInput.Controls.Add(this.btnShow);
        this.panelInput.Controls.Add(this.btnDelete);
        this.panelInput.Controls.Add(this.btnClear);
        this.panelInput.Dock = System.Windows.Forms.DockStyle.Top;
        this.panelInput.Height = 160;
        this.panelInput.Padding = new System.Windows.Forms.Padding(10);
        this.panelInput.BackColor = System.Drawing.Color.WhiteSmoke;
        
        // lblId, txtId
        this.lblId.Location = new System.Drawing.Point(20, 20);
        this.lblId.Text = "ID:";
        this.txtId.Location = new System.Drawing.Point(80, 18);
        this.txtId.ReadOnly = true;
        this.txtId.Width = 50;
        
        // lblName, txtName
        this.lblName.Location = new System.Drawing.Point(20, 50);
        this.lblName.Text = "Nombre:";
        this.txtName.Location = new System.Drawing.Point(80, 48);
        this.txtName.Width = 200;
        
        // lblEmail, txtEmail
        this.lblEmail.Location = new System.Drawing.Point(300, 20);
        this.lblEmail.Text = "Email:";
        this.txtEmail.Location = new System.Drawing.Point(360, 18);
        this.txtEmail.Width = 200;
        
        // lblPhone, txtPhone
        this.lblPhone.Location = new System.Drawing.Point(300, 50);
        this.lblPhone.Text = "Teléfono:";
        this.txtPhone.Location = new System.Drawing.Point(360, 48);
        this.txtPhone.Width = 200;
        
        // btnSave
        this.btnSave.Location = new System.Drawing.Point(80, 100);
        this.btnSave.Text = "Guardar";
        this.btnSave.Width = 80;
        this.btnSave.BackColor = System.Drawing.Color.LightGreen;
        
        // btnShow
        this.btnShow.Location = new System.Drawing.Point(170, 100);
        this.btnShow.Text = "Mostrar";
        this.btnShow.Width = 80;
        this.btnShow.BackColor = System.Drawing.Color.LightBlue;
        
        // btnDelete
        this.btnDelete.Location = new System.Drawing.Point(260, 100);
        this.btnDelete.Text = "Eliminar";
        this.btnDelete.Width = 80;
        this.btnDelete.BackColor = System.Drawing.Color.LightCoral;

        // btnClear
        this.btnClear.Location = new System.Drawing.Point(350, 100);
        this.btnClear.Text = "Limpiar";
        this.btnClear.Width = 80;
        this.btnClear.BackColor = System.Drawing.Color.LightGray;
        
        // dgvData
        this.dgvData.Dock = System.Windows.Forms.DockStyle.Fill;
        this.dgvData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
        this.dgvData.AllowUserToAddRows = false;
        this.dgvData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
        this.dgvData.ReadOnly = true;
        this.dgvData.MultiSelect = false;
        
        // MainForm
        this.ClientSize = new System.Drawing.Size(650, 450);
        this.Controls.Add(this.dgvData);
        this.Controls.Add(this.panelInput);
        this.Name = "MainForm";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        
        ((System.ComponentModel.ISupportInitialize)(this.dgvData)).EndInit();
        this.panelInput.ResumeLayout(false);
        this.ResumeLayout(false);
    }

    private System.Windows.Forms.TextBox txtId;
    private System.Windows.Forms.TextBox txtName;
    private System.Windows.Forms.TextBox txtEmail;
    private System.Windows.Forms.TextBox txtPhone;
    private System.Windows.Forms.Label lblId;
    private System.Windows.Forms.Label lblName;
    private System.Windows.Forms.Label lblEmail;
    private System.Windows.Forms.Label lblPhone;
    private System.Windows.Forms.Button btnSave;
    private System.Windows.Forms.Button btnShow;
    private System.Windows.Forms.Button btnDelete;
    private System.Windows.Forms.Button btnClear;
    private System.Windows.Forms.DataGridView dgvData;
    private System.Windows.Forms.Panel panelInput;
}
