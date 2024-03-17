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
using System.Net.NetworkInformation;
using ECS_PC_List.cls;
using System.IO;
using Microsoft.Office.Interop.Excel;
using app = Microsoft.Office.Interop.Excel.Application;


namespace ECS_PC_List
{
    public partial class Form1 : Form
    {
        [DllImport("user32.dll")]
        static extern bool ShowWindow(IntPtr hWnd, int nCmdShow);
        private const int SW_SHOWMAXIMIZED = 3;

        SQL_Class.clsCRUD cls = new SQL_Class.clsCRUD();
        SQL_Class.cls_SQL_Query query = new SQL_Class.cls_SQL_Query();
        public int target = -1;

        public Form1()
        {
            InitializeComponent();
            //btnUpdate.Enabled = false;
            startTime = DateTime.Now;
            timer2.Enabled = true;
            System.Windows.Forms.Timer tm = new System.Windows.Forms.Timer();
            tm.Interval = 1000;
            tm.Tick += timer3_Tick;
            tm.Start();
        }
        private DateTime startTime;
        public void LoadData_ECSMachine()
        {
            dataGridView1.DataSource = cls.getData(query.selectAll("ECS_db"));           
            for (int i = 0; i < dataGridView1.ColumnCount; i++)
            {
                dataGridView1.AutoResizeColumn(i, DataGridViewAutoSizeColumnMode.DisplayedCells);
                this.dataGridView1.Columns[7].Width = 100;
                dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Sunken;                
            }
            LoadHis();
        }
        public void LoadHis()
        {
            ip = dataGridView1[1, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
            txtStatusHis.Text = cls.getHistory(query.selectStatus("Solution_DB", ip));
        }

        private void LoadDataToComboBox()                
        {
            comboBox1.DataSource = cls.getData(query.location);
            comboBox1.DisplayMember = "Desc";
            comboBox1.ValueMember = "Location";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dataSet1.ECS_db1' table. You can move, or remove it, as needed.            
            LoadDataToComboBox();
            LoadData_ECSMachine();            
        }
             
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string location = comboBox1.SelectedValue.ToString();            
            dataGridView1.DataSource = cls.getData(query.select_location(location));          

        }
        public void StartRadmin(string agg, string ip, string ecstype, string machineName)
        {
            Process p = new Process();
            ip = ip.Trim();
            p.StartInfo.FileName = @"C:\Program Files (x86)\Radmin Viewer 3\Radmin.exe";
            p.StartInfo.Arguments = "/connect:" + ip + agg;
            p.Start();
            IntPtr hWnd = IntPtr.Zero;
            int count = 0;

            while (hWnd == IntPtr.Zero)
            {
                count++;
                hWnd = AutoControl.FindWindowHandle(null, "Radmin security: " + ip);
                if (count > 30000)
                {
                    p.Kill();
                    MessageBox.Show("IP Timeout!");
                    this.BringToFront();
                    return;
                }
            }

            List<IntPtr> hw;
            hw = AutoControl.GetChildHandle(hWnd);
            count = 0;
            if (dataGridView1[3, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() == "Panel ECS")
            {
                AutoControl.SendText(hw[0], "ecs");
                AutoControl.SendText(hw[2], "ecS.123!");
            }
            else if (dataGridView1[3, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() == "Module ECS")
            {
                AutoControl.SendText(hw[0], "ecs");
                AutoControl.SendText(hw[2], "ecS.123!");
            }
            else if (dataGridView1[3, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() == "Cell Tech")
            {
                AutoControl.SendText(hw[0], "CellTech");
                AutoControl.SendText(hw[2], "123456");
            }
            else if (dataGridView1[3, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() == "MCS")
            {
                AutoControl.SendText(hw[0], "mcs");
                AutoControl.SendText(hw[2], "Mcs222#$");
            }
            else
            {
                AutoControl.SendText(hw[0], "Engineer");
                AutoControl.SendText(hw[2], "Lgd#2021");

            }
            int ControlTag = 2;
            AutoControl.SendKeyPress(KeyCode.ENTER);
            Thread.Sleep(1000);
            AutoControl.SendKeyPress(KeyCode.F12);
            AutoControl.SendKeyPress(KeyCode.F12);
            if ((int)(hWnd = AutoControl.FindWindowHandle(null, ip + " - View Only")) > 0)
            {
                ControlTag = 0;

            }
            else if ((int)(hWnd = AutoControl.FindWindowHandle(null, ip + " - Full Control")) > 0)
            {

                ControlTag = 1;
            }
            else if ((int)(hWnd = AutoControl.FindWindowHandle(null, ip + " - File Transfer")) > 0)
            {

                ControlTag = 2;
            }
            //MessageBox.Show(hWnd.ToString());
            //MessageBox.Show(hWnd + "  " + ControlTag.ToString());
            if (ControlTag < 2)
            {
                Thread.Sleep(500);
                ShowWindow(hWnd, SW_SHOWMAXIMIZED);

                if (ControlTag == 0)
                {
                    AutoControl.SendText(hWnd, machineName + " - " + ip + " - View Only");
                }
                if (ControlTag == 1)
                {
                    AutoControl.SendText(hWnd, machineName + " - " + ip + " - Full Control");
                }
            }


            if (ControlTag == 2)
            {
                AutoControl.SendText(hWnd, machineName + " - " + ip + " - File Transfer");
            }

        }
        string ip = "";
        private void btnFullControl_Click(object sender, EventArgs e)
        {
            string LoaiECS = "";
            string tenmay = "";
            ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
            StartRadmin("", ip, LoaiECS, tenmay);
        }
        private void btnViewOnly_Click(object sender, EventArgs e)
        {
            string LoaiECS = "";
            string tenmay = "";
            ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
            StartRadmin(" /noinput ", ip, LoaiECS, tenmay);
        }

        private void btnTransfer_Click(object sender, EventArgs e)
        {
            string LoaiECS = "";
            string tenmay = "";
            ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
            StartRadmin(" /file ", ip, LoaiECS, tenmay);
        }
       

        private void btnPingt_Click(object sender, EventArgs e)
        {
            ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
            string strCmdText;
            strCmdText = "/C ping -t ";

            string strPing = strCmdText + ip;
            Process.Start("CMD.exe", strPing);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnKillRadmin_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to kill Radmin?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
                string strCmdText;
                strCmdText = @"cmd /c sc \\";

                string strStop = strCmdText + ip + " stop rserver3";
                string strStart = strCmdText + ip + " start rserver3";
                Process.Start("powershell.exe", strStop);

                Thread.Sleep(21000);
                Process.Start("powershell.exe", strStart);
            }           
            //MessageBox.Show(strStop);
        }
      
        private void btnExplorer_Click(object sender, EventArgs e)
        {
            ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
            string strCmdText;
            strCmdText = @"\\";

            string strPing = strCmdText + ip;
            Process.Start("explorer.exe", strPing);
            Process.Start((System.IO.Directory.GetCurrentDirectory() + @"\admin.exe"));
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string search = txtSearch.Text;
            if(cls.getData(query.search_load(search)) != null)
            {
                dataGridView1.DataSource = cls.getData(query.search_load(search));
            }
            else
            {                
                MessageBox.Show("404 not found");
                //LoadData_ECSMachine();
            }
            LoadHis();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmAdd f2 = new frmAdd();
            f2.Show();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";            
            //btnUpdate.Enabled = false;
            txtSolution.Text = "";
            txtStatusHis.Text = "";
            LoadData_ECSMachine();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to delete this PC?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
                cls.Them_sua_xoa(query.delete(ip));
                MessageBox.Show("Delete Completed");
                LoadData_ECSMachine();
            }
            string search = txtSearch.Text;
            dataGridView1.DataSource = cls.getData(query.search_load(search));
        }

        private void btnRemoteDesktop_Click(object sender, EventArgs e)
        {
            ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
            string strCmdText;
            strCmdText = @"/public /v:";

            string strPing = strCmdText + ip;
            Process.Start("mstsc.exe", strPing);
            Process.Start((System.IO.Directory.GetCurrentDirectory() + @"\admin.exe"));
        }              
        private void btnRestartPC_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Do you want to restart this PC?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                ip = dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
                string strCmdText;
                strCmdText = @"shutdown /r /f /m \\";

                string strPing = strCmdText + ip;
                Process.Start("powershell.exe", strPing);
            }            
        }
        public string ID = "", IP_Address = "", ECS_Type = "", Locat = "", Phone = "", EQP_Name = "", EM_No = "";
       
