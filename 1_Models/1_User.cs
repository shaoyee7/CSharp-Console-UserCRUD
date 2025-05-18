using System;
using Role.Models; 

//建立使用者屬性
namespace Role.Models
{
    public class User
    {
        public string Password{ get; set;}
        public int Id { get; set;}
        public string Name { get; set;}
        public int Age { get; set;}
        public string School { get; set;}
        public int Grade { get; set;}
        public string Mail { get; set;}

        public DateTime CreateAt { get; set;}
        public DateTime LastLogin { get; set;}
        public UserRole Role { get; set;}
    }
}