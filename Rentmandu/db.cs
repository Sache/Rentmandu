using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;


namespace Rentmandu
{
    public class db
    {
        private static db instance = null;
        private static readonly object padlock = new object();

        public static db Instance
        {
            get
            {
                lock (padlock)
                {
                    if (instance == null)
                        instance = new db();

                    return instance;
                }
            }
        }

        private  static MySqlConnection GetConnection()
        {
            string server = Properties.Settings.Default.dbHost;
            string database = Properties.Settings.Default.dbName;
            string uid = Properties.Settings.Default.dbUsername;
            string password = Properties.Settings.Default.dbPassword;
            
            string connectionString = $"SERVER={server};DATABASE={database};UID={uid};PASSWORD={password};Allow User Variables=True;";
            MySqlConnection newCON = new MySqlConnection(connectionString);
            return newCON;
        }

        public bool LoginUser(string username, string password) // method to get username and password
        {
            bool login = false;
            MySqlConnection myConnection = GetConnection(); // get database path and connect to it
            string executeQueryStr = "SELECT * FROM tblUsers WHERE Username = '" + username + "' AND Password = '" + password + "'"; // SQL statement to get username and password fromt the database
            MySqlCommand dbCommand = new MySqlCommand(executeQueryStr, myConnection); // convert string into a OleDbCommand
            dbCommand.Connection = myConnection; // initalise connection
            try
            {
                myConnection.Open(); // open connection in database
                MySqlDataReader reader = dbCommand.ExecuteReader(); //  // 

                if (reader.HasRows)
                {
                    var test = reader.Read();
                    var test1 = reader.GetString(1).ToString(); // return second column
                    login = true;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Cannot Write Query To Database", ex); // run if there is exception, output in console
            }
            finally
            {

                myConnection.Close();
            }
            return login;
        }

        public string AddContact(string Name, Int64 Mobile, Int64 Landline, string Email, Int64 CitizenshipNo, string IssueDistrict, string IssueDate)
        {
            try
            {
                MySqlConnection myConnection = GetConnection();
                MySqlCommand dbCommand = new MySqlCommand();
                dbCommand.CommandText = "insert into tblcontacts (Name,Mobile,Landline,Email,CitizenshipNo,CZPIssueDistrict,CZPIssueDate) values (?,?,?,?,?,?,?)"; // command to instert trainlines
                dbCommand.Parameters.AddWithValue("@Name", Name);
                dbCommand.Parameters.AddWithValue("@Mobile", Mobile);
                dbCommand.Parameters.AddWithValue("@Landline", Landline);
                dbCommand.Parameters.AddWithValue("@Email", Email);
                dbCommand.Parameters.AddWithValue("@CitizenshipNo", CitizenshipNo);
                dbCommand.Parameters.AddWithValue("@CZPIssueDistrict", IssueDistrict);
                dbCommand.Parameters.AddWithValue("@CZPIssueDate", IssueDate);
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex )
            {
                return "ERROR: " + ex;
            }
            return "Contact successfully added.";
        }

        public string UpdateContact(int contactID, string Name, Int64 Mobile, Int64 Landline, string Email, Int64 CitizenshipNo, string IssueDistrict, string IssueDate)
        {
            try
            {
                MySqlConnection myConnection = GetConnection();
                MySqlCommand dbCommand = new MySqlCommand();
                dbCommand.CommandText = $"UPDATE tblcontacts SET Name = '{Name}', Mobile = '{Mobile}', Landline = '{Landline}', Email = '{Email}', CitizenshipNo = '{CitizenshipNo}', CZPIssueDistrict = '{IssueDistrict}', CZPIssueDate = '{IssueDate}'  WHERE ContactID = {contactID}"; // command to instert trainlines
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex;
            }
            return "Business details updated successfully.";
        }

        public DataTable PopulateContactsGridView(string Name = null)
        {
            MySqlConnection myConnection = GetConnection();
            string query = "SELECT * FROM tblcontacts ORDER BY ContactID DESC";
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                MySqlDataAdapter reader = new MySqlDataAdapter(command); //read data from the database
                DataTable dataTable = new DataTable();
                reader.Fill(dataTable);
                myConnection.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }

        public DataTable GetBusiness (int clientID)
        {
            MySqlConnection myConnection = GetConnection();
            string query = "SELECT * FROM tblbusiness  Where ClientID =" + clientID ;
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                MySqlDataAdapter reader = new MySqlDataAdapter(command); //read data from the database
                DataTable dataTable = new DataTable();
                reader.Fill(dataTable);
                myConnection.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }

        public DataTable GetContact(int contactid)
        {
            MySqlConnection myConnection = GetConnection();
            string query = "SELECT * FROM tblcontacts  Where ContactID =" + contactid;
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                MySqlDataAdapter reader = new MySqlDataAdapter(command); //read data from the database
                DataTable dataTable = new DataTable();
                reader.Fill(dataTable);
                myConnection.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }

        public string AddBusiness(string Name, string Type, Int64 Mobile, Int64 Landline, string Email, Int64 PAN)
        {
            try
            {
                MySqlConnection myConnection = GetConnection();
                MySqlCommand dbCommand = new MySqlCommand();
                dbCommand.CommandText = "insert into tblbusiness (Name,Type,Mobile,Landline,Email,PAN) values (?,?,?,?,?,?)"; // command to instert trainlines
                dbCommand.Parameters.AddWithValue("@Name", Name);
                dbCommand.Parameters.AddWithValue("@Type", Type);
                dbCommand.Parameters.AddWithValue("@Mobile", Mobile);
                dbCommand.Parameters.AddWithValue("@Landline", Landline);
                dbCommand.Parameters.AddWithValue("@Email", Email);
                dbCommand.Parameters.AddWithValue("@PAN", PAN);
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex;
            }
            return "Contact successfully added.";
        }

        public string UpdateBusiness(int ClientID, string Name, string Type, Int64 Mobile, Int64 Landline, string Email, Int64 PAN)
        {
            try
            {
                MySqlConnection myConnection = GetConnection();
                MySqlCommand dbCommand = new MySqlCommand();
                dbCommand.CommandText = $"UPDATE tblbusiness SET Name = '{Name}', Type = '{Type}', Mobile = '{Mobile}', Landline = '{Landline}', Email = '{Email}', PAN = '{PAN}' WHERE ClientID = {ClientID}"; // command to instert trainlines
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex;
            }
            return "Business details updated successfully.";
        }


        public string DeleteBusiness(int ClientID)
        {
            try
            {
                MySqlConnection myConnection = GetConnection();
                MySqlCommand dbCommand = new MySqlCommand();
                dbCommand.CommandText = $"DELETE FROM tblbusiness WHERE ClientID = {ClientID}"; // command to instert trainlines
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex;
            }
            return "Business deleted successfully.";
        }

        public string DeleteContact(int ContactID)
        {
            try
            {
                MySqlConnection myConnection = GetConnection();
                MySqlCommand dbCommand = new MySqlCommand();
                dbCommand.CommandText = $"DELETE FROM tblcontacts WHERE ContactID = {ContactID}"; // command to instert trainlines
                dbCommand.Connection = myConnection;
                myConnection.Open();
                dbCommand.ExecuteNonQuery();
                myConnection.Close();
            }
            catch (Exception ex)
            {
                return "ERROR: " + ex;
            }
            return "Contact deleted successfully.";
        }



        public DataTable PopulateBusinessGridView()
        {
            MySqlConnection myConnection = GetConnection();
            string query = "SELECT * FROM tblbusiness ORDER BY ClientID DESC";
            MySqlCommand command = new MySqlCommand(query, myConnection);
            command.Connection = myConnection;
            try
            {
                myConnection.Open();
                MySqlDataAdapter reader = new MySqlDataAdapter(command); //read data from the database
                DataTable dataTable = new DataTable();
                reader.Fill(dataTable);
                myConnection.Close();
                return dataTable;
            }
            catch (Exception e)
            {
                Console.WriteLine("Error:" + e);
            }
            return null;
        }
    }
}
