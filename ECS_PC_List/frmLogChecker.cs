using System;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ECS_PC_List
{
    public partial class frmLogChecker : Form
    {
        public frmLogChecker()
        {
            InitializeComponent();
        }
        Thread Run;
        private void btCheck_Click(object sender, EventArgs e)
        {

            try
            {
                for (int i = 0; i < 24; i++)
                {

                    dataGridView1[1, i].Value = "";
                    dataGridView1[2, i].Value = "";
                    dataGridView1[3, i].Value = "";
                    dataGridView1[4, i].Value = "";
                    dataGridView1[5, i].Value = "";
                    dataGridView1[6, i].Value = "";
                }
                if (Run != null)
                {
                    if (Run.ThreadState == ThreadState.Running)
                    {
                        Run.Abort();
                    }
                }
                Run = new Thread(() =>
                {
                    countAll();
                });
                Run.Start();
            }
            catch { MessageBox.Show("Đang có lỗi"); }
        }
        void countAll()
        {
            for (int i = 0; i < 24; i++)
            {
                //int count1=0, count2=0, count3=0, count4 = 0;


                string tenfile = @txtDuongDan.Text + txtFilename.Text + "_" + i.ToString("D2") + ".log";
                //MessageBox.Show(tenfile);
                //dataGridView1.Rows.Add();

                if (File.Exists(tenfile))
                {
                    dataGridView1[1, i].Value = timchuoi(tenfile, txt1.Text, txt1_1.Text, txt1_2.Text);
                    dataGridView1[2, i].Value = timchuoi(tenfile, txt2.Text, txt2_1.Text, txt2_2.Text);
                    dataGridView1[3, i].Value = timchuoi2(tenfile, txt3.Text, txt3_1.Text, txt3_2.Text);
                    dataGridView1[4, i].Value = timchuoi2(tenfile, txt4.Text, txt4_1.Text, txt4_2.Text);
                    dataGridView1[5, i].Value = timchuoi2(tenfile, txt5.Text, txt5_1.Text, txt5_2.Text);
                    dataGridView1[6, i].Value = timchuoi2(tenfile, txt6.Text, txt6_1.Text, txt6_2.Text);
                }


            }
        }
        int timchuoi(string tenfile, string chuoi1, string chuoi2, string chuoi3)
        {
            int count = 0;
            string[] alltext = File.ReadAllLines(tenfile);
            //MessageBox.Show(alltext[5645].ToString());
            for (int j = 0; j < alltext.Length; j++)
            {
                if (alltext[j].Contains(chuoi1) && alltext[j].Contains(chuoi2) && alltext[j].Contains(chuoi3))
                {
                    count++;
                }
            }
            return count;
        }
        int timchuoi2(string tenfile, string chuoi1, string chuoi2, string chuoi3)
        {
            int count = 0;
            string[] alltext = File.ReadAllLines(tenfile);
            //MessageBox.Show(alltext[5645].ToString());
            for (int j = 0; j < alltext.Length; j++)
            {
                if (alltext[j].Contains(chuoi1) && alltext[j].Contains(chuoi2) && alltext[j].Contains(chuoi3))
                {
                    count++;
                }
            }
            return count;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 24; i++)
            {
                dataGridView1.Rows.Add();
                dataGridView1.Rows[i].Cells[0].Value = i.ToString("D2") + ":00";
            }
            txtFilename.Text = /*"ECS.Equipment.Host.COPCDriver_Tib_M_" +*/ dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month.ToString("D2") + "-" + dateTimePicker1.Value.Day.ToString("D2");

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            txtFilename.Text = /*"ECS.Equipment.Host.COPCDriver_Tib_M_" +*/ dateTimePicker1.Value.Year + "-" + dateTimePicker1.Value.Month.ToString("D2") + "-" + dateTimePicker1.Value.Day.ToString("D2");
        }

        private void btExit_Click(object sender, EventArgs e)
        {
            this.Close();           
        }

        private void txt4_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtDuongDan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFilename_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void rb1_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "ECUC";
            txt2.Text = "ECUC";
            txt3.Text = "ECUC";
            txt4.Text = "ECUC";
            txt5.Text = "ECUC";
            txt6.Text = "ECUC";
        }

        private void rb6_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            txt6.Text = "";
        }

        private void rb2_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "ETDC";
            txt2.Text = "ETDC";
            txt3.Text = "ETDC";
            txt4.Text = "ETDC";
            txt5.Text = "ETDC";
            txt6.Text = "ETDC";
        }

        private void rb3_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "ECUR";
            txt2.Text = "ECUR";
            txt3.Text = "ECUR";
            txt4.Text = "ECUR";
            txt5.Text = "ECUR";
            txt6.Text = "ECUR";
        }

        private void rb4_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "ELDC";
            txt2.Text = "ELDC";
            txt3.Text = "ELDC";
            txt4.Text = "ELDC";
            txt5.Text = "ELDC";
            txt6.Text = "ELDC";
        }

        private void rb5_CheckedChanged(object sender, EventArgs e)
        {
            txt1.Text = "ELIN";
            txt2.Text = "ELIN";
            txt3.Text = "ELIN";
            txt4.Text = "ELIN";
            txt5.Text = "ELIN";
            txt6.Text = "ELIN";
        }

        private void txtDuongDan_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void txtBrowse_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Log Files (*.log)|*.log";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                //txtShow.Text = openFileDialog.FileName;
                int lastIndex = openFileDialog.FileName.LastIndexOf('\\');

                if (lastIndex >= 0)
                {
                    // Lấy đường dẫn từ đầu đến dấu '\' cuối cùng
                    string folderPath = openFileDialog.FileName.Substring(0, lastIndex + 1);

                    // Hiển thị đường dẫn lên ô văn bản (txtPath)
                    txtDuongDan.Text = folderPath;
                }
                else
                {

                }
            }
        }
    }
}
