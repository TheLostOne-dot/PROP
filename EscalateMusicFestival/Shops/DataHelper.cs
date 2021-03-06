using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace Shops
{
    class DataHelper
    {
        public MySqlConnection connection;

        public DataHelper()
        {
            String connectionInfo = "server=localhost;" +//server
                                    "database=proptest;" +
                                    "user id=root;" +
                                    "password=;" +
                                    "connect timeout=30;";

            connection = new MySqlConnection(connectionInfo);
        }


        public double BalanceSelect(string eventid)
        {

            String sql = "SELECT Balance FROM visitor WHERE EventID = @eventid";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@eventid", eventid);
            double balance = 0;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    balance = Convert.ToDouble(reader["Balance"]);
                }
            }
            catch
            {
                
                balance = -1;
            }
            finally
            {
                connection.Close();
            }
            return balance;
        }

        public double PriceSelect(int itemid)
        {

            String sql = "SELECT Price FROM eventitem WHERE ItemID = @itemid";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@itemid", itemid);
            double price = 0;
            try
            {
                connection.Open();
                MySqlDataReader reader = command.ExecuteReader();


                while (reader.Read())
                {
                    price = Convert.ToDouble(reader["Price"]);
                }
            }
            catch
            {

                price = -1;
            }
            finally
            {
                connection.Close();
            }
            return price;
        }

        public int AddPurchasedItem(string eventid,int standid, int itemid)
        {

            String sql = "INSERT INTO purchaseditem (EventID,StandID,ItemID) VALUES (@eventid,@standid,@itemid)";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@eventid", eventid);
            command.Parameters.AddWithValue("@standid", standid);
            command.Parameters.AddWithValue("@itemid", itemid);
            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

        public int AddNewBalance(string eventid, double newbalance)
        {

            String sql = "UPDATE visitor SET Balance = @balance WHERE EventId = @eventid";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@balance", newbalance);
            command.Parameters.AddWithValue("@eventid", eventid);

            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;

            }
            catch
            {
                return -1;
            }
            finally
            {
                connection.Close();
            }
        }

    }

}

