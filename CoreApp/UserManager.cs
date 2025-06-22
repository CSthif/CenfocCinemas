using DataAccess.CRUD;
using DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreApp
{
    public class UserManager : BaseManager
    {

        /*
         * Metodo para crear un usuario.
         * Valida que el usuario sea mayor de 18 años
         * Valida que el codigo de usuario está disponible
         * Valida que el email no esté registrado
         * Envia un email de bienvenida al usuario
         */
        public void Create(User user)
        {
            try
            {
                //Validar la edad
                if (!IsOver18(user))
                {
                    var uCrud = new UserCrudFactory();

                    //Consultamos en la base de datos si el codigo de usuario ya existe
                    var uExist = uCrud.RetrieveByUserCode<User>(user);

                    if (uExist == null)
                    {
                        //Consutamos en la base de datos si el email ya existe
                        uExist = uCrud.RetrieveByEmail<User>(user);

                        if (uExist == null)
                        {
                            //Si el usuario es mayor de 18 años y el codigo de usuario y email no existen, creamos el usuario
                            uCrud.Create(user);
                            //Enviar email de bienvenida al usuario
                        }
                        else
                        {
                            throw new Exception("El email ya está registrado.");
                        }
                    }
                    else
                    {
                        throw new Exception("El código de usuario ya está en uso.");
                    }
                }
                else
                {
                    throw new Exception("El usuario debe ser mayor de 18 años.");
                }
            }
            catch (Exception ex)
            {
                ManageException(ex);
            }
        }

        private bool IsOver18(User user)
        {
            var currentDate = DateTime.Now;
            int age = currentDate.Year - user.BirthDate.Year;

            if (user.BirthDate > currentDate.AddYears(-age).Date)
            {
                age--;
            }
            return age >= 18;
        }
    }
}
