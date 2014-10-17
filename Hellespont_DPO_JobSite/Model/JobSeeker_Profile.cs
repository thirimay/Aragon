using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;

namespace Hellespont_DPO_JobSite.Model
{
    public class JobSeeker_Profile
    {
        #region private data variable
        private string User_ID;
        private string First_Name;
        private string Last_Name;
        private int Nationality;
        private int Race;
        private int Gender;
        private int Marital_Status;
        private DateTime DOB;
        private int Religion;
        private int Location;
        private string Address1;
        private string Address2;
        private string Postal_Code;
        private string Contact_No;
        private DBConnection myconnection;
        #endregion

        #region get,set data
        public string userID
        {
            get { return User_ID; }
            set { User_ID= value; }
        }

        public string firstName
        {
            get { return First_Name; }
            set { First_Name = value; }
        }

        public string lastName
        {
            get { return Last_Name; }
            set { Last_Name = value; }
        }
        
        public int nationality
        {
            get { return Nationality; }
            set { Nationality = value; }
        }

        public int race
        {
            get { return Race; }
            set { Race = value; }
        }
        public int gender
        {
            get { return Gender; }
            set { Gender = value; }
        }       

        public int maritalStatus
        {
            get { return Marital_Status; }
            set { Marital_Status = value; }
        }
        public int religion
        {
            get { return Religion; }
            set { Religion = value; }
        }
        public DateTime dob
        {
            get { return DOB; }
            set { DOB = value; }
        }
        public int location
        {
            get { return Location; }
            set { Location = value; }
        }
        public string adress1
        {
            get { return Address1; }
            set { Address1 = value; }
        }

        public string adress2
        {
            get { return Address2; }
            set { Address2 = value; }
        }
        public string postalCode
        {
            get { return Postal_Code; }
            set { Postal_Code = value; }
        }
        public string contactNo
        {
            get { return Contact_No; }
            set { Contact_No = value; }
        }
        #endregion

        #region constructor
        public JobSeeker_Profile()
        {

        }
        #endregion

        #region CRUD Operation
        public DataTable getallProfile()
        {
            string getcmdstr = "SELECT * FROM JobSeeker_Profile";
            SqlCommand getcmd = myconnection.SqlCom(getcmdstr);
            DataTable gettb = myconnection.DataTB(getcmd);
            return gettb;
            
        }

        public DataTable getProfilewithUserID(string userId)
        {
            string getcmdstr = "SELECT * FROM JobSeeker_Profile Where UserId=@userid";
            SqlCommand getcmd = myconnection.SqlCom(getcmdstr);
            getcmd.Parameters.AddWithValue("@userid", userId);
            DataTable gettb = myconnection.DataTB(getcmd);
            return gettb;
        }

        public bool insertProfile()
        {
            string insertcmd = "INSERT JobSeeker_Profile(UserId,First_name,Last_name,Nationality,Gender,DOB,Marital_status,Race,Religion,Location,Address1,Address2,Postal_code,Contact_no)";
            insertcmd += "VALUES(@uid,@fname,@lname,@nationality,@gender,@dob,@mstatus,@race,@religion,@location,@address1,@address2,@pcode,@cno)";
            SqlCommand insertcom = myconnection.SqlCom(insertcmd);
            insertcom.Parameters.AddWithValue("@uid", this.userID);
            insertcom.Parameters.AddWithValue("@fname", this.firstName);
            insertcom.Parameters.AddWithValue("@lname", this.lastName);
            insertcom.Parameters.AddWithValue("@nationality", this.nationality);
            insertcom.Parameters.AddWithValue("@gender", this.gender);
            insertcom.Parameters.AddWithValue("@dob", this.dob);
            insertcom.Parameters.AddWithValue("@mstatus", this.maritalStatus);
            insertcom.Parameters.AddWithValue("@race", this.race);
            insertcom.Parameters.AddWithValue("@religion", this.religion);
            insertcom.Parameters.AddWithValue("@location", this.location);
            insertcom.Parameters.AddWithValue("@address1", this.adress1);
            insertcom.Parameters.AddWithValue("@address2", this.adress2);
            insertcom.Parameters.AddWithValue("@pcode", this.postalCode);
            insertcom.Parameters.AddWithValue("@cno", this.contactNo);
            bool result = myconnection.executecommand(insertcom);
            return result;
        }

        public bool updateProfile()
        {
            string updatecmd = "UPDATE JobSeeker_Profile Set(UserId=@uid,First_name=@fname,Last_name=@lname,Nationality=@nationality,";
            updatecmd += "Gender=@gender,DOB=@dob,Marital_status=@mstatus,Race=@race,Religion=@religion,Location=@location,Address1=@address1,";
            updatecmd+="Address2=@address2,Postal_code=@pcode,Contact_no=@cno)";           
            SqlCommand updatecom = myconnection.SqlCom(updatecmd);
            updatecom.Parameters.AddWithValue("@uid", this.userID);
            updatecom.Parameters.AddWithValue("@fname", this.firstName);
            updatecom.Parameters.AddWithValue("@lname", this.lastName);
            updatecom.Parameters.AddWithValue("@nationality", this.nationality);
            updatecom.Parameters.AddWithValue("@gender", this.gender);
            updatecom.Parameters.AddWithValue("@dob", this.dob);
            updatecom.Parameters.AddWithValue("@mstatus", this.maritalStatus);
            updatecom.Parameters.AddWithValue("@race", this.race);
            updatecom.Parameters.AddWithValue("@religion", this.religion);
            updatecom.Parameters.AddWithValue("@location", this.location);
            updatecom.Parameters.AddWithValue("@address1", this.adress1);
            updatecom.Parameters.AddWithValue("@address2", this.adress2);
            updatecom.Parameters.AddWithValue("@pcode", this.postalCode);
            updatecom.Parameters.AddWithValue("@cno", this.contactNo);
            bool result = myconnection.executecommand(updatecom);
            return result;
        }

        public bool deleteProfile()
        {
            string deletecmd = "DELETE FROM JobSeeker_Profile WHERE UserId=@userID";
            SqlCommand deletecom = myconnection.SqlCom(deletecmd);
            deletecom.Parameters.Add("@userID", this.userID );
            bool result = myconnection.executecommand(deletecom);
            return result;          
        }
        #endregion
    }
    public enum Religion
    {
        Buddhist=1,
        Christian=2,
        Islam=3,
        Hindu=4,
        Other=5
    };
    public enum Marital_Status
    {
        Single=1,
        Married=2,
        Widowed=3,
        Separated=4,
        Divorced=5,
        not reported=6
    }
}