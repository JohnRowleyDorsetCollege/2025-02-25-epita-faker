namespace _2025_02_25_epita_faker.Models
{
    public class Location
    {
        public string Country { get; set; }
        public string City { get; set; }
    }   
    public class UserProfile
    {
        public string First_Name { get; set; }
        public string Last_Name { get; set; }
        public string Name { get => $"{First_Name} {Last_Name}"; }
        public string GovernmentId { get; set; }
        public int Followers { get; set; }
        public Location Location { get; set; } = new Location();
        public string Biography { get; set; }
        public override string ToString()
        {
            return $"Name: {Name}, GovernmentId: {GovernmentId}, Followers: {Followers}, Location: {Location.Country},{Location.City}, Biography: {Biography}";
        }


    }
}
