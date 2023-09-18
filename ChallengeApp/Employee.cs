namespace ChallengeApp
{
    public class Employee
    {
        public Employee(string name, string lastName, int age)
        {
            Name = name;
            LastName = lastName;
            Age = age;
            Rating = 0;
        }

        public string Name { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public int Rating { get; private set; }

        public void AddRating(int rating)
        {
            if (rating >= 1 && rating <= 10)
            {
                Rating += rating;
            }

        }
    }
}
