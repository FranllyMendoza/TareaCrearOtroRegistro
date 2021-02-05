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
        public static RolBLL Buscar(int id)
        {
            RolBLL Roll;
            DAL.Contexto contexto = new Contexto();

            try
            {
                Roll = contexto.RollId.Find(id);
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
        public static List<RolBLL> GetRoles()
        {
            List<RolBLL> lista = new List<RolBLL>();

            Contexto contexto = new Contexto();

            try
            {
                lista = contexto.Roll.ToList();
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
