using factura.Modelo;
using factura.Vista;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace factura.Controladores
{
    public class Ctl_cliente
    {
        List<Cliente> lista;
        public Ctl_cliente()
        {
            lista = new List<Cliente>();
        }

        public void Add_lista(Cliente user)
        {
            lista.Add(user);
        }

        public string Imprimir()
        {
            string datos = "";
            foreach (Cliente user in lista)
            {
                datos += user.ToString() + "\n";
            }
            return datos;
        }

        public void Mostrar_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach (Cliente user in lista)
            {
                tabla.Rows.Add(user.Cedula, user.Nombre, user.Apellido);
            }
        }

        public Cliente buscar_x_cedula(string cedula)
        {
            return lista.Find(us => us.Cedula.Equals(cedula));
        }

        public int buscar_cliente(string cedula)
        {
            return lista.FindIndex(us => us.Cedula.Equals(cedula));
        }

        public void editar_cliente (int pos, Cliente cli)
        {
            lista[pos] = cli;   
        }

        public void eliminar_cliente (int pos)
        {
            lista.RemoveAt(pos);
        }


    }
}