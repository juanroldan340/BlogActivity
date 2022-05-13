using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace BlogActivity.Models
{
    public class CommentModel
    {
        [Key]
        public int CommentId { get; set; }
        public string Date { get; set; }
        public string Comment { get; set; }

        public UserModel UserComment { get; set; }
    }
}
