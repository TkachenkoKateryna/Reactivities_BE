﻿
using Microsoft.AspNetCore.Identity;

namespace Domain
{
    public class AppUser : IdentityUser
    {
        public string DisplayName { get; set; }
        public string Bio { get; set; }

        public ICollection<ActivityAttendee> Activities { get; set; } = new List<ActivityAttendee>();   
        public ICollection<Photo> Photos { get; set; } = new List<Photo>();
    }
}