        private void btnfindCSR_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.Show();
        }

        private void btnerrLog_Click(object sender, EventArgs e)
        {
            frmLogChecker f4 = new frmLogChecker();
            f4.Show();
        }
        //private void fileP(string[] filePaths)
        //{            
        //    dataGridView2.Rows.Clear();
        //    int exist = 0;
        //    foreach (string filePath in filePaths)
        //    {
        //        if (File.Exists(filePath))
        //        {
        //            exist = 1;
        //            try
        //            {
        //                string[] lines = File.ReadAllLines(filePath);
        //                foreach (string line in lines)
        //                {
        //                    if (line.Contains("=-1"))
        //                    {
        //                        dataGridView2.Rows.Add(line);
        //                        dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //                        dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        //                        dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //                    }
        //                }
        //            }
        //            catch (Exception ex)
        //            {
        //                MessageBox.Show("Error reading log file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);                        
        //            }
        //        }
        //        //else
        //        //{
        //        //    MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //        //}
        //    }
        //    if(exist == 0)
        //    {
        //        MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    }
        //}
        //private void LoadLogButton_Click(object sender, EventArgs e)
        //{
        //    //dataGridView2.Rows.Clear();
        //    //string filePath = @"\\" + dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() + @"\d$\LOG_H2\" + dataGridView1[7, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() + @"\EzControl\System\ECS.Equipment.Host.COPCDriver_Tib_M\" + @"ECS.Equipment.Host.COPCDriver_Tib_M_" + DateTime.Now.ToString("yyyy-MM-dd_HH") + ".log";
        //    ////string filePath1 = @"\\"+ dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() + @"\d$\LOGS\"+ dataGridView1[7, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() + @"\EzControl\System\ECS.Equipment.Host.COPCDriver_Tib_M\" + DateTime.Now.ToString("yyyy-MM-dd_HH")  + ".log";
        //    ////MessageBox.Show(filePath);           
        //    //if (File.Exists(filePath))
        //    //{
        //    //    try
        //    //    {

