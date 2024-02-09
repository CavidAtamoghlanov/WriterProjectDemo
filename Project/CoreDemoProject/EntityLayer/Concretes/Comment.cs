using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public class Comment
    {
        // Properties. Our CommentColumns
        [Key]
        public int CommentID { get; set; }
        public string CommentUserName { get; set; }
        public string CommentTitle { get; set; }
        public string CommentContent { get; set; }
        public DateTime CommentCreateDate { get; set; }
        public bool CommentStatus { get; set; }
        public int BlogScore { get; set; }

        // Foreign Key
        public int BlogID { get; set; }

        // Navigation Property
        public Blog Blog { get; set; }
    }
}
