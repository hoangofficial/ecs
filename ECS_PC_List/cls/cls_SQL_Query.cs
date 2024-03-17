using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using KAutoHelper;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using System.Data.SqlClient;

namespace ECS_PC_List.SQL_Class
{
    class cls_SQL_Query
    {
        public string selectAll(string table_name)
        {
            string sql = "SELECT * FROM " + table_name + " ORDER BY ID";
            return sql;
        }

        public string selectStatus(string table_name, string IDECS)
        {
            string sql = "SELECT TimeUpdate, History, Solution  FROM " + table_name + " WHERE IDECS =" + IDECS;
            return sql;
        }
        public string selectSolution(string table_name, string IDECS)
        {
            string sql = "SELECT Solution FROM " + table_name + " WHERE IDECS =" + IDECS;
            return sql;
        }
        public string location = "SELECT Location,Desc FROM Location_DB";

        public string select_location(string location)
        {
            string sql = "";
            if (location != "ALL")
            {
                sql = "SELECT * FROM ECS_db WHERE Location = '" + location + "' ORDER BY ID";
            }
                
            else
            {
                sql = "SELECT * FROM ECS_db ORDER BY ID";
            }

            return sql;
        }

        public string maxID()
        {
            string sql = "SELECT MAX ID FROM ECS_db";
            return sql;
        }
        public string search_load(string search)
        {    
            string sql = "SELECT * FROM ECS_db WHERE IP_Address LIKE '%" + search + "%' OR Phone LIKE '%" + search + "%'  OR EQP_Name LIKE '%" + search + "%'  OR EM_No" +
                " LIKE '%" + search + "%' ORDER BY ID";
            return sql;
        }

        public string insert()
        {
            string sql = "INSERT INTO ECS_db ([ID],[IP_Address], [ECS_Type], [Location], [Phone], [EQP_Name], [EM_No]) VALUES (@ID,@IP_Address,@ECS_Type,@Location,@Phone,@EQP_Name,@EM_No)";
            //string sql = "INSERT INTO ECS_db ([ID], [IP_Address], [ECS_Type], [Location], [Phone], [EQP_Name], [EM_No]) SELECT @ID, @IP_Address, @ECS_Type, @Location, @Phone, @EQP_Name, @EM_No FROM ECS_db WHERE [IP_Address] <> @IP_Address";
            //string sql = "INSERT INTO ECS_db ([ID], [IP_Address], [ECS_Type], [Location], [Phone], [EQP_Name], [EM_No]) SELECT DISTINCT * FROM ECS_db WHERE [IP_Address] <> @IP_Address";
            return sql;
        }
        public string insert_solution()
        {
            string sql = "INSERT INTO Solution_DB ([IDECS],[History], [Solution], [TimeUpdate]) VALUES (@IDECS,@History,@Solution,@TimeUpdate)";
            return sql;
        }

        public string delete(string ip)
        {
            string sql = "DELETE FROM ECS_db WHERE IP_Address = '" + ip + "'";
            return sql;
        }

        public string update()
        {
            //UPDATE ECS_db SET [IP_Address] = '@IP_Address', [ECS_Type] = '@ECS_Type', [Location] = '@Location', [Phone] = '@Phone', [EQP_Name] = '@EQP_Name', [EM_No] = '@EM_No' WHERE ID =893            
            string sql = "UPDATE ECS_db SET [IP_Address] = @IP_Address, [ECS_Type] = @ECS_Type, [Location] = @Location, [Phone] = @Phone, [EQP_Name] = @EQP_Name, [EM_No] = @EM_No WHERE [ID] = @ID";
            return sql;
        }
    }
}

//DCount ('*','ECS_db','ID <=' & y.ID)+1
