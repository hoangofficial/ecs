using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SHDocVw;
using System.Diagnostics;

namespace ECS_PC_List
{
    public partial class Form3 : Form
    {
        private InternetExplorer internetExplorer;
        public Form3()
        {
            InitializeComponent();           
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string searchValue = textBox1.Text;
            if (searchValue =="")
            {
                MessageBox.Show("Please enter ID!");
            }
            else if (searchValue.Contains("RRV"))
            {
                internetExplorer = new InternetExplorer();
                internetExplorer.Navigate("http://pims.lgdisplay.com:8080/ism.prr.retrievePimOmu0082.dev?pgmId=PIMOMU0082&systemCode=ISM&requirementReviewNo=" + searchValue);
                internetExplorer.Visible = true;
            }
            else if (searchValue.Contains("UREQ"))
            {
                internetExplorer = new InternetExplorer();
                internetExplorer.Navigate("http://bss.lgdisplay.com:3300/oneClick.req.RetrieveUreq0101.dev?request_no=" + searchValue + "&pgmId=UREQ0101&systemCode=UGA&mode=view&ep_acpt_url=null&ep_acpt_prm=null&req_cnl_yn=null");
                internetExplorer.Visible = true;
            }
        }

        private void Form3_Load(object sender, EventArgs e)
        {

        } 
    }
}
