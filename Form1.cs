using GestionDeGastosMensuales.Models;
using GestionDeGastosMensuales.Repositories;

namespace GestionDeGastosMensuales
{

    public partial class Form1 : Form
    {
        private readonly GastoRepository _repositorio = new GastoRepository();

        public Form1()
        {
            InitializeComponent();
            CargarGastosEnTabla();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {

                // Validación
                if (string.IsNullOrWhiteSpace(txtDescripcion.Text) || string.IsNullOrWhiteSpace(txtCategoria.Text))
                {
                    MessageBox.Show("Debe ingresar una descripción y una categoría.");
                    return;
                }

                if (!double.TryParse(txtMonto.Text, out double monto))
                {
                    MessageBox.Show("El monto ingresado no es válido.");
                    return;
                }

                // Crear objeto gasto
                var nuevoGasto = new Gasto
                {
                    Descripcion = txtDescripcion.Text,
                    Categoria = txtCategoria.Text,
                    Monto = monto,
                    Fecha = dtpFecha.Value,
                    EsFijo = chkEsFijo.Checked,
                    Pagado = chkPagado.Checked
                };

                _repositorio.Agregar(nuevoGasto);
                MessageBox.Show("Gasto agregado correctamente.");

                LimpiarFormulario();
                CargarGastosEnTabla();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error al guardar el gasto: " + ex.Message);
            }
        }
        private void LimpiarFormulario()
        {
            txtDescripcion.Text = "";
            txtCategoria.Text = "";
            txtMonto.Text = "";
            dtpFecha.Value = DateTime.Now;
            chkEsFijo.Checked = false;
            chkPagado.Checked = false;
        }

        private void CargarGastosEnTabla()
        {
            var lista = _repositorio.ObtenerTodos();
            dgvGastos.DataSource = null;
            dgvGastos.DataSource = lista;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvGastos.CurrentRow != null)
            {
                var resultado = MessageBox.Show("¿Estás seguro de que deseas eliminar este gasto?", "Confirmar eliminación", MessageBoxButtons.YesNo);
                if (resultado == DialogResult.Yes)
                {
                    int id = Convert.ToInt32(dgvGastos.CurrentRow.Cells["Id"].Value);
                    _repositorio.Eliminar(id);
                    CargarGastosEnTabla();
                    MessageBox.Show("Gasto eliminado correctamente.");
                }
            }
            else
            {
                MessageBox.Show("Por favor selecciona un gasto en la tabla.");
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string texto = txtBuscar.Text.Trim();

            if (string.IsNullOrWhiteSpace(texto))
            {
                CargarGastosEnTabla(); // Si no se escribe nada, recarga todo
                return;
            }

            var resultados = _repositorio.Buscar(texto);
            dgvGastos.DataSource = null;
            dgvGastos.DataSource = resultados;

        }
    }
}
