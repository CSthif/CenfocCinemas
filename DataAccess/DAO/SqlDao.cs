using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.DAO
{
    /*
     * Clase u objeto que se encarga de la comunicación con la base de datos
     * Solo ejecuta Store Procedures
     * 
     * Esta clase implementa el Patrón del Singleton
     * para asegurar la existencia de una única instancia de este objeto
     */

    public class SqlDao
    {
        //Paso 1: Crear una instancia privada de la misma clase
        private static SqlDao _instance;

        private string _connectionString;

        //Paso 2: Redefinir el constructor default y convertirlo en privado
        private SqlDao()
        {
            _connectionString = string.Empty;
        }

        public static SqlDao GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SqlDao();
            }
            return _instance;
        }

        //Método para la ejecución de SP sin retorno
        public void ExecuteProcedure(SqlOperation operation)
        {
            //Conectarse a la base de datos
            //Ejecutar el SP
        }

        //Método para la ejecución de SP con retorno de data
        public List<Dictionary<string, object>> ExecuteQueryProcedure(SqlOperation operation)
        {
            //Conectarse a la base de datos
            //Ejecutar el SP
            //Capturar el resultado
            //Convertirlo en DTOs

            var list = new List<Dictionary<string, object>>();

            return list;
        }
    }
}