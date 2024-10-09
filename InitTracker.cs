using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace DnDUtils
{
    public partial class InitTracker : Form
    {
        private Dictionary<string, int> initOrder = new Dictionary<string, int>();
        private bool active = false;
        private System.Windows.Forms.Timer timer;
        private Stopwatch stopWatch = new Stopwatch();
        private int currentRound;
        private int currentTurnNum;

        public InitTracker()
        {
            InitializeComponent();
            lbl_RoundNum.Text = "";
        }

        private void btn_addToInitOrder_Click(object sender, EventArgs e)
        {
            if (txtBox_Name.Text != "" && !initOrder.ContainsKey(txtBox_Name.Text))
            {
                if (!active)
                {
                    var newEntry = new KeyValuePair<string, int>(txtBox_Name.Text, (int)num_InitValue.Value);
                    string newEntryString = String.Format("{0:00}", newEntry.Value) + " - " + newEntry.Key;
                    lstBox_Init.Items.Add(newEntryString);
                    initOrder.Add(txtBox_Name.Text, (int)num_InitValue.Value);
                    txtBox_Name.Clear();
                    num_InitValue.Value = 0;
                }
                else
                {
                    string currentTurn = lstBox_Init.SelectedItem.ToString();
                    currentTurn = currentTurn.Remove(0, 5);
                    var newEntry = new KeyValuePair<string, int>(txtBox_Name.Text, (int)num_InitValue.Value);
                    string newEntryString = String.Format("{0:00}", newEntry.Value) + " - " + newEntry.Key;
                    initOrder.Add(txtBox_Name.Text, (int)num_InitValue.Value);
                    txtBox_Name.Clear();
                    num_InitValue.Value = 0;
                    var sortedInitOrder = initOrder.OrderByDescending(x => x.Value);
                    lstBox_Init.Items.Clear();
                    foreach (KeyValuePair<string, int> entry in sortedInitOrder)
                    {
                        lstBox_Init.Items.Add(String.Format("{0:00}", entry.Value) + " - " + entry.Key);
                    }
                    for (int i = 0; i < lstBox_Init.Items.Count; i++)
                    {
                        if (lstBox_Init.Items[i].ToString().Contains(currentTurn))
                        {
                            lstBox_Init.SelectedItem = lstBox_Init.Items[i];
                            break;
                        }
                    }
                }
            }
        }

        private void btn_StartInit_Click(object sender, EventArgs e)
        {
            if (initOrder.Count > 0)
            {
                lbl_Timer.Text = "00:00";

                var sortedInitOrder = initOrder.OrderByDescending(x => x.Value);
                lstBox_Init.Items.Clear();
                foreach (KeyValuePair<string, int> entry in sortedInitOrder)
                {
                    lstBox_Init.Items.Add(String.Format("{0:00}", entry.Value) + " - " + entry.Key);
                }
                lstBox_Init.SelectedItems.Add(lstBox_Init.Items[0]);
                currentTurnNum = 0;
                active = true;


                startTimer();

                currentRound = 1;
                lbl_RoundNum.Text = currentRound.ToString();
            }
        }

        private void btn_EndInit_Click(object sender, EventArgs e)
        {
            endCombat();
        }

        private void btn_Next_Click(object sender, EventArgs e)
        {
            if (active)
            {
                if (currentTurnNum < initOrder.Count - 1)
                {
                    currentTurnNum++;
                    lstBox_Init.SelectedIndex = currentTurnNum;
                }
                else
                {
                    currentTurnNum = 0;
                    lstBox_Init.SelectedIndex = currentTurnNum;
                    currentRound++;
                    lbl_RoundNum.Text = currentRound.ToString();
                }
                
                stopWatch.Restart();
            }
        }

        private void btn_Remove_Click(object sender, EventArgs e)
        {
            string toRemove = lstBox_Init.SelectedItem.ToString();
            toRemove = toRemove.Remove(0, 5);
            lstBox_Init.Items.RemoveAt(currentTurnNum);
            initOrder.Remove(toRemove);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            string toRemove;
            foreach (var item in lstBox_Init.Items)
            {
                toRemove = item.ToString();
                toRemove = toRemove.Remove(0, 5);
                initOrder.Remove(toRemove);
            }

            lstBox_Init.Items.Clear();

            endCombat();
        }

        private void lstBox_Init_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentTurnNum = lstBox_Init.SelectedIndex;
        }

        private void updateTime(object sender, EventArgs e)
        {
            lbl_Timer.Text = stopWatch.Elapsed.ToString(@"mm\:ss");
        }

        private void startTimer()
        {
            timer = new System.Windows.Forms.Timer();
            timer.Tick += new EventHandler(updateTime);
            timer.Interval = 1000;
            timer.Start();

            stopWatch.Start();
        }

        private void stopTimer()
        {
            stopWatch.Stop();
            stopWatch.Reset();

            timer.Stop();
            timer.Dispose();
            lbl_Timer.Text = "00:00";
        }

        private void endCombat()
        {
            stopTimer();
            currentRound = 1;
            lbl_RoundNum.Text = "";
            active = false;
        }
    }
}