using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Assignment5.Models
{
    public class PersonModel
    {
        private int personId;
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime dateOfBirth;
        private DateTime addedOn;
        private string addedBy;
        private string homeAddress;
        private string homeCity;
        private string faceBookAccountId;
        private string llinkedInId;
        private string updateOn;
        private string imagePath;
        private string twitterId;
        private string emailId;


        public string FirstName { get => firstName; set => firstName = value; }
        public string MiddleName { get => middleName; set => middleName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        [DataType(DataType.Date)]
        [Display(Name = "Date of Birth")]
        public DateTime DateOfBirth { get => dateOfBirth; set => dateOfBirth = value; }

        public string AddedBy { get => addedBy; set => addedBy = value; }
        public string HomeAddress { get => homeAddress; set => homeAddress = value; }
        public string HomeCity { get => homeCity; set => homeCity = value; }
        public string FaceBookAccountId { get => faceBookAccountId; set => faceBookAccountId = value; }
        public string LlinkedInId { get => llinkedInId; set => llinkedInId = value; }
        public string UpdateOn { get => updateOn; set => updateOn = value; }
        public string ImagePath { get => imagePath; set => imagePath = value; }
        public string TwitterId { get => twitterId; set => twitterId = value; }
        [EmailAddress]
        public string EmailId { get => emailId; set => emailId = value; }
        [DataType(DataType.Date)]
        public DateTime AddedOn { get => addedOn; set => addedOn = value; }
        public int PersonId { get => personId; set => personId = value; }
    }
}