using KP_Sports_Management.Logic;

namespace KP_Sports_Management.Data
{
    class FileHandler
    {
        string path = @"Students.txt";

        public void writeTo(List<Person> students)
        {
            using (StreamWriter sW = new StreamWriter(path))
            {
                foreach(Person student in students)
                {
                    sW.WriteLine($"{student.Name}, {student.Surname}, {student.IdNum}, {student.Gender}, {student.PhoneNum}");
                }
            }  
        }

        public List<string> readFrom()
        {
            List<string> people = new List<string>();
            people = File.ReadAllLines(path).ToList();

            foreach(string line in people)
            {
                Console.WriteLine(line);
            }

            return people;
        }
    }
}
