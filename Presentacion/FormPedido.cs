// NOTA: Se cambió de Microsoft.Data.SqlClient a System.Data.SqlClient
// porque System.Data.SqlClient es el estándar en .NET 10 para Windows Forms
// Si prefieres Microsoft.Data.SqlClient, instala el paquete NuGet:
// Install-Package Microsoft.Data.SqlClient
using System.Data.SqlClient;  // ✅ CORRECTO PARA .NET 10
using PizzeriaBellaItalia.Dominio;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;

namespace PizzeriaBellaItalia.Presentacion;

public partial class FormPedido : Form
{
    private readonly GestionPedidos gesPed = new();

    public FormPedido()
    {
        InitializeComponent();
    }

    private void FormPedido_Load(object sender, EventArgs e)
    {
        CultureInfo.CurrentCulture = CultureInfo.InvariantCulture;

        PoblarComboBoxesConDiccionarios();
        LimpiarFormulario();
    }

    // -------------------------------------------------------------------- BOTÓN CALCULAR
    private void BtnCalcular_Click(object sender, EventArgs e)
    {
        if (!ValidaInputs()) return;

        PedidoPizza pedido = new()
        {
            Cliente = txtCliente.Text.Trim(),
            Telefono = txtTelefono.Text.Trim(),
            TamanoNombre = cboTamano.Text,
            PrecioBaseTamano = Convert.ToInt32(cboTamano.SelectedValue),
            MasaNombre = cboMasa.Text,
            RecargoMasa = Convert.ToInt32(cboMasa.SelectedValue),
            QuesoExtra = chkQuesoExtra.Checked,
            Pepperoni = chkPepperoni.Checked,
            Champinones = chkChampinones.Checked,
            Aceitunas = chkAceitunas.Checked,
            Tocino = chkTocino.Checked,
            EsDelivery = rdbDelivery.Checked,
            AplicaConvenioEstudiante = chkConvenioEstudiante.Checked
        };

        lblSubtotalValor.Text = $"$ {pedido.CalcularSubtotalPizza():N0} CLP";
        lblDescuentoValor.Text = $"- $ {pedido.CalcularMontoDescuento():N0} CLP";
        lblDeliveryValor.Text = $"+ $ {pedido.CalcularCostoDelivery():N0} CLP";
        lblIvaValor.Text = $"+ $ {pedido.CalcularMontoIva():N0} CLP";
        lblTotalValor.Text = $"$ {pedido.CalcularTotalPagar():N0} CLP";

        gesPed.AgregarPedido(pedido);

        lstResultados.DataSource = null;
        lstResultados.DataSource = gesPed.pedidos;

        grpResumen.Enabled = true;

        //CONSULTA GRABAR EN BD 
        // Se usa Button1 (primer botón = Yes), Button2 (No), Button3 (Cancel)
        DialogResult resultado = MessageBox.Show(
            $"¿Grabar pedido?\n\nTotal: ${pedido.CalcularTotalPagar():N0} CLP",
            "Confirmar",
            MessageBoxButtons.YesNoCancel,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button1  // ✅ Button1 = Yes (primer botón)
        );

        if (resultado == DialogResult.Yes)
        {
            // Captura el resultado de la grabación y muestra el mensaje correspondiente
            bool grabado = GrabarRegistroPedido(pedido);
            // si graba ok
            if (grabado)
            {
                // ✅ ÉXITO - Se grabó correctamente
                MessageBox.Show(
                    "✅ Pedido guardado exitosamente en la base de datos",
                    "Grabación Exitosa",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Opcional: Limpiar el formulario después de grabar
                LimpiarFormulario();
            }
            // Si no grabó, el error ya se muestra en la función GrabarRegistroPedido()
        }
        else if (resultado == DialogResult.No)
        {
            MessageBox.Show("Pedido no guardado", "Cancelado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        else if (resultado == DialogResult.Cancel)
        {
            LimpiarFormulario();
        }
    }

    // -------------------------------------------------------------------- OTROS BOTONES
    private void BtnLimpiar_Click(object sender, EventArgs e)
    {
        LimpiarFormulario();
    }

    private void BtnSalir_Click(object sender, EventArgs e)
    {
        DialogResult respuesta = MessageBox.Show(
            "¿Está seguro de que desea salir del sistema?",
            "Confirmar Salida",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question
        );

        if (respuesta == DialogResult.Yes)
        {
            this.Close();
        }
    }

    // -------------------------------------------------------------------- MÉTODOS AUXILIARES
    private void PoblarComboBoxesConDiccionarios()
    {
        Dictionary<string, int> opcionesTamano = new()
        {
            { "Seleccione uno", -1 },
            { "Personal (1 Persona)", 5000 },
            { "Mediana (2 a 3 Personas)", 8500 },
            { "Familiar (4 a 5 Personas)", 12000 }
        };

        cboTamano.DataSource = new BindingSource { DataSource = opcionesTamano };
        cboTamano.DisplayMember = "Key";
        cboTamano.ValueMember = "Value";
        cboTamano.DropDownStyle = ComboBoxStyle.DropDownList;

        Dictionary<string, int> opcionesMasa = new()
        {
            { "Seleccione uno", -1 },
            { "Masa Tradicional (Sin Recargo)", 0 },
            { "Masa Delgada (Sin Recargo)", 0 },
            { "Borde de Queso (+$1.500)", 1500 }
        };

        cboMasa.DataSource = new BindingSource { DataSource = opcionesMasa };
        cboMasa.DisplayMember = "Key";
        cboMasa.ValueMember = "Value";
        cboMasa.DropDownStyle = ComboBoxStyle.DropDownList;
    }

    private bool ValidaInputs()
    {
        if (string.IsNullOrWhiteSpace(txtCliente.Text))
        {
            MessageBox.Show(
                "Por favor, ingrese el nombre del cliente antes de calcular.",
                "Validación de Datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            txtCliente.Focus();
            return false;
        }

        if (cboTamano.SelectedValue == null || Convert.ToInt32(cboTamano.SelectedValue) == -1 ||
            cboMasa.SelectedValue == null || Convert.ToInt32(cboMasa.SelectedValue) == -1)
        {
            MessageBox.Show(
                "Por favor, seleccione un tamaño y un tipo de masa válidos.",
                "Validación de Datos",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
            );
            return false;
        }
        return true;
    }

    private void LimpiarFormulario()
    {
        txtCliente.Clear();
        txtTelefono.Clear();

        if (cboTamano.Items.Count > 0) cboTamano.SelectedIndex = 0;
        if (cboMasa.Items.Count > 0) cboMasa.SelectedIndex = 0;

        chkQuesoExtra.Checked = false;
        chkPepperoni.Checked = false;
        chkChampinones.Checked = false;
        chkAceitunas.Checked = false;
        chkTocino.Checked = false;

        rdbRetiro.Checked = true;
        chkConvenioEstudiante.Checked = false;

        lblSubtotalValor.Text = "$ 0 CLP";
        lblDescuentoValor.Text = "$ 0 CLP";
        lblDeliveryValor.Text = "$ 0 CLP";
        lblIvaValor.Text = "$ 0 CLP";
        lblTotalValor.Text = "$ 0 CLP";

        grpResumen.Enabled = false;

        txtCliente.Focus();
    }

    //graba en la BD
    public bool GrabarRegistroPedido(PedidoPizza pedido)
    {
        try
        {
            // Conexión a BD local - Usa MSSQLLocalDB (servidor de desarrollo local)
            // Server=(localdb)\MSSQLLocalDB es la instancia local de SQL Express
            using (SqlConnection conexion = new("Server=(localdb)\\MSSQLLocalDB;Database=PizzeriaDB;Integrated Security=True;"))
            {
                conexion.Open();

                using (SqlCommand comando = new(
                    "INSERT INTO Pedidos (Cliente, Telefono, TamanoNombre, PrecioBaseTamano, MasaNombre, RecargoMasa, " +
                    "QuesoExtra, Pepperoni, Champinones, Aceitunas, Tocino, EsDelivery, AplicaConvenioEstudiante, " +
                    "CostoIngredientes, SubtotalPizza, MontoDescuento, CostoDelivery, NetoAfecto, MontoIva, TotalPagar) " +
                    "VALUES (@Cliente, @Telefono, @TamanoNombre, @PrecioBaseTamano, @MasaNombre, @RecargoMasa, " +
                    "@QuesoExtra, @Pepperoni, @Champinones, @Aceitunas, @Tocino, @EsDelivery, @AplicaConvenioEstudiante, " +
                    "@CostoIngredientes, @SubtotalPizza, @MontoDescuento, @CostoDelivery, @NetoAfecto, @MontoIva, @TotalPagar)",
                    conexion))
                {
                    comando.Parameters.AddWithValue("@Cliente", pedido.Cliente);
                    comando.Parameters.AddWithValue("@Telefono", pedido.Telefono);
                    comando.Parameters.AddWithValue("@TamanoNombre", pedido.TamanoNombre);
                    comando.Parameters.AddWithValue("@PrecioBaseTamano", pedido.PrecioBaseTamano);
                    comando.Parameters.AddWithValue("@MasaNombre", pedido.MasaNombre);
                    comando.Parameters.AddWithValue("@RecargoMasa", pedido.RecargoMasa);
                    comando.Parameters.AddWithValue("@QuesoExtra", pedido.QuesoExtra);
                    comando.Parameters.AddWithValue("@Pepperoni", pedido.Pepperoni);
                    comando.Parameters.AddWithValue("@Champinones", pedido.Champinones);
                    comando.Parameters.AddWithValue("@Aceitunas", pedido.Aceitunas);
                    comando.Parameters.AddWithValue("@Tocino", pedido.Tocino);
                    comando.Parameters.AddWithValue("@EsDelivery", pedido.EsDelivery);
                    comando.Parameters.AddWithValue("@AplicaConvenioEstudiante", pedido.AplicaConvenioEstudiante);
                    comando.Parameters.AddWithValue("@CostoIngredientes", pedido.CalcularCostoIngredientes());
                    comando.Parameters.AddWithValue("@SubtotalPizza", pedido.CalcularSubtotalPizza());
                    comando.Parameters.AddWithValue("@MontoDescuento", pedido.CalcularMontoDescuento());
                    comando.Parameters.AddWithValue("@CostoDelivery", pedido.CalcularCostoDelivery());
                    comando.Parameters.AddWithValue("@NetoAfecto", pedido.CalcularNetoAfecto());
                    comando.Parameters.AddWithValue("@MontoIva", pedido.CalcularMontoIva());
                    comando.Parameters.AddWithValue("@TotalPagar", pedido.CalcularTotalPagar());

                    int filasAfectadas = comando.ExecuteNonQuery();
                    return filasAfectadas > 0;
                }
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show($"Error: {ex.Message}");
            return false;
        }
    }
}