        //    //        string[] lines = File.ReadAllLines(filePath);
        //    //        foreach (string line in lines)
        //    //        {
        //    //            if (line.Contains("=-1"))
        //    //            {
        //    //                dataGridView2.Rows.Add(line);
        //    //                dataGridView2.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        //    //                dataGridView2.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
        //    //                dataGridView2.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
        //    //            }
        //    //        }
        //    //    }
        //    //    catch (Exception ex)
        //    //    {
        //    //        MessageBox.Show("Error reading log file: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        //    //    }
        //    //}
        //    //else
        //    //{
        //    //    MessageBox.Show("File not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);               
        //    //}

        //    string[] filePaths = new string[] {
        //    @"\\" + dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() + @"\d$\LOG_H2\" + dataGridView1[7, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() + @"\EzControl\System\ECS.Equipment.Host.COPCDriver_Tib_M\" + @"ECS.Equipment.Host.COPCDriver_Tib_M_" + DateTime.Now.ToString("yyyy-MM-dd") + "_" + DateTime.Now.ToString("HH") + ".log",
        //    @"\\" + dataGridView1[2, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() + @"\d$\LOGS\" + dataGridView1[7, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString() + @"\EzControl\System\ECS.Equipment.Host.COPCDriver_Tib_M\" + DateTime.Now.ToString("yyyy-MM-dd") + "_" + DateTime.Now.ToString("HH") + ".log"
        //    };
            
        //    //fileP(filePaths);
        //}
        private void xuatfile_excel(DataGridView g, string filename)
        {
            app obj = new app();
            obj.Application.Workbooks.Add(Type.Missing);
            obj.Columns.ColumnWidth = 25;

            for (int i = 1; i < g.Columns.Count + 1; i++)
            {
                obj.Cells[1, i] = g.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < g.Rows.Count; i++)
            {
                for (int j = 0; j < g.Columns.Count; j++)
                {
                    if (g.Rows[i].Cells[j].Value != null)
                    {
                        obj.Cells[i + 2, j + 1] = g.Rows[i].Cells[j].Value.ToString();
                    }
                }
            }
            obj.ActiveWorkbook.SaveAs(filename);
            obj.ActiveWorkbook.Saved = true;
            obj.Quit();
            MessageBox.Show("Export successfully!");
        }

