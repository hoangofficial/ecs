using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Data;


namespace ECS_PC_List.SQL_Class
{
    class clsCRUD
    {
        public DataTable getData(string sql)
        {
            cls_KetNoi cn = new cls_KetNoi();
            cn.KetNoi();
            DataSet ds = new DataSet();
            try
            {
                OleDbDataAdapter dta = new OleDbDataAdapter(sql, cn.con);
                dta.Fill(ds, sql);
                DataTable tbl = ds.Tables[0];                
                if (tbl.Rows.Count != 0)
                    return tbl;
                else
                    return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return null;
            }
        }       
        public bool Them_sua_xoa(string sql)
        {
            cls_KetNoi cn = new cls_KetNoi();
            try
            {
                cn.KetNoi();
                OleDbCommand cmd = new OleDbCommand(sql, cn.con);
                //MessageBox.Show(sql);
                cmd.ExecuteNonQuery();
                cn.DongKetNoi();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return false;

            }

        }
        public static string maxID()
        {
            cls_KetNoi cn = new cls_KetNoi();
            cn.KetNoi();
            string maxID = "";
            string query = "SELECT MAX (ID) AS ID FROM ECS_db";
            OleDbCommand cmd = new OleDbCommand(query, cn.con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                maxID = rdr["ID"].ToString();
            }
            return maxID;
        }

        public static bool check_IP_exist(string IP)
        {
            cls_KetNoi cn = new cls_KetNoi();
            cn.KetNoi();
            string IP_1 = null;
            string query = "SELECT IP_Address FROM ECS_db WHERE IP_Address = '"+IP+"'";            
            OleDbCommand cmd = new OleDbCommand(query, cn.con);
            OleDbDataReader rdr = cmd.ExecuteReader();
            while (rdr.Read())
            {
                IP_1 = rdr["IP_Address"].ToString();
            }
            if (IP_1 == null)
                return true;
            else
                return false;
        }
        public string getHistory(string query)
        {
            cls_KetNoi cn = new cls_KetNoi();
            cn.KetNoi();
            string history = "";
            //string query = "SELECT MAX (ID) AS ID FROM ECS_db";
            OleDbCommand cmd = new OleDbCommand(query, cn.con);
            OleDbDataReader rdr = cmd.ExecuteReader();
          
            while (rdr.Read())
            {
                history += rdr["TimeUpdate"].ToString() + "\r\n" +"- History:     "+ rdr["History"].ToString() + "\r\n\r\n" + "- Solution:   " + rdr["Solution"].ToString() + "\r\n"+"=================================================\r\n";                
            }
            cn.DongKetNoi();
            return history;
        }
        public string getSolution(string query)
        {
            cls_KetNoi cn = new cls_KetNoi();
            cn.KetNoi();
            string solution = "";
            //string query = "SELECT MAX (ID) AS ID FROM ECS_db";
            OleDbCommand cmd = new OleDbCommand(query, cn.con);
            OleDbDataReader rdr = cmd.ExecuteReader();

            while (rdr.Read())
            {
                //MessageBox.Show(rdr.ToString());
                solution += rdr["Solution"].ToString() + "\r\n";
                //break;
            }
            cn.DongKetNoi();
            return solution;
        }
        public bool add_Solution(string tt, string sql, string IDECS, string History, string Solution, string TimeUpdate)
        {
            cls_KetNoi cn = new cls_KetNoi();
            try
            {                
                cn.KetNoi();
                OleDbCommand cmd = new OleDbCommand(sql, cn.con);

                if (tt == "insert")
                {                    
                    cmd.Parameters.Add("@IDECS", OleDbType.VarChar).Value = IDECS;
                    cmd.Parameters.Add("@History", OleDbType.VarChar).Value = History;
                    cmd.Parameters.Add("@Solution", OleDbType.VarChar).Value = Solution;
                    cmd.Parameters.Add("@TimeUpdate", OleDbType.VarChar).Value = TimeUpdate;
                }               
                //MessageBox.Show(cmd.Parameters.ToString());
                cmd.ExecuteNonQuery();
                cn.DongKetNoi();
                MessageBox.Show("Add Successfully!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Failed!" + ex.ToString());
                return false;

            }
        }
        public bool add_new(string tt, string sql, string ID, string IP_Address, string ECS_Type, string Location, string Phone, string EQP_Name, string EM_No)
        {
            cls_KetNoi cn = new cls_KetNoi();
            try
            {
                int maxID_1 = int.Parse(maxID());
                cn.KetNoi();
                OleDbCommand cmd = new OleDbCommand(sql, cn.con);

                if (tt == "insert")
                {                    
                    if (check_IP_exist(IP_Address) == false)
                    {
                        
                        MessageBox.Show("IP da ton tai");
                        return false;
                    }
                    else
                    {
                        cmd.Parameters.Add("@ID", OleDbType.VarChar).Value = maxID_1 + 1;
                        cmd.Parameters.Add("@IP_Address", OleDbType.VarChar).Value = IP_Address;
                        cmd.Parameters.Add("@ECS_Type", OleDbType.VarChar).Value = ECS_Type;
                        cmd.Parameters.Add("@Location", OleDbType.VarChar).Value = Location;
                        cmd.Parameters.Add("@Phone", OleDbType.VarChar).Value = Phone;
                        cmd.Parameters.Add("@EQP_Name", OleDbType.VarChar).Value = EQP_Name;
                        cmd.Parameters.Add("@EM_No", OleDbType.VarChar).Value = EM_No;
                    }
                }
                else
                {
                    cmd.Parameters.Add("@IP_Address", OleDbType.VarChar).Value = IP_Address;
                    cmd.Parameters.Add("@ECS_Type", OleDbType.VarChar).Value = ECS_Type;
                    cmd.Parameters.Add("@Location", OleDbType.VarChar).Value = Location;
                    cmd.Parameters.Add("@Phone", OleDbType.VarChar).Value = Phone;
                    cmd.Parameters.Add("@EQP_Name", OleDbType.VarChar).Value = EQP_Name;
                    cmd.Parameters.Add("@EM_No", OleDbType.VarChar).Value = EM_No;
                    cmd.Parameters.Add("@ID", OleDbType.VarChar).Value = maxID_1;

                }
                //MessageBox.Show(cmd.Parameters.ToString());
                cmd.ExecuteNonQuery();
                cn.DongKetNoi();
                MessageBox.Show("Add Successfully!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Add Failed!" + ex.ToString());
                return false;

            }
        }

