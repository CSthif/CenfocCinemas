using DataAccess.DAOs;
public class Program
{

    public static void Main(string[] args)
    {
        var sqlOperation = new SqlOperation();
        sqlOperation.ProcedureName = "CRE_USER_PR";

        sqlOperation.AddStringParameter("P_UserCode", "Ctrlsthif");
        sqlOperation.AddStringParameter("P_Name", "Sthif");
        sqlOperation.AddStringParameter("P_Email", "Sthifaroyo.ch@gmail.com");
        sqlOperation.AddStringParameter("P_Password", "Sthif123");
        sqlOperation.AddStringParameter("P_Status", "AC");
        sqlOperation.AddDateTimeParam("P_BirthDate", DateTime.Now);

        var sqlDao = SqlDao.GetInstance();

        sqlDao.ExecuteProcedure(sqlOperation);
    }
}