using System;
using System.Linq;
using System.Windows.Forms;
using Asignacion.Unidad6.Data;
using Asignacion.Unidad6.Models;

namespace Asignacion.Unidad6;

/// <summary>
/// Formulario principal que maneja la lógica CRUD para los contactos.
/// </summary>
public partial class MainForm : Form
{
    public MainForm()
    {
        InitializeComponent();
        
        // Bloque opcional de prueba (EnsureCreated / Seed data) base MySQL
        using var db = new AppDbContext();
        db.Database.EnsureCreated();
        if (!db.Contacts.Any())
        {
            db.Contacts.Add(new Contact { Name = "Admin", Email = "admin@example.com", Phone = "123456789" });
            db.SaveChanges();
        }
        
        LoadData();

        // Suscripción a eventos
        btnSave.Click += BtnSave_Click;
        btnShow.Click += BtnShow_Click;
        btnDelete.Click += BtnDelete_Click;
        btnClear.Click += BtnClear_Click;
        dgvData.CellClick += DgvData_CellClick;
    }

    /// <summary>
    /// Carga todos los registros a la grilla.
    /// </summary>
    private void LoadData()
    {
        using var db = new AppDbContext();
        dgvData.DataSource = db.Contacts.ToList();
    }

    private void BtnSave_Click(object? sender, EventArgs e)
    {
        using var db = new AppDbContext();
        if (string.IsNullOrWhiteSpace(txtId.Text)) // Agregar
        {
            var contact = new Contact
            {
                Name = txtName.Text,
                Email = txtEmail.Text,
                Phone = txtPhone.Text
            };
            db.Contacts.Add(contact);
        }
        else // Actualizar
        {
            var id = int.Parse(txtId.Text);
            var contact = db.Contacts.Find(id);
            if (contact != null)
            {
                contact.Name = txtName.Text;
                contact.Email = txtEmail.Text;
                contact.Phone = txtPhone.Text;
            }
        }
        
        db.SaveChanges();
        ClearForm();
        LoadData();
    }

    private void BtnShow_Click(object? sender, EventArgs e)
    {
        LoadData();
    }

    private void BtnDelete_Click(object? sender, EventArgs e)
    {
        if (!string.IsNullOrWhiteSpace(txtId.Text))
        {
            var id = int.Parse(txtId.Text);
            using var db = new AppDbContext();
            var contact = db.Contacts.Find(id);
            if (contact != null)
            {
                db.Contacts.Remove(contact);
                db.SaveChanges();
                ClearForm();
            }
        }
        LoadData();
    }

    private void BtnClear_Click(object? sender, EventArgs e)
    {
        ClearForm();
    }
    
    private void DgvData_CellClick(object? sender, DataGridViewCellEventArgs e)
    {
        if (e.RowIndex >= 0)
        {
            var row = dgvData.Rows[e.RowIndex];
            txtId.Text = row.Cells["Id"].Value?.ToString();
            txtName.Text = row.Cells["Name"].Value?.ToString();
            txtEmail.Text = row.Cells["Email"].Value?.ToString();
            txtPhone.Text = row.Cells["Phone"].Value?.ToString();
        }
    }

    private void ClearForm()
    {
        txtId.Text = "";
        txtName.Text = "";
        txtEmail.Text = "";
        txtPhone.Text = "";
    }
}
