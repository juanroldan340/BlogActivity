using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogActivity.Models
{
    public class PostModel
    {
        [Key]
        public int PostId { get; set; }
        public string Title { get; set; }
        public string Time { get; set; }
        public string Content { get; set; }

        public UserModel UserPost { get; set; }

    }
}