using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListBox
{
    public partial class Form1 : Form
    {
        String OrgStr = ""; // 결과 : saved
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.OrgStr = this.lblResult.Text;
        }

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            if (TextCheck())
            {
                this.lbVIew.Items.Add(this.txtList.Text); // add entry
                this.txtList.Text = "";
            }
        }

        private bool TextCheck()
        {
            if(this.txtList.Text == "")
            {
                MessageBox.Show("Please writting comment."
                    , "notice"
                    , MessageBoxButtons.OK
                    , MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        private void LbVIew_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.lblResult.Text = this.OrgStr + this.lbVIew.Text;

        }
    }
}
