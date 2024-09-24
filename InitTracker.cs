using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DnDUtils
{
    public partial class InitTracker : Form
    {
        string[] initList = {"hi", "bye"};
        string initNum;
        int minutes;
        int hours;
        int seconds;
        string colonSec = "";
        string colonMin = "";
        string colonHr = "";
        public InitTracker()
        {
            InitializeComponent();
            numUpDwn_InitAdd.ResetText();
            lstBox_InitList.Items.AddRange(initList);

        }
        private void tmr_TurnTimer_Elapsed()
        {

        }
        private void btn_NextTurn_Click(object sender, EventArgs e)
        {
            seconds = 0;
            minutes = 0;
            hours = 0;
            lbl_TurnTimer.Text = "00:00:00";
        }
        private void btn_AddToInit_Click(object sender, EventArgs e)
        {
            txtBox_Name.Focus();
            if (numUpDwn_InitAdd.Value < 10)
            {
                initNum = "0" + numUpDwn_InitAdd.Value;
            }
            for (int i = 0; i < initList.Length; i++) 
            {
                //going to compair, look at note pad doopid
                //initList[i]
            }
            //replace with normal array later then set this to the array //lstBox_InitList.Items.Add(txtBox_Name.Text + ", " + numUpDwn_InitAdd.Value);
            txtBox_Name.Clear();
            numUpDwn_InitAdd.Value = 0;
            numUpDwn_InitAdd.ResetText();
        }

        private void tmr_TurnTimer_Tick(object sender, EventArgs e)
        {
            seconds++;
            if (seconds >= 60)
            {
                seconds = 0;
                minutes++;
            }
            if (minutes >= 60)
            {
                minutes = 0;
                hours++;
            }
            if (hours < 10)
            {
                colonHr = "0";
            }
            if (minutes <10)
            {
                colonMin = ":0";
            } else
            {
                colonMin = ":";
            }
            if (seconds < 10)
            {
                colonSec = ":0";
            }
            else
            {
                colonSec = ":";
            }
            lbl_TurnTimer.Text = colonHr + hours.ToString() + colonMin + minutes.ToString() + colonSec + seconds;
        }
    }
}
