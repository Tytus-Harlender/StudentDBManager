using System;
using System.Windows;

namespace StudentsManagementAppForSchools
{
    public class SaverToDB
    {
        public void SaveInfo(string fullname)
        {
            try
            {
                string query =
                    "INSERT INTO dbo.StudentTable(Name, Surname, Learning Class, Supervisor) VALUES(Micky, Mouse, A, prof. Minnie)";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Saving to database was unsuccessful.");
                throw ex;
            }
        }
    }
}
