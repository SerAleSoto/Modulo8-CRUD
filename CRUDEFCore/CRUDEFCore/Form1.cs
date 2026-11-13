using CRUDEFCore.Entities;
using CRUDEFCore.Services;

namespace CRUDEFCore
{
    public partial class Form1 : Form
    {
        private readonly EmpleadoService service;
        private int idSeleccionado = 0;
        public Form1()
        {
            InitializeComponent();
            service = new EmpleadoService();
            CargarEmpleados();
        }

        private void CargarEmpleados()
        {
            var empleados = service.ObtenerTodas();
            dgvEmpleados.DataSource = empleados;
            dgvEmpleados.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvEmpleados.ReadOnly = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado
                {
                    NombreCompleto = txtNombre.Text,
                    NumeroDocumento = txtDoc.Text,
                    Sueldo = int.Parse(txtSueldo.Text)
                };

                service.Insertar(empleado);
                CargarEmpleados();
                MessageBox.Show("Registro guardado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void dgvEmpleados_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            var fila = dgvEmpleados.Rows[e.RowIndex];

            idSeleccionado = Convert.ToInt32(fila.Cells["IdEmpleado"].Value);
            txtNombre.Text = fila.Cells["NombreCompleto"].Value.ToString();
            txtDoc.Text = fila.Cells["NumeroDocumento"].Value.ToString();
            txtSueldo.Text = fila.Cells["Sueldo"].Value.ToString();
        }

        private void Actualizar_Click(object sender, EventArgs e)
        {
            try
            {
                Empleado empleado = new Empleado
                {
                    IdEmpleado = idSeleccionado,
                    NombreCompleto = txtNombre.Text,
                    NumeroDocumento = txtDoc.Text,
                    Sueldo = int.Parse(txtSueldo.Text)
                };

                service.Actualizar(empleado);
                CargarEmpleados();
                MessageBox.Show("Registro actualizado");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (idSeleccionado == 0)
            {
                MessageBox.Show("Seleccione un registro");
                return;
            }
            service.Eliminar(idSeleccionado);
            CargarEmpleados();
            MessageBox.Show("Registro eliminado");
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            dgvEmpleados.DataSource = service.Buscar(txtBuscar.Text);

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtNombre.Clear();
            txtDoc.Clear();
            txtSueldo.Clear();
            idSeleccionado = 0;
            txtNombre.Focus();
        }
    }
}
