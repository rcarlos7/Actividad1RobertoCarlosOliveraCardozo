using Actividad1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.DAL
{
    public class ComputadoraDal
    {
        public DataTable ListarComputadorasDal()
        {
            string consulta = "select * from computadora";
            DataTable lista = Conexion.EjecutarDataTabla(consulta, "tabla");
            return lista;
        }

        public void InsertarComputadoraDal(Computadora computadora)
        {
            string consulta = "insert into computadora values('" + computadora.Nombre + "'," +
                                                             "'" + computadora.Descripcion + "'," +
                                                              "" + computadora.Precio + "," +
                                                             "'" + computadora.FechadeFabricacion + "')";
            Conexion.Ejecutar(consulta);
        }

        public Computadora ObtenerCompuatdoraId(int id)
        {
            string consulta = "select * from computadora where idcomputadora = " + id;
            DataTable tabla = Conexion.EjecutarDataTabla(consulta, "asdas");
            Computadora computadora = new Computadora();
            if (tabla.Rows.Count > 0)
            {
                computadora.IdComputadora = Convert.ToInt32(tabla.Rows[0]["idComputadora"]);
                computadora.Nombre = tabla.Rows[0]["nombre"].ToString();
                computadora.Descripcion = tabla.Rows[0]["descripcion"].ToString();
                computadora.Precio = Convert.ToDecimal(tabla.Rows[0]["precio"]);
                computadora.FechadeFabricacion = Convert.ToDateTime(tabla.Rows[0]["fechadeFabricacion"]);
            }
            return computadora;
        }

        public void EditarComputadoraDal(Computadora computadora)
        {
            string consulta = "update computadora set nombre ='" + computadora.Nombre + "'," +
                                                     "descripcion ='" + computadora.Descripcion + "'," +
                                                     "precio =" + computadora.Precio + "," +
                                                     "fechadeFabricacion ='" + computadora.FechadeFabricacion + "' " +
                                    "where idcomputadora =" + computadora.IdComputadora;

            Conexion.Ejecutar(consulta);
        }

        public void EliminarComputadoraDal(int id)
        {
            string consulta = "delete from computadora where idcomputadora =" + id;
            Conexion.Ejecutar(consulta);
        }
    }
}
