namespace _6.ValidPerson
{
    class Student
    {
        private string name;

        public Student(string name, string email)
        {
            Name = name;
            Email = email;
        }

        public string Name
        {
            get => name;
            set
            {
                foreach (var ch in value)
                {
                    if (!char.IsLetter(ch))
                    {
                        throw new InvalidPersonNameException("Invalid name", $"{value}");
                    }
                }

                name = value;
            }
        }

        public string Email { get; set; }
    }
}
