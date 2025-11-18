namespace  BasicsLearning.Models
{
    public class UserModel
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void PrintDetails()
        {
            Console.WriteLine($"User Name: {Name}, Age: {Age}");
        }
    }
}