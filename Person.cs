namespace KP_Sports_Management.Logic
{
    class Person
    {
        private string name, surname, gender;
        private int idNum, phoneNum;

        public Person(string name, string surname, string gender, int idNum, int phoneNum)
        {
            this.Name = name;
            this.Surname = surname;
            this.Gender = gender;
            this.IdNum = idNum;
            this.PhoneNum = phoneNum;
        }

        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string Gender { get => gender; set => gender = value; }
        public int IdNum { get => idNum; set => idNum = value; }
        public int PhoneNum { get => phoneNum; set => phoneNum = value; }

        public override string ToString()
        {
            return "...";
        }
    }
}
