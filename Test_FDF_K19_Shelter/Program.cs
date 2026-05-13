



using ClassLib_Shelter.Registers;
using ClassLib_Shelter.Model;

DateTime DateNow = DateTime.Now;

District district = new District(1, "Syd", "Væbner", "København S", "email@example.com", "+45 12 34 56 78");
//int userId, string fullName, int age, string email, string role, bool isAdmin, District districtAssocation
User user = new User(1, "John Doe", 18,"Email@example.com","District Leader", false, district);


// string title, string content, DateTime datePublished, bool hasVisited

user.CreateBlogPost("Title", "Content", DateNow, true);
user.CreateBlogPost("Title", "Content", DateNow, true);

Console.WriteLine(user.BlogPosts);

