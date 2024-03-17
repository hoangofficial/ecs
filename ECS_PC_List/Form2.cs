using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Diagnostics;
using System.Threading;
using System.Runtime.InteropServices;
using System.Text.RegularExpressions;
using KAutoHelper;
using ECS_PC_List.cls;

namespace ECS_PC_List
{
    public partial class frmAdd : Form
    {        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public frmAdd()
        {
            InitializeComponent();
        }
        SQL_Class.clsCRUD cls = new SQL_Class.clsCRUD();
        SQL_Class.cls_SQL_Query query = new SQL_Class.cls_SQL_Query();
        public string ID ="", IP_Address = "", ECS_Type = "", Locat = "", Phone = "", EQP_Name = "", EM_No = "";

        private void frmAdd_Load(object sender, EventArgs e)
        {

        }

        private void btnApply_Click(object sender, EventArgs e)
        {
            ID = "";
            IP_Address = txtIP.Text;
            ECS_Type = cbECS_Type.Text;
            Locat = txtLocation.Text;
            Phone = txtPhone.Text;
            EQP_Name = txtEQP_Name.Text;
            EM_No = txtEM_No.Text;         
            cls.add_new("insert", query.insert(),ID, IP_Address, ECS_Type, Locat, Phone, EQP_Name, EM_No);
            (System.Windows.Forms.Application.OpenForms["Form1"] as Form1).LoadData_ECSMachine();
            this.Close();
        }
    }
}
