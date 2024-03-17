using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace APD_ChangeToCSV
{
    public partial class ucAPDHeader : UserControl
    {
        private List<string> _mComboItemList = null;
        public List<string> mComboItemList
        {
            get { return _mComboItemList; }
            set { _mComboItemList = value; }
        }

        private bool _mValidataion = false;
        public bool mValidataion
        {
            get { return _mValidataion; }
            set { _mValidataion = value; }
        }

        public ucAPDHeader()
        {
            InitializeComponent();
        }

        public void Initialize(string strKey, string[] arraHeaderItem, bool bValidation)
        {
            lblName01.Text = strKey;
            cbItemList.Items.AddRange(arraHeaderItem);
            chkValidation.Checked = bValidation;
            _mComboItemList = arraHeaderItem.ToList();          
        }
        public void Initialize(string strKey, string[] arraHeaderItem)
        {
            lblName01.Text = strKey;
            cbItemList.Items.AddRange(arraHeaderItem);
            chkValidation.Visible = false;
            _mComboItemList = arraHeaderItem.ToList();
        }

        public delegate void delegateAddItem(string Item);
        public void Add_Item(string Item)
        {
            if (InvokeRequired)
            {
                this.BeginInvoke(new delegateAddItem(Add_Item), Item);
            }
            else
            {
                if (string.IsNullOrEmpty(Item)) return;
                string[] temp = Item.Split(',');
                for (int i = 0; i < cbItemList.Items.Count; i++)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (temp[j].ToUpper() == cbItemList.Items[i].ToString().ToUpper()) return;
                    }
                }
                cbItemList.Items.AddRange(temp);
                _mComboItemList.AddRange(temp);
            }
        }


        public delegate void delegateDeleteItem(string Item);
        public void Delete_Item(string Item)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new delegateDeleteItem(Delete_Item), Item);
            }
            else
            {
                if (string.IsNullOrEmpty(Item)) return;
                string[] temp = Item.Split(',');
                for (int i = 0; i < cbItemList.Items.Count; i++)
                {
                    for (int j = 0; j < temp.Length; j++)
                    {
                        if (temp[j].ToUpper() == cbItemList.Items[i].ToString().ToUpper())
                        {
                            if (cbItemList.Items.Count == 1)
                            {
                                MessageBox.Show("It's requires at list one item ");
                                return;
                            }
                            cbItemList.Items.RemoveAt(i);
                            _mComboItemList.RemoveAt(i);
                        }
                    }
                } 
            }
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            Add_Item(cbItemList.Text);
            cbItemList.Text = "";
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Delete_Item(cbItemList.Text);
            cbItemList.Text = "";
        }

        private void chkValidation_CheckedChanged(object sender, EventArgs e)
        {
            mValidataion = chkValidation.Checked;
        } 
    }
}
