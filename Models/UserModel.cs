using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogActivity.Models
{
    public class UserModel
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public ICollection<PostModel> Posts { get; set; }
        public ICollection<CommentModel> Comments { get; set; }
    }
}
