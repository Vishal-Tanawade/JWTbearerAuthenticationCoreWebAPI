using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace JWTbearerAuthenticationCoreWebAPI.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UserDetail>().HasData(
            new UserDetail() { UserId = 1, UserTypeId = 1, FName = "Aaron", LName = "Hawkins", UserName = "Aaronhawkins", Dob = DateTime.Now, Gender = "Male", PhoneNumber = "5123456789", Email = "aron.hawkins@aol.com", Password = "Arron@123", SqId = 7, SqAns = "Father" });

            modelBuilder.Entity<UserType>().HasData(
         new UserType() { UserTypeId = 1, UserTypeName = "Admin" },
         new UserType() { UserTypeId = 2, UserTypeName = "Customer" },
         new UserType() { UserTypeId = 3, UserTypeName = "Vendor" }
         );
            modelBuilder.Entity<SecurityQuestion>().HasData(
            new SecurityQuestion() { SqId = 1, Question = "What is your mother's maiden name?" },
            new SecurityQuestion() { SqId = 2, Question = "What is the name of your first pet?" },
            new SecurityQuestion() { SqId = 3, Question = "What was your first car?" },
            new SecurityQuestion() { SqId = 4, Question = "What elementary school did you attend?" },
            new SecurityQuestion() { SqId = 5, Question = "What is the name of the town where you were born?" },
            new SecurityQuestion() { SqId = 6, Question = "When you were young, what did you want to be when you grew up?" },
            new SecurityQuestion() { SqId = 7, Question = "Who was your childhood hero?" },
            new SecurityQuestion() { SqId = 8, Question = "Where was your best family vacation as a kid?" }
            );
        }
    }
}

