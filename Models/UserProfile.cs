namespace _2025_02_25_epita_faker.Models
{
    public class UserProfile
    {
        public string Name { get; set; }
        public string GovernmentId { get; set; }
        public int Followers { get; set; }
        public string Location { get; set; }
        public string Biography { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, GovernmentId: {GovernmentId}, Followers: {Followers}, Location: {Location}, Biography: {Biography}";
        }


    }
}
