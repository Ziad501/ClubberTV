using Microsoft.AspNetCore.Identity;

namespace Domain.Entites
{
    public class AppUser : IdentityUser
    {
        public HashSet<PlayList> PlayLists { get; set; } = [];
    }
}
