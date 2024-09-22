using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDUtils
{
    public partial class InitTracker : Form
    {
        public InitTracker()
        {
            InitializeComponent();
        }

        private void txtBox_Name_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                lstBox_InitList.Items.Add(txtBox_Name.Text);
                txtBox_Name.Clear();
            }
        }
        
        


        private void btn_NextTurn_Click(object sender, EventArgs e)
        {

        }
    }
}
