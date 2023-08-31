using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using factura.Controladores;
using factura.Modelo;
using factura.Vista;

namespace factura.Vista
{
    public partial class cliente : Form
    {
        Ctl_cliente ctl_cliente = new Ctl_cliente();    
        public cliente()
        {
            InitializeComponent();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btop_Click(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bted_Click(object sender, EventArgs e)
        {
            int pos = ctl_cliente.buscar_cliente(txtcedula.Text.Trim());
            Cliente user = new Cliente();
            {
                user.Cedula = txtcedula.Text;
                user.Nombre = txtnombre.Text;
                user.Apellido = txtapellido.Text;
            }
            ctl_cliente.editar_cliente(pos, user);
            MessageBox.Show("USUARIO ACTUALIZADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK);
            ctl_cliente.Mostrar_Tabla(vista);
            limpiar();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex != -1)
            {
                string cedula = vista.Rows[e.RowIndex].Cells[0].Value.ToString();
                Cliente user = ctl_cliente.buscar_x_cedula(cedula);
                txtcedula.Text = user.Cedula;
                txtnombre.Text = user.Nombre;
                txtapellido.Text = user.Apellido;
            }
        }

        private void btag_Click(object sender, EventArgs e)
        {
            Cliente user = new Cliente
            {
                Cedula = txtcedula.Text.Trim(),
                Nombre = txtnombre.Text.ToUpper(),
                Apellido = txtapellido.Text.ToUpper(),
            };
            ctl_cliente.Add_lista(user);
            MessageBox.Show("USUARIO GUARDADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK);
            ctl_cliente.Mostrar_Tabla(vista);
            limpiar();
        }

        public void limpiar()
        {
            txtcedula.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
        }

        private void btel_Click(object sender, EventArgs e)
        {
            int pos = ctl_cliente.buscar_cliente(txtcedula.Text.Trim());
            ctl_cliente.eliminar_cliente(pos);
            MessageBox.Show("USUARIO ELIMINADO CORRECTAMENTE", "NOTIFICACION", MessageBoxButtons.OK);
            ctl_cliente.Mostrar_Tabla(vista);
            limpiar();
        }
    }
}
