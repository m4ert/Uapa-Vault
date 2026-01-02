using System.ComponentModel;
using Asignacion.TrabajoFinal.Database;
using Asignacion.TrabajoFinal.Database.Entities;
using Microsoft.EntityFrameworkCore;

namespace Asignacion.TrabajoFinal
{
    public partial class Form1 : Form
    {
        private readonly AppDbContext _context;
        private BindingList<ProductoEntity> _productos;
        public Form1()
        {
            InitializeComponent();
            
            _context =  new AppDbContext();

            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            dataGridView1.Columns.Add("codigoproducto", "#");
            dataGridView1.Columns.Add("descripcionproducto", "Descripcion");
            dataGridView1.Columns.Add("costoproducto", "Costo");
            dataGridView1.Columns.Add("precioproducto", "Precio");
            dataGridView1.Columns.Add("existenciaproducto", "Existencia");
            dataGridView1.Columns.Add("estatusproducto", "Estado");

            dataGridView1.Columns["codigoproducto"]!.DataPropertyName = nameof(ProductoEntity.CodigoProducto);
            dataGridView1.Columns["descripcionproducto"]!.DataPropertyName = nameof(ProductoEntity.DescripcionProducto);
            dataGridView1.Columns["costoproducto"]!.DataPropertyName = nameof(ProductoEntity.CostoProducto);
            dataGridView1.Columns["precioproducto"]!.DataPropertyName = nameof(ProductoEntity.PrecioProducto);
            dataGridView1.Columns["existenciaproducto"]!.DataPropertyName = nameof(ProductoEntity.ExistenciaProducto);
            dataGridView1.Columns["estatusproducto"]!.DataPropertyName = nameof(ProductoEntity.EstatusProducto);

            saveButton.Click += SaveButton_Click;

            try
            {
                _context.Productos.Load();
                _productos = _context.Productos.Local.ToBindingList();
                dataGridView1.DataSource = _productos;
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void SaveButton_Click(object? sender, EventArgs e)
        {
            try
            {
                dataGridView1.EndEdit();

                _context.SaveChanges();

                MessageBox.Show("Cambios guardados correctamente.", "Exito");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar: {ex.Message}");
            }
        }
    }
}
