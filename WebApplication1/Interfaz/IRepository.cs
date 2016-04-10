using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication1.Interfaz
{
    public interface IRepository<TEntity> where TEntity : class
    {
        /// <summary>
        /// Metodo Buscar "id"
        /// Modificar id de acuerdo a los requerimientos
        /// </summary>
        /// <param name="id"></param>
        /// <returns>Objeto con mismo ID</returns>
        TEntity Get(int id);
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        IEnumerable<TEntity> GetAll();
        

    }
}
