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
                    //    Name = Faker.Name.FullName(),
                    //    GovernmentId = Faker.Identification.SocialSecurityNumber(),
                    //    Followers = Faker.RandomNumber.Next(0, 1000000),
                    //    Location = Faker.Address.City(),
                    //    Biography = Faker.Lorem.Paragraph()
                });
            }
            return userProfiles;
        }
    }
}
