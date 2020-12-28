using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Adresar3.Models
{
    #region snippet1
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }

        public string OwnerID { get; set; }
        [Required]
        public string Name { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        [Required, DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number")]
        public int ContactNum { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number (Optional)")]

        public string ContactNum1 { get; set; }
        [Display(Name = "Phone Number (Optional)")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNum2 { get; set; }
        [Display(Name = "Phone Number (Optional)")]
        [DataType(DataType.PhoneNumber)]
        public string ContactNum3 { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number (Optional)")]
        public string ContactNum4 { get; set; }
        [DataType(DataType.PhoneNumber)]
        [Display(Name = "Phone Number (Optional)")]
        public string ContactNum5 { get; set; }


        public ContactStatus Status { get; set; }

        public string Role { get; set; }
    }

    public enum ContactStatus
    {
        Submitted,
        Approved,
        Rejected
    }
    #endregion
}