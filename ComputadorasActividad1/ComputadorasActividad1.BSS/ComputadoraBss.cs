using Actividad1.DAL;
using Actividad1.Modelos;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Actividad1.BSS
{
    public class ComputadoraBss
    {
        ComputadoraDal dal = new ComputadoraDal();
        public DataTable ListarComputadorasBass()
        {
            return dal.ListarComputadorasDal();
        }

        public void InsertarComputadoraBss(Computadora computadora)
        {
            dal.InsertarComputadoraDal(computadora);
        }

        public Computadora ObtenerComputadoraIdBss(int id)
        {
            return dal.ObtenerCompuatdoraId(id);
        }

        public void EditarComputadoraBss(Computadora computadora)
        {
            dal.EditarComputadoraDal(computadora);
        }

        public void EliminarComputadoraBss(int id)
        {
            dal.EliminarComputadoraDal(id);
        }
    }
}
