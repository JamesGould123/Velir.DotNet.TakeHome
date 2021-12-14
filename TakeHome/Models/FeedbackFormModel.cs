using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TakeHome.Models
{
    public class FeedbackFormModel
	{
        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide First Name")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "First Name Should be min 1 and max 25 length")]
        [DisplayName("First Name")]
        public String FirstName
        {
            get;
            set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Last Name")]
        [StringLength(25, MinimumLength = 1, ErrorMessage = "First Name Should be min 1 and max 25 length")]
        [DisplayName("Last Name")]
        public String LastName
        {
            get;
            set;
        }

        [Required(AllowEmptyStrings = false, ErrorMessage = "Please Provide Email")]
        [RegularExpression("^[a-zA-Z0-9_\\.-]+@([a-zA-Z0-9-]+\\.)+[a-zA-Z]{2,6}$", ErrorMessage = "Please Provide Valid Email")]
        [StringLength(200, MinimumLength = 0, ErrorMessage = "First Name Should be min 1 and max 25 length")]
        public String Email
        {
            get;
            set;
        }

        [DataType(DataType.MultilineText)]
        [StringLength(200, MinimumLength = 1, ErrorMessage = "Comments are required, and should have a max length of 200 characters")]
        public string Comments { get; set; }



	}
}