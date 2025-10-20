using KP_Sports_Management.Logic;
using KP_Sports_Management;

namespace KP_Sports_Management.Data
{
    class DataHandler
    {
        string connect = @"Server = local; Initial Catalog = BelgiumCampusDB; Initial Security = SSPI";

        SqlDataAdapter adapt;

        Person people;

        public void registerStudent(Person people)
        {
            string query = $"INSERT INTO Students VALUES {people.Name}, {people.Surname}, {people.IdNum}, {people.Gender}, {people.PhoneNum}";

            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Error in connecting with database");
            }
        }

        
        public void updateStudent(Person p)
        {
            string query = $"UPDATE Students SET WHERE StudID = {p.IdNum}";

            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Error in connecting with database");
            }
        }

        public void deleteStudent()
        {
            string query = $"DELETE* FROM Students WHERE IDNumber = {people.IdNum}";

            try
            {
                using (SqlConnection con = new SqlConnection(connect))
                {
                    using (SqlCommand command = new SqlCommand(query, con))
                    {
                        con.Open();
                        command.ExecuteNonQuery();
                        con.Close();
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine("Error in connecting with database");
            }

        }

       /* public void formatCredentials()
        {
            List<Person> people = new List<Person>();
            FileHandler fh = new FileHandler();

            foreach(string line in fh.readFrom())
            {
                string[] cred = line.Split(' ');
                if(item)
            }
        }
    }
}
