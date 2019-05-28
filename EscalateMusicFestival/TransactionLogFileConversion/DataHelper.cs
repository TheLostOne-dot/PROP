using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;
using System.IO;
using System.Windows.Forms;

namespace TransactionLogFileConversion
{
    class DataHelper
    {
        public MySqlConnection connection;
        string startdate;
        string enddate;
        string deposits;
        string eventID;
        string amount;
        List<string> rofl = new List<string>();
        public DataHelper()
        {
            String connectionInfo = "server=localhost;" +//the hera-server
                                    "database=proptest;" +
                                    "user id=root;" +
                                    "password=;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }

        public int Transaction(String filename)
        {
            
            FileStream fs = null;
            StreamReader sr = null;
            try
            {
                fs = new FileStream("transactions.txt", FileMode.Open, FileAccess.Read);
                sr = new StreamReader(fs);
                string eventID;
                string amount;

                //while (!sr.EndOfStream)
                //{
                startdate = sr.ReadLine();
                enddate = sr.ReadLine();
                deposits = sr.ReadLine();
                string line = sr.ReadLine();
                string[] linelist = line.Split(' ');
                eventID = linelist[0];
                amount = linelist[1];

                rofl.Add(startdate);
                rofl.Add(enddate);
                rofl.Add(deposits);
                rofl.Add(eventID);
                rofl.Add(amount);
                String sql = "UPDATE transaction SET Startdate =  @startdate, Enddate = @enddate, Deposits = @deposits, EventID = @eventid, Amount = @amount  ";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@startdate", startdate);
                command.Parameters.AddWithValue("@enddate", enddate);
                command.Parameters.AddWithValue("@deposits", deposits);
                command.Parameters.AddWithValue("@eventid", eventID);
                command.Parameters.AddWithValue("@amount", amount);

                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
                //}
                //String sql = "INSERT INTO visitor (EventID) VALUES (@eventid)";
                //MySqlCommand command = new MySqlCommand(sql, connection);
                return 1;
            }
            
            catch (IOException ex)
            {
                MessageBox.Show("something went wrong when reading file");
                return -1;
            }
            finally
            {
                if (sr != null) sr.Close();
                if (fs != null) fs.Close();
                connection.Close();
            }
        }
        public List<string> ReturnTransactionlog()
        {
            return rofl;
        }
    }
}
