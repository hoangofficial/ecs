using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;

namespace ECS_PC_List.SQL_Class
{
    class cls_KetNoi
    {
        public OleDbConnection con = new OleDbConnection();
        string ChuoiKetNoi = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=ECS_db.mdb";
        public bool KetNoi()
        {
            try
            {
                con = new OleDbConnection(ChuoiKetNoi);
                con.Open();
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Loi: " + ex.ToString());
                return false;
            }

        }
        public void DongKetNoi()
        {
            con.Close();
        }
    }
}
