#nullable disable

using System.ComponentModel.DataAnnotations;

namespace EntityLayer.Concrete
{
    public class Category
	{
        [Key]
        public int CategoryId { get; set; }

		public string CategoryName { get; set; }

		public string CategoryDescription { get; set; }

		public bool CategoryStatus { get; set; } // delete olmıcak aktif pasif olcak

		public List<Blog> Blogs { get; set; }



	}
}

