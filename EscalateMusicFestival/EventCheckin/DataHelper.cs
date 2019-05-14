using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data;
using MySql.Data.MySqlClient;

namespace EventCheckin
{
    class DataHelper
    {
            public MySqlConnection connection;

            public DataHelper()
            {
                String connectionInfo = "server=localhost;" +//the hera-server
                                        "database=proptest;" +
                                        "user id=root;" +
                                        "password= ;" +
                                        "connect timeout=30;";

                connection = new MySqlConnection(connectionInfo);
            }


          /*  public List<Visitor> GetAllVisitors()
            {
               String sql = "SELECT * FROM Visitor";
                MySqlCommand command = new MySqlCommand(sql, connection);

                List<Visitor> temp;
                temp = new List<Visitor>();

                try
                {
                    connection.Open();
                    MySqlDataReader reader = command.ExecuteReader();

                    String name;
                    int nr;
                    int cr;
                    while (reader.Read())
                    {
                        name = Convert.ToString(reader["Visitorname"]);
                        nr = Convert.ToInt32(reader["Visitornumber"]);
                        cr = Convert.ToInt32(reader["NrOfCredits"]);
                        temp.Add(new Visitor(nr, name, cr));
                    }
                }
                catch
                {
                    MessageBox.Show("error while loading the Visitors");
                }
                finally
                {
                    connection.Close();
                }
                return temp; 
            } */

      /*      public int AddVisitor(int number, string name, int creditpoints)
            {  

                String sql = "INSERT INTO Visitor VALUES (@name, @number, @cp)";
                MySqlCommand command = new MySqlCommand(sql, connection);
                command.Parameters.AddWithValue("@name", name);
                command.Parameters.AddWithValue("@number", number);
                command.Parameters.AddWithValue("@cp", creditpoints);


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
            } */

        public int AddNewVisitorID(string oldeventid, string neweventid)
        {

            String sql = "UPDATE Visitor SET EventId = @oldeventid, CheckedIn = @checkedin Where EventId = @neweventid";
            MySqlCommand command = new MySqlCommand(sql, connection);
            command.Parameters.AddWithValue("@oldeventid", oldeventid);
            command.Parameters.AddWithValue("@neweventid", neweventid);
            command.Parameters.AddWithValue("@checkedin", "Yes");
            try
            {
                connection.Open();
                int nrOfRecordsChanged = command.ExecuteNonQuery();
                return nrOfRecordsChanged;
               // return 0;
               
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

        /*   public int RemoveVisitor(int number, string name, int creditpoints)
           {
               if (number != 0 && name == "" & creditpoints == 0)
               {
                   String sql = "DELETE FROM Visitor WHERE Visitornumber = @number";
                   MySqlCommand command = new MySqlCommand(sql, connection);
                   //  command.Parameters.AddWithValue("@name", name);
                   command.Parameters.AddWithValue("@number", number);
                   //   command.Parameters.AddWithValue("@cp", creditpoints);

                   try
                   {
                       connection.Open();
                       int nrOfRecordsDeleted = command.ExecuteNonQuery();
                       return nrOfRecordsDeleted;
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
               else if (number == 0 && name != "" & creditpoints == 0)
               {
                   String sql = "DELETE FROM Visitor WHERE Visitorname = @name";
                   MySqlCommand command = new MySqlCommand(sql, connection);
                   command.Parameters.AddWithValue("@name", name);
                   //  command.Parameters.AddWithValue("@number", number);
                   //  command.Parameters.AddWithValue("@cp", creditpoints);
                   try
                   {
                       connection.Open();
                       int nrOfRecordsDeleted = command.ExecuteNonQuery();
                       return nrOfRecordsDeleted;
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
               else if (number == 0 && name == "" & creditpoints != 0)
               {
                   String sql = "DELETE FROM Visitor WHERE NrOfCredits = @cp";
                   MySqlCommand command = new MySqlCommand(sql, connection);
                   // command.Parameters.AddWithValue("@name", name);
                   //    command.Parameters.AddWithValue("@number", number);
                   command.Parameters.AddWithValue("@cp", creditpoints);

                   try
                   {
                       connection.Open();
                       int nrOfRecordsDeleted = command.ExecuteNonQuery();
                       return nrOfRecordsDeleted;
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
               else
               {
                   return -1;
               }




           }

         /*  public int NumberOfVisitors()
           {
               String sql = "SELECT COUNT(*) FROM Visitor";
               MySqlCommand command = new MySqlCommand(sql, connection);
               int number = 0;
               try
               {
                   connection.Open();
                   number = Convert.ToInt32(command.ExecuteScalar());
                   return number;
               }
               catch
               {
                   return -1;

               }
               finally
               {
                   connection.Close();
               } 
           } */
    }
    }