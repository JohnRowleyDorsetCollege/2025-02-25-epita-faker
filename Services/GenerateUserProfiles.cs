using _2025_02_25_epita_faker.Models;

namespace _2025_02_25_epita_faker.Services
{
    public static class GenerateUserProfiles
    {
       

        public static List<UserProfile> GenerateProfiles(int count)
        {
           
            List<UserProfile> userProfiles = new List<UserProfile>();
            for (int i = 0; i < count; i++)
            {
                userProfiles.Add(new UserProfile
                {
                 
                    First_Name = Faker.Name.First(),
                    Last_Name = Faker.Name.Last(),
                    GovernmentId = Faker.Identification.UKNationalInsuranceNumber(),
                    Followers = Faker.RandomNumber.Next(0, 1000000),
                    Location = new() { City = Faker.Address.City(), Country = Faker.Address.Country() },
                    Biography = Faker.Lorem.Paragraph()
                });
              Thread.Sleep(100);
            }
            return userProfiles;
        }
    }
}
