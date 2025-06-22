using CoreApp.Services;
using CoreApp;
using DataAccess.CRUD;
using DataAccess.DAOs;
using DTOs;
using Newtonsoft.Json;
public class Program
{

    public static void Main(string[] args)
    {

        Console.WriteLine("Seleccione la opción deseada:");
        Console.WriteLine("1. Crear un usuario");
        Console.WriteLine("2. Consultar usuarios");
        Console.WriteLine("3. Actualizar un usuario");
        Console.WriteLine("4. Eliminar un usuario");
        Console.WriteLine("5. Crear película");
        Console.WriteLine("6. Consultar películas");
        Console.WriteLine("7. Actualizar película");
        Console.WriteLine("8. Eliminar película");

        var option = Int32.Parse(Console.ReadLine());
        var sqlOperation = new SqlOperation();

        switch (option)
        {
            case 1:

                Console.WriteLine("Digite el código de usuario");
                var userCode = Console.ReadLine();

                Console.WriteLine("Digite el nombre");
                var name = Console.ReadLine();

                Console.WriteLine("Digite el email");
                var email = Console.ReadLine();

                Console.WriteLine("Digite la contraseña");
                var password = Console.ReadLine();

                var status = "AC"; // Asumiendo que el estado por defecto es "AC"

                Console.WriteLine("Digite la fecha de nacimiento");
                var bdate = DateTime.Parse(Console.ReadLine());

                //Creamos el objeto del usuario a partir de los valores capturados en consola
                var User = new User()
                {
                    UserCode = userCode,
                    Name = name,
                    Email = email,
                    Password = password,
                    Status = status,
                    BirthDate = bdate
                };
                var um = new UserManager();
                um.Create(User);

                break;

            case 2:
                /*uCrud = new UserCrudFactory();
                var listUsers = uCrud.RetrieveAll<User>();
                foreach (var u in listUsers)
                {
                    Console.WriteLine(JsonConvert.SerializeObject(u));
                }
                break;
                */
            case 3:
                Console.WriteLine("Digite el titulo");
                var title = Console.ReadLine();

                Console.WriteLine("Digite la descripción");
                var desc = Console.ReadLine();

                Console.WriteLine("Digite la fecha de lanzamiento");
                var rDate = DateTime.Parse(Console.ReadLine());

                Console.WriteLine("Digite el género de la película");
                var genre = Console.ReadLine();

                Console.WriteLine("Digite el director");
                var director = Console.ReadLine();

                sqlOperation.ProcedureName = "CRE_MOVIE_PR";
                sqlOperation.AddStringParameter("P_Title", title);
                sqlOperation.AddStringParameter("P_Desc", desc);
                sqlOperation.AddDateTimeParam("P_ReleaseDate", rDate);
                sqlOperation.AddStringParameter("P_Genre", genre);
                sqlOperation.AddStringParameter("P_Director", director);
                break;
        }
        
        //Ejecución del procedure
        //var sqlDao = SqlDao.GetInstance();
    }
}