using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace mca.entity.Entities
{
    [Table("contact")]
    public class Contact
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ContactId { get; set; }
        [StringLength(50)]
        public string Firstname { get; set; }
        [StringLength(50)]
        public string Lastname { get; set; }
        [StringLength(100)]
        public string AddressLine { get; set; }
        [StringLength(100)]
        public string CityMunicipality { get; set; }
        [StringLength(100)]
        public string ProvinceState { get; set; }
        [StringLength(100)]
        public string Country { get; set; }
        [StringLength(10)]
        public string ZipCode { get; set; }
        [StringLength(5)]
        public string MobilePrefix { get; set; }
        [StringLength(15)]
        public string Mobile { get; set; }
        [StringLength(5)]
        public string PhonePrefix { get; set; }
        [StringLength(15)]
        public string Phone { get; set; }
        [StringLength(50)]
        public string EmailAddress { get; set; }
    }
}
