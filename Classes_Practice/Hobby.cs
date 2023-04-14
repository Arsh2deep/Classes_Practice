using static System.Net.Mime.MediaTypeNames;

namespace Classes_Practice
{
    public class Hobby
    {
        string _name;
        string _description;
        int _hoursSpent;

        public Hobby(string name, string description, int hoursSpent)
        {
            Name = name;
            Description = description;
            HoursSpent = hoursSpent;
        }

        public string Name { get => _name; set => _name = value; }
        public string Description { get => _description; set => _description = value; }
        public int HoursSpent { get => _hoursSpent; set => _hoursSpent = value; }

        public override string ToString()
        {
            return $"Name: {_name}: Description: {_description}: Hours Spent : {_hoursSpent}";
        }
    }
}