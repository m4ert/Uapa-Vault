using Asignacion.ProyectoFinal._6.Database.Entities;
using Asignacion.ProyectoFinal._6.Database.Repositories;
using System.Threading.Tasks;

namespace Asignacion.ProyectoFinal._6
{
    public partial class Form1 : Form
    {
        private readonly PacienteRepository _repository;

        private const string ActivoOption = "Activo";
        private const string InactivoOption = "Inactivo";

        public Form1()
        {
            _repository = new();

            InitializeComponent();

            estatusCbx.DropDownStyle = ComboBoxStyle.DropDownList;
            estatusCbx.Items.Add(ActivoOption);
            estatusCbx.Items.Add(InactivoOption);

            dataGridView1.ReadOnly = true;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private Database.Entities.PacienteEntity? _paciente = null;


        private async void Form1_Load(object sender, EventArgs e)
        {
            await LoadDataAsync();
        }

        private async Task LoadDataAsync()
        {
            try
            {
                var pacientes = await _repository.GetAllAsync();

                dataGridView1.DataSource = pacientes.ToList();
                dataGridView1.Refresh();

                dataGridView1.ClearSelection();
                _paciente = new PacienteEntity();
                FillForm(_paciente);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar datos: {ex.Message}");
            }
        }

        private void DataGridView1_SelectionChanged(object? sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count <= 0)
                return;

            // Obtener la primera fila seleccionada
            var row = dataGridView1.SelectedRows[0];
            _paciente = (PacienteEntity)row.DataBoundItem!;
            FillForm(_paciente);
        }

        private void FillForm(PacienteEntity paciente)
        {
            if (paciente == null)
                return;

            codigoTbx.Text = paciente.CodigoPac ?? string.Empty;
            nombreTbx.Text = paciente.NombrePac ?? string.Empty;
            apellidoTbx.Text = paciente.ApelldioPac ?? string.Empty;
            direccionTbx.Text = paciente.DireccionPac ?? string.Empty;
            telefonoTbx.Text = paciente.TelefonoPac ?? string.Empty;
            estatusCbx.SelectedItem = GetEstatus(paciente.EstatusPac);
        }

        private async void saveBtn_Click(object sender, EventArgs e)
        {
            if (_paciente == null)
            {
                MessageBox.Show("Debes seleccionar un paciente");
                return;
            }


            try
            {
                _paciente = new Database.Entities.PacienteEntity
                {
                    CodigoPac = codigoTbx.Text,
                    NombrePac = nombreTbx.Text,
                    ApelldioPac = apellidoTbx.Text,
                    DireccionPac = direccionTbx.Text,
                    TelefonoPac = telefonoTbx.Text,
                    EstatusPac = GetEstatus(estatusCbx.SelectedItem!.ToString()!)
                };

                await _repository.UpSertAsync(_paciente);

                await LoadDataAsync();

                MessageBox.Show("Paciente modificado existosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Accion fallida: {ex.Message}");
            }
        }



        private async void eliminarBtn_Click(object sender, EventArgs e)
        {
            if (_paciente == null)
            {
                MessageBox.Show("Debes seleccionar un paciente");
                return;
            }

            try
            {
                await _repository.DeleteAsync(_paciente.CodigoPac);

                await LoadDataAsync();

                MessageBox.Show("Paciente eliminado existosamente");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Accion fallida: {ex.Message}");
            }
        }

        private static string GetEstatus(bool estatus)
        {
            return estatus ? ActivoOption : InactivoOption;
        }

        private static bool GetEstatus(string estatus)
        {
            return estatus switch
            {
                ActivoOption => true,
                InactivoOption => false,
                _ => throw new ArgumentOutOfRangeException(nameof(estatus))
            };
        }
    }
}