        public bool update(string tt, string sql, string ID, string IP_Address, string ECS_Type, string Location, string Phone, string EQP_Name, string EM_No)
        {
            cls_KetNoi cn = new cls_KetNoi();
            try
            {
                //int maxID_1 = int.Parse(maxID());
                cn.KetNoi();
                OleDbCommand cmd = new OleDbCommand(sql, cn.con);

                if (tt == "update")
                {
                    cmd.Parameters.Add("@IP_Address", OleDbType.VarChar).Value = IP_Address;
                    cmd.Parameters.Add("@ECS_Type", OleDbType.VarChar).Value = ECS_Type;
                    cmd.Parameters.Add("@Location", OleDbType.VarChar).Value = Location;
                    cmd.Parameters.Add("@Phone", OleDbType.VarChar).Value = Phone;
                    cmd.Parameters.Add("@EQP_Name", OleDbType.VarChar).Value = EQP_Name;
                    cmd.Parameters.Add("@EM_No", OleDbType.VarChar).Value = EM_No;
                    cmd.Parameters.Add("@ID", OleDbType.VarChar).Value = ID;
                }

                //MessageBox.Show(cmd.Parameters.ToString());
                cmd.ExecuteNonQuery();
                cn.DongKetNoi();
                MessageBox.Show("Update Successfully!");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Update Failed!" + ex.ToString());
                return false;

            }
        }
       
    }
}
