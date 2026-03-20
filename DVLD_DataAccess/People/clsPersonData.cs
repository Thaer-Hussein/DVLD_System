using DVLD_DataAccess.General;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace DVLD_DataAccess.People
{
    public class clsPersonData
    {
        static public bool GetPersonClassByPersonID(int PersonID, ref string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime? DateOfBirth, ref bool Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityID, ref string ImagePath)
        {
            bool isFound = false;

            string query = "Select * from People where PersonID = @PersonID";


            using (SqlConnection conn = new SqlConnection(clsGeneralDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        NationalNo = (string)reader["NationalNo"];
                        FirstName = (string)reader["FirstName"];
                        SecondName = (string)reader["SecondName"];
                        ThirdName = (string)reader["ThirdName"];
                        LastName = (string)reader["LastName"];
                        if (reader["DateOfBirth"] != DBNull.Value)
                            DateOfBirth = (DateTime)reader["DateOfBirth"];  // direct cast
                        else
                            DateOfBirth = null; Gender = Convert.ToBoolean(reader["Gendor"]);
                        Address = (string)reader["Address"];
                        Phone = (string)reader["Phone"];
                        Email = (string)reader["Email"];
                        NationalityID = Convert.ToInt32(reader["NationalityCountryID"]);

                        if (reader["ImagePath"] != DBNull.Value)
                            ImagePath = (string)reader["ImagePath"];  // direct cast
                        else
                            ImagePath = null;

                    }
                    else
                    {
                        isFound = false;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return isFound;

        }

        static public bool GetPersonClassByNationalNo(ref int PersonID, string NationalNo, ref string FirstName, ref string SecondName, ref string ThirdName, ref string LastName, ref DateTime? DateOfBirth, ref bool Gender, ref string Address, ref string Phone, ref string Email, ref int NationalityID, ref string ImagePath)
        {
            bool isFound = false;

            string query = "Select * from People where NationalNo = @NationalNo";


            using (SqlConnection conn = new SqlConnection(clsGeneralDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        isFound = true;

                        PersonID = (int)reader["PersonID"];
                        FirstName = (string)reader["FirstName"];
                        SecondName = (string)reader["SecondName"];
                        ThirdName = (string)reader["ThirdName"];
                        LastName = (string)reader["LastName"];
                        if (reader["DateOfBirth"] != DBNull.Value)
                            DateOfBirth = (DateTime)reader["DateOfBirth"];  // direct cast
                        else
                            DateOfBirth = null; Gender = Convert.ToBoolean(reader["Gendor"]);
                        Address = (string)reader["Address"];
                        Phone = (string)reader["Phone"];
                        Email = (string)reader["Email"];
                        NationalityID = Convert.ToInt32(reader["NationalityCountryID"]);

                        if (reader["ImagePath"] != DBNull.Value)
                            ImagePath = (string)reader["ImagePath"];  // direct cast
                        else
                            ImagePath = null;

                    }
                    else
                    {
                        isFound = false;
                    }
                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
            }

            return isFound;

        }
        static public DataTable GetAllPersonsInDB()
        {
            DataTable dt = new DataTable();


            string query = @"SELECT People.PersonID, People.NationalNo,
              People.FirstName, People.SecondName, People.ThirdName, People.LastName,
			  People.DateOfBirth, People.Gendor,  
				  CASE
                  WHEN People.Gendor = 0 THEN 'Male'

                  ELSE 'Female'

                  END as GendorCaption ,
			  People.Address, People.Phone, People.Email, 
              People.NationalityCountryID, Countries.CountryName, People.ImagePath
              FROM            People INNER JOIN
                         Countries ON People.NationalityCountryID = Countries.CountryID
                ORDER BY People.FirstName"; 


            using (SqlConnection conn = new SqlConnection(clsGeneralDataAccessSettings.ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {

                try
                {
                    conn.Open();

                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read())
                    {
                        dt.Load(reader);
                    }

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return dt;
            }
        }

        static public int AddNewPersonToTheDB(string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime? DateOfBirth, bool Gender, string Address, string Phone, string Email, int NationalityID, string ImagePath)
        {
            int CurrentID = -1;

            string ConnectionString = clsGeneralDataAccessSettings.ConnectionString;
            string query = "insert into People (NationalNo , FirstName , SecondName , ThirdName , LastName , DateOfBirth , Gendor , Address , Phone , Email , NationalityCountryID , ImagePath) values (@NationalNo , @FirstName , @SecondName , @ThirdName , @LastName ,@DateOfBirth , @Gendor , @Address , @Phone , @Email , @NationalityCountryID , @ImagePath); SELECT SCOPE_IDENTITY(); ";

            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@SecondName", SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@Gendor", Gender);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@NationalityCountryID", NationalityID);
                if (ImagePath != "")
                    cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

                else
                    cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                try
                {
                    conn.Open();

                    CurrentID = Convert.ToInt32(cmd.ExecuteScalar());


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

            }

            return CurrentID;
        }

        static public bool UpdatePersonInDB(int PersonID, string NationalNo, string FirstName, string SecondName, string ThirdName, string LastName, DateTime? DateOfBirth, bool Gender, string Address, string Phone, string Email, int NationalityID, string ImagePath)
        {
            int affRows = 0;
            string ConnectionString = clsGeneralDataAccessSettings.ConnectionString;
            string query = @"Update People 
                               set NationalNo = @NationalNo , FirstName = @FirstName , 
                                SecondName = @SecondName , ThirdName = @ThirdName , LastName = @LastName , DateOfBirth = @DateOfBirth , Gendor = @Gender , Address = @Address  , Phone = @Phone , Email = @Email , NationalityCountryID = @NationalityID , ImagePath = @ImagePath
                                 where PersonID = @PersonID";


            using (SqlConnection conn = new SqlConnection(ConnectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", PersonID);
                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);
                cmd.Parameters.AddWithValue("@FirstName", FirstName);
                cmd.Parameters.AddWithValue("@SecondName", SecondName);
                cmd.Parameters.AddWithValue("@ThirdName", ThirdName);
                cmd.Parameters.AddWithValue("@LastName", LastName);
                cmd.Parameters.AddWithValue("@DateOfBirth", DateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", Gender);
                cmd.Parameters.AddWithValue("@Address", Address);
                cmd.Parameters.AddWithValue("@Phone", Phone);
                cmd.Parameters.AddWithValue("@Email", Email);
                cmd.Parameters.AddWithValue("@NationalityID", NationalityID);
                if (ImagePath != "")
                    cmd.Parameters.AddWithValue("@ImagePath", ImagePath);

                else
                    cmd.Parameters.AddWithValue("@ImagePath", System.DBNull.Value);


                try
                {
                    conn.Open();

                    affRows = cmd.ExecuteNonQuery();

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return affRows > 0;
            }
        }

        static public bool DeletPersonFromDB(int PersonID)
        {
            string connectionString = clsGeneralDataAccessSettings.ConnectionString;
            string query = "delete from People where PersonID = @PersonID";
            int affRows = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@PersonID", PersonID);

                try
                {
                    conn.Open();

                    affRows = cmd.ExecuteNonQuery();

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return affRows > 0;
            }
        }

        static public bool CheckIfPersonExistsByNationalNo(string NationalNo)
        {
            string connectionString = clsGeneralDataAccessSettings.ConnectionString;
            string query = "select 1 from People where NationalNo = @NationalNo";
            int ret = 0;
            using (SqlConnection conn = new SqlConnection(connectionString))
            using (SqlCommand cmd = new SqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@NationalNo", NationalNo);

                try
                {
                    conn.Open();

                    ret = Convert.ToInt32( cmd.ExecuteScalar());

                }

                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }

                return ret != 0;
            }
        }
    }
}
