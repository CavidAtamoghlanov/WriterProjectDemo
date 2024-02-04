using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityLayer.Concretes
{
    public  class Category
    {
        // Properties. Our CategoryColumns
        [Key]
        public int CategoryID { get; set; }
        public string CategoryName { get; set; }
        public string CategoryDescription{ get; set; }
        public bool CategoryStatus { get; set; }


        // Navigation Property
        public ICollection<Blog> Blogs { get; set; }
    }
}
