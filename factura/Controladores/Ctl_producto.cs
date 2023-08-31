using factura.Modelo;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace factura.Controladores
{
    internal class Ctl_producto
    {
        List<Producto> lista;
        public Ctl_producto()
        {
            lista = new List<Producto>();
        }

        public void Add_lista(Producto prod)
        {
            lista.Add(prod);
        }

        public string Imprimir()
        {
            string datos = "";
            foreach (Producto prod in lista)
            {
                datos += prod.ToString() + "\n";
            }
            return datos;
        }

        public void Mostrar_Tabla(DataGridView tabla)
        {
            tabla.Rows.Clear();
            foreach (Producto prod in lista)
            {
                tabla.Rows.Add(prod.Cod, prod.Nombre, prod.prec, prod.Stock);
            }
        }

        public Producto buscar_x_codigo(string codigo)
        {
            return lista.Find(us => us.Codigo.Equals(codigo));
        }

        public int buscar_codigo(string codigo)
        {
            return lista.FindIndex(us => us.Codigo.Equals(codigo));
        }

        public void editar_producto(int pos, Producto prod)
        {
            lista[pos] = prod;
        }

        public void eliminar_producto(int pos)
        {
            lista.RemoveAt(pos);
        }

    }
}