        private void btnexportExcel_Click(object sender, EventArgs e)
        {
            //saveFileDialog1.Filter = "Excel Workbook (*xlsx,*xlsm)|*.xlsx;*.xlsm";
            saveFileDialog1.Filter = "Excel Workbook|*.xlsx";
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                xuatfile_excel(dataGridView1, saveFileDialog1.FileName);
            }
        }
        public void dataGridView1_MouseClick(object sender, MouseEventArgs e)
        {            
            ip = dataGridView1[1, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
            txtStatusHis.Text = cls.getHistory(query.selectStatus("Solution_DB", ip)) /*+ cls.getSolution(query.selectSolution("Solution_DB", ip))*/;
        }
        public string IDECS = "", History = "", Solution = "", TimeUpdate = "";

        private void btnBackup_Click(object sender, EventArgs e)
        {

            DialogResult result = MessageBox.Show("Do you want to backup this PC?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                try
                {
                    string batFilePath = @"\\10.121.54.241\d\Program\MECS.bat";

                    if (System.IO.File.Exists(batFilePath))
                    {
                        Process.Start("cmd.exe", "/C " + batFilePath);
                    }
                    else
                    {
                        MessageBox.Show("File .bat does not exist");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        private void dataGridView1_KeyUp(object sender, KeyEventArgs e)
        {
            txtStatusHis.Text = "";
            LoadHis();
        }

        private void timer3_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("HH:mm:ss");
        }

        private void btnUpdateSolution_Click(object sender, EventArgs e)
        {                 
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    target = i;
                    IDECS = dataGridView1[1, dataGridView1.SelectedCells[0].OwningRow.Index].Value.ToString();
                    History = txtError.Text;
                    Solution = txtSolution.Text;
                    TimeUpdate = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");                  
                }
            }
            if (target != -1)
            {
                cls.add_Solution("insert", query.insert_solution(), IDECS, History, Solution, TimeUpdate);
                LoadData_ECSMachine();
            }
            else
            {
                MessageBox.Show("Please check the checkbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            txtError.Text = "";   
            txtSolution.Text = "";
            string search = txtSearch.Text;
            dataGridView1.DataSource = cls.getData(query.search_load(search));
            LoadHis();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            TimeSpan elapsedTime = DateTime.Now - startTime;
            this.Text = "ECS Management - Start Date: " + startTime.ToString("yyyy/MM/dd") +" - Start Time: " + startTime.ToString("HH:mm:ss") + " - Elapsed Time: " + elapsedTime.ToString(@"hh\:mm\:ss");
        }

        private void btnpingAll_Click_1(object sender, EventArgs e)
        {
            int cout = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1[2, i].Value != null)
                {
                    if (ping(dataGridView1[2, i].Value.ToString()))
                    {
                        dataGridView1[2, i].Style.BackColor = Color.LightGreen;
                        cout++;
                    }
                    else
                    {
                        dataGridView1[2, i].Style.BackColor = Color.Red;
                        cout++;
                    }
                }
            }
        }

        Thread p;
        bool ping(string InIp)
        {
            bool result = false;
            string ip = "ping /n 1 " + InIp;

            Process p = new Process();
            p.StartInfo.FileName = "CMD.exe";
            p.StartInfo.Arguments = ip;
            p.StartInfo.UseShellExecute = false;
            p.StartInfo.RedirectStandardInput = true;
            p.StartInfo.RedirectStandardOutput = true;
            p.StartInfo.CreateNoWindow = true;

            p.Start();
            p.StandardInput.WriteLine(ip);
            p.StandardInput.Flush();
            p.StandardInput.Close();
            p.WaitForExit();            
            string[] line = p.StandardOutput.ReadToEnd().Split("\n\r".ToCharArray(), StringSplitOptions.RemoveEmptyEntries);
            foreach (string item in line)
            {
                if (Regex.IsMatch(item, "Reply from " + InIp + ": bytes=32 time") == true)
                {
                    result = true;
                    break;
                }
            }            
            return result;

        }      

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dataGridView1.RowCount; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value != null)
                {
                    target = i;
                    ID = dataGridView1.Rows[target].Cells[1].Value.ToString();
                    IP_Address = dataGridView1.Rows[target].Cells[2].Value.ToString();
                    ECS_Type = dataGridView1.Rows[target].Cells[3].Value.ToString();
                    Locat = dataGridView1.Rows[target].Cells[4].Value.ToString();
                    Phone = dataGridView1.Rows[target].Cells[5].Value.ToString();
                    EQP_Name = dataGridView1.Rows[target].Cells[6].Value.ToString();
                    EM_No = dataGridView1.Rows[target].Cells[7].Value.ToString();
                }
            }
            if (target != -1)
            {
                cls.update("update", query.update(), ID, IP_Address, ECS_Type, Locat, Phone, EQP_Name, EM_No);
                LoadData_ECSMachine();                
            }
            else
            {
                MessageBox.Show("Please check the checkbox", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            string search = txtSearch.Text;
            dataGridView1.DataSource = cls.getData(query.search_load(search));
            LoadHis();
        }       
    }
}
