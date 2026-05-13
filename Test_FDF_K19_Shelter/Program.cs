


using ClassLib_Shelter.Model;
using ClassLib_Shelter.Registers;
using System;

// Simple test harness that exercises library classes and registers.
DateTime now = DateTime.Now;

// Districts
var district1 = new District(1, "Syd", "Væbner", "København S", "email@example.com", "+45 12 34 56 78");
var district2 = new District(2, "Nord", "Ulve", "København N", "nord@example.com", "+45 87 65 43 21");
Console.WriteLine("Districts:");
Console.WriteLine(district1);
Console.WriteLine(district2);
Console.WriteLine();

// Users
var user1 = new User(1, "John Doe", 25, "john@example.com", "District Leader", false, district1);
var user2 = new User(2, "Jane Smith", 30, "jane@example.com", "Member", false, district2);
Console.WriteLine("Users:");
Console.WriteLine(user1);
Console.WriteLine(user2);
Console.WriteLine();

// User register operations
var userRegister = new UserRegister();
userRegister.Add(user1);
userRegister.Add(user2);
Console.WriteLine("UserRegister contents:");
foreach (var u in userRegister.GetAll()) Console.WriteLine(u);
Console.WriteLine();

// Work with BlogPostRegister Directly
user1.CreateBlogPost("Trip to Shelter", "We had a great trip.", now.AddDays(-1), true);
user1.CreateBlogPost("Maintenance", "Shelter needs repair.", now, false);
Console.WriteLine("User1 blog posts (via User.CreateBlogPost):");
Console.WriteLine(user1.BlogPosts);
Console.WriteLine();





// Add comments to a blog post using Comment and CommentRegister
var commentRegister = new CommentRegister();
var comment1 = new Comment(1, "Looks great!", user2) { DatePublished = now };
var comment2 = new Comment(2, "I can help with repairs.", user1) { DatePublished = now };
commentRegister.Add(comment1);
commentRegister.Add(comment2);

Console.WriteLine("Comments on first blog post:");

Console.WriteLine();

// BlogPostImage

user1.CreateBlogPostImage("Photo", "Shelter photo", now, true, "/images/shelter.jpg", "jpg");

Console.WriteLine("Added BlogPostImage to BlogPostRegister:");
foreach (var bp in user1.BlogPosts.GetAll()) Console.WriteLine(bp);
Console.WriteLine();

// Shelters and Bookings
var shelter1 = new Shelter(1, "SkovShelter", "55.6761,12.5683", "Dyrehaven", 5);
Console.WriteLine("Shelter:");
Console.WriteLine(shelter1);
Console.WriteLine();

// Create booking using default constructor then set ShelterToBook before NoOfCampers
var booking = new Booking();
booking.ShelterToBook = shelter1;
booking.NoOfCampers = 4; // within capacity
booking.BookingId = 1;
booking.IsReserved = true;
booking.DistrictOfUser = district1.Name;
booking.CheckInDate = now.AddDays(7);
booking.CheckoutDate = now.AddDays(10);
Console.WriteLine("Booking:");
Console.WriteLine(booking);
Console.WriteLine();

// Demonstrate update and remove operations
Console.WriteLine("Blog post update and remove demo:");


Console.WriteLine("Updated post:");

Console.WriteLine("Removing first post (bp1)...");

Console.WriteLine("Remaining posts:");
foreach (var bp in user1.BlogPosts.GetAll()) Console.WriteLine(bp);
Console.WriteLine();

// UserRegister update
var changedUser = new User(user2.UserId, "Jane Doe", user2.Age, "jane.doe@example.com", "Member", false, user2.DistrictAssociation);
userRegister.Update(user2.UserId, changedUser);
Console.WriteLine("UserRegister after update:");
foreach (var u in userRegister.GetAll()) Console.WriteLine(u);

Console.WriteLine();
Console.WriteLine("Test harness finished.");
Console.WriteLine();

Console.WriteLine("Testing edge case: Attempting to set Maximum capacity to 10 (exceeds shelter capacity)...");

try
{
     shelter1.MaximumCapacity = 100;
}
catch (ArgumentException ex)
{
    Console.WriteLine("Caught expected exception: " + ex.Message);
}
catch (Exception ex)
{
    Console.WriteLine("Caught unexpected exception: " + ex.Message);
}
finally
{
    Console.WriteLine("Edge case test completed.");
}
