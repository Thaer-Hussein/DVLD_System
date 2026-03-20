using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DVLD_DataAccess.People;

namespace DVLDBuisness.People
{
    enum enMode {AddNew = 0 , Update= 1 };
    public class clsPerson
    {
        enMode Mode = enMode.AddNew;
        public int PersonID { get; private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public bool Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityID { get; set; }
        public string ImagePath { get; set; }

        private bool _AddNewPerson()
        {
            this.PersonID = clsPersonData.AddNewPersonToTheDB(NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityID, ImagePath);

            return (this.PersonID != -1);
        }

        private bool _UpdatePersonInfo()
        {
            return (clsPersonData.UpdatePersonInDB(this.PersonID, this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName, this.DateOfBirth, this.Gender, this.Address, this.Phone, this.Email, this.NationalityID, this.ImagePath));
        }

        public clsPerson(string NationalNo = "", string FirstName = "", string SecondName = "", string ThirdName = "", string LastName = "", DateTime? DateOfBirth = null, bool Gender = false, string Address = "", string Phone = "", string Email = "", int NationalityID = -1, string ImagePath = "")
        {
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityID = NationalityID;
            this.ImagePath = ImagePath;
            Mode = enMode.AddNew;
        }

        private clsPerson(int PersonID, string NationalNo = "", string FirstName = "", string SecondName = "", string ThirdName = "", string LastName = "", DateTime? DateOfBirth = null, bool Gender = false, string Address = "", string Phone = "", string Email = "", int NationalityID = -1, string ImagePath = "")
        {
            this.PersonID = PersonID;
            this.NationalNo = NationalNo;
            this.FirstName = FirstName;
            this.SecondName = SecondName;
            this.ThirdName = ThirdName;
            this.LastName = LastName;
            this.DateOfBirth = DateOfBirth;
            this.Gender = Gender;
            this.Address = Address;
            this.Phone = Phone;
            this.Email = Email;
            this.NationalityID = NationalityID;
            this.ImagePath = ImagePath;

            Mode = enMode.Update;

        }


        public static clsPerson FindByPersonID(int PersonID)
        {

            string NationalNo = "", FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime? DateOfBirth = null;
            bool Gender = false;
            int NationalityID = -1;

            if (clsPersonData.GetPersonClassByPersonID(PersonID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityID, ImagePath);

            }
            else return null;
        }

        public static clsPerson FindByNationalNo(string NationalNo)
        {

            string  FirstName = "", SecondName = "", ThirdName = "", LastName = "", Address = "", Phone = "", Email = "", ImagePath = "";
            DateTime? DateOfBirth = null;
            bool Gender = false;
            int NationalityID = -1;
            int PersonID = -1; 

            if (clsPersonData.GetPersonClassByNationalNo(ref PersonID, NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityID, ref ImagePath))
            {
                return new clsPerson(PersonID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, Gender, Address, Phone, Email, NationalityID, ImagePath);

            }
            else return null;
        }

        public static DataTable GetAllPersons()
        {
            return clsPersonData.GetAllPersonsInDB();
        }

        public bool Save()
        {
            if (Mode == enMode.AddNew)
            {
                if (_AddNewPerson())
                {
                    Mode = enMode.Update;
                    return true;
                }

                else
                {
                    return false;
                }
            }

            else
            {
                if (_UpdatePersonInfo())
                {
                    return true;
                }

                else
                {
                    return false;
                }
            }

        }

        public static bool DeletePerson(int PersonID)
        {
            return clsPersonData.DeletPersonFromDB(PersonID);
        }

        public static bool CheckIfPersonExistsByTheNationalNo(string NationalNo)
        {
            return clsPersonData.CheckIfPersonExistsByNationalNo(NationalNo);
        }


    }
}
