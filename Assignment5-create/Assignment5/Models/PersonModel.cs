using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class PersonModel
    {
        //private int personId;
        //private string firstName;
        //private string middleName;
        //private string lastName;
        //private DateTime dateOfBirth;
        //private DateTime addedOn;
        //private string addedBy;
        //private string homeAddress;
        //private string homeCity;
        //private string faceBookAccountId;
        //private string llinkedInId;
        //private string updateOn;
        //private string imagePath;
        //private string twitterId;
        //private string emailId;

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set ; }
        public string LastName { get; set; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get ; set; }

        public string AddedBy { get ; set; }
        public string HomeAddress { get ; set; }
        public string HomeCity { get ; set ; }
        [Display(Name = "FaceBook Account Id")]
        public string FaceBookAccountId { get ; set ; }
        [Display(Name = "LinkedIn Id")]
        public string LlinkedInId { get ; set ; }
        public string UpdateOn { get ; set ; }
        public string ImagePath { get; set ; }
        public string TwitterId { get ; set; }
        [EmailAddress]
        public string EmailId { get; set; }
        [DataType(DataType.Date)]
        public DateTime AddedOn { get; set; }
        
    }
}