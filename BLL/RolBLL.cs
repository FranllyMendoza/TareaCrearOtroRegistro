using CrearOtroRegistro.Entidades;
using CrearOtroRegistro.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrearOtroRegistro.BLL
{
    class RolBLL
    {
        public static Roll Buscar(int id)
        {
            Roll Roll;
            Contexto contexto = new Contexto();

            try
            {
                Roll = contexto.Rolles.Find(id);
            }

            catch (Exception)
            {

                throw;
            }

            finally
            {
                contexto.Dispose();
            }
            return Roll;
        }
        public static List<Roll> GetRoles()
        {
            List<Roll> lista = new List<Roll>();

            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Rolles.ToList();
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                contexto.Dispose();
            }
            return lista;
        }

    }
}
