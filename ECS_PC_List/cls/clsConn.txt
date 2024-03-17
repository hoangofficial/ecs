using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Windows.Forms;


namespace ECS_PC_List.cls
{
    public class clsConn

    {
        private string connectionString;
        private OleDbConnection connection;

        public clsConn(string dbPath)
        {
            // Chuỗi kết nối tới file Microsoft Access
            connectionString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + dbPath;
            connection = new OleDbConnection(connectionString);
        }
        public DataTable GetDataFromTable(string tableName)
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Mở kết nối
                connection.Open();

                // Tạo câu truy vấn để lấy dữ liệu từ bảng
                string query = "SELECT * FROM " + tableName;

                // Tạo đối tượng DataAdapter để đọc dữ liệu từ cơ sở dữ liệu vào DataTable
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);

                // Đổ dữ liệu vào DataTable
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi hoàn thành công việc
                connection.Close();
            }

            return dataTable;
        }

        public DataTable GetDataFromTable_Location(string tableName,string location)
        {
            DataTable dataTable = new DataTable();
            try
            {
                // Mở kết nối
                connection.Open();
                string query = "";

                // Tạo câu truy vấn để lấy dữ liệu từ bảng
                if (location != "ALL")
                {
                   query = "SELECT * FROM " + tableName + " WHERE Location = " + "'" + location + "'";
                }
               else
                {
                    query = "SELECT * FROM " + tableName;
                }

                // Tạo đối tượng DataAdapter để đọc dữ liệu từ cơ sở dữ liệu vào DataTable
                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(query, connection);

                // Đổ dữ liệu vào DataTable
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc dữ liệu: " + ex.Message);
            }
            finally
            {
                // Đóng kết nối sau khi hoàn thành công việc
                connection.Close();
            }

            return dataTable;
        }

        // Thực thi câu lệnh SQL trả về số lượng hàng bị ảnh hưởng (INSERT, UPDATE, DELETE)
        public int ExecuteNonQuery(string sqlQuery)
        {
            int affectedRows = 0;

            try
            {
                connection.Open();

                OleDbCommand command = new OleDbCommand(sqlQuery, connection);
                affectedRows = command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi nếu cần thiết
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return affectedRows;
        }

        // Thực thi câu lệnh SQL trả về dữ liệu (SELECT)
        public DataTable ExecuteQuery(string sqlQuery)
        {
            DataTable dataTable = new DataTable();

            try
            {
                connection.Open();

                OleDbDataAdapter dataAdapter = new OleDbDataAdapter(sqlQuery, connection);
                dataAdapter.Fill(dataTable);
            }
            catch (Exception ex)
            {
                // Xử lý các lỗi nếu cần thiết
                Console.WriteLine("Error executing query: " + ex.Message);
            }
            finally
            {
                connection.Close();
            }

            return dataTable;
        }
    }

}


