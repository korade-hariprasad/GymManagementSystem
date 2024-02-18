using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Data;

//This class is used for all Database activities
namespace GYM_Management_System
{
    class DB
    {
        static string Address = "E:\\MyPro\\GYM Management System\\GYM_DB.mdb";
        static string constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + Address;
        OleDbConnection conn = new OleDbConnection(constr);
        OleDbCommand cmd;
        private OleDbDataReader dataReader;

        public void deleteUser(int ID) {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "DELETE * FROM Master WHERE ID="+ID+";";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "DELETE * FROM Transact WHERE ID=" + ID + ";";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }
        public void updateQ(int ID, string Name, string dt, string mail, string mob, string gender, string course, string dtstart, string dtend, int fees, string prd) {
            conn.Open();
            cmd = conn.CreateCommand();
            //"++"
            cmd.CommandText = "UPDATE Master SET uname='"+Name+ "', dob='"+dt+ "', email='"+mail+ "', mobile='"+mob+ "', gender='"+gender+ "', course='"+course+ "', startd='"+dtstart+ "', endd='"+dtend+ "', fees="+fees+ ", pass='"+prd+"' WHERE ID=" + ID+";";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            cmd.CommandText = "UPDATE Transact SET fees="+fees+" WHERE ID=" + ID + ";";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public List<string> getUserDetails(int ID) {
            List<string> list = new List<string>();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT [uname], [dob], [gender], [email], [mobile], [course], [startd], [endd], [fees] FROM Master WHERE ID="+ID+";";
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                for(int i=0; i<9; i++)
                list.Add(dataReader.GetValue(i).ToString());
            }
            dataReader.Close();
            conn.Close();
            return list;
        }
        public DataSet getAllUsers() {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT [ID], [uname] FROM Master;", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        public DataSet getUserTrans(int ID) {
            conn.Open();
            OleDbDataAdapter da = new OleDbDataAdapter("SELECT * FROM Transact WHERE ID="+ID+";", conn);
            DataSet ds = new DataSet();
            da.Fill(ds);
            conn.Close();
            return ds;
        }

        public string SelectPrd(string uid)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT pass FROM Master WHERE ID=" + int.Parse(uid) + ";";
            string prd = cmd.ExecuteScalar().ToString();
            conn.Close();
            return (prd);
        }

        public string SelectID(string Name, string prd)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT ID FROM Master WHERE uname='" + Name + "' AND pass='" + prd + "';";
            string id = cmd.ExecuteScalar().ToString();
            conn.Close();
            return(id);
        }

        public List<string> getIDlist()
        {
            List<string> list = new List<string>();
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "SELECT ID FROM Master";
            dataReader = cmd.ExecuteReader();
            while (dataReader.Read())
            {
                list.Add(dataReader.GetInt32(0).ToString());
            }
            dataReader.Close();
            conn.Close();
            return list;
        }

        public string getFees(string ID)
        {
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT [pending] FROM Transact WHERE ID="+int.Parse(ID)+";";
            ID = cmd.ExecuteScalar().ToString();
            conn.Close();
            return ID;
        }

        public string InsertQ(string Name, string dt, string mail, string mob, string gender, string course, string ed, int fees, string prd)
        {
            DateTime sd = DateTime.Now;
            string sd1 = sd.ToString().Split(' ')[0];
            conn.Open();
            cmd = conn.CreateCommand();
            cmd.CommandText = "INSERT INTO [Master](uname, dob, email, mobile, gender, course, startd, endd, fees, pass) VALUES('"+Name+"', '"+dt+"', '"+mail+"', '"+mob+"', '"+gender+"', '"+course+"', '"+sd1+"', '"+ed+"', '"+fees+"', '"+prd+"');";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            
            //this returns ID
            cmd.CommandType = System.Data.CommandType.Text;
            cmd.CommandText = "SELECT ID FROM Master WHERE uname='" + Name + "' AND pass='"+prd+"';";
            string id = cmd.ExecuteScalar().ToString();

            cmd.CommandText = "INSERT INTO [Transact] VALUES(" +id+", '" + Name + "', " + fees + ", 0, 0, 0);";
            cmd.Connection = conn;
            cmd.ExecuteNonQuery();
            conn.Close();

            return (id);
        }
    }
}
