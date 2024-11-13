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
            //Check for null textbox and if already in list
            if (txtBox_Name.Text != "" && !initOrder.ContainsKey(txtBox_Name.Text))
            {
                //if combat is not active
                if (!active)
                {
                    //create key/value pairs for new entry
                    var newEntry = new KeyValuePair<string, int>(txtBox_Name.Text, (int)num_InitValue.Value);
                    var newEntryHP = new KeyValuePair<string, int>(txtBox_Name.Text, (int)num_HPValue.Value);
                    string nameHP = txtBox_Name.Text + " - " + num_HPValue.ToString() + "hp";
                    //formatting name to string with leading init value and trailing HP value
                    string newEntryString = String.Format("{0:00}", newEntry.Value) + " - " + newEntry.Key + " - " + String.Format("{0:000}", newEntryHP.Value) + "hp";
                    lstBox_Init.Items.Add(newEntryString);
                    initOrder.Add(newEntry.Key + " - " + String.Format("{0:000}", newEntryHP.Value) + "hp", newEntry.Value);
                    txtBox_Name.Clear();
                    num_InitValue.Value = 0;
                    num_Dmg.Value = 0;
                }
                //if combat is active
                else
                {
                    string currentTurn = lstBox_Init.SelectedItem.ToString();
                    currentTurn = currentTurn.Remove(0, 5);
                    currentTurn = currentTurn.Remove (currentTurn.Length - 5, 5);
                    var newEntry = new KeyValuePair<string, int>(txtBox_Name.Text, (int)num_InitValue.Value);
                    var newEntryHP = new KeyValuePair<string, int>(txtBox_Name.Text, (int)num_HPValue.Value);
                    string nameHP = txtBox_Name.Text + " - " + num_HPValue.ToString() + "hp";
                    //formatting name to string with leading init value and trailing HP value
                    string newEntryString = String.Format("{0:00}", newEntry.Value) + " - " + newEntry.Key + " - " + String.Format("{0:000}", newEntryHP.Value) + "hp";
                    lstBox_Init.Items.Add(newEntryString);
                    initOrder.Add(newEntry.Key + " - " + String.Format("{0:000}", newEntryHP.Value) + "hp", newEntry.Value);
                    txtBox_Name.Clear();
                    num_InitValue.Value = 0;
                    num_Dmg.Value = 0;
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
            toRemove = toRemove.Remove(toRemove.Length - 8, 8);
            lstBox_Init.Items.RemoveAt(currentTurnNum);
            initOrder.Remove(toRemove);
            //Console.WriteLine(toRemove);
            //Console.WriteLine(initOrder.Keys);
            //Console.WriteLine(initOrder.Values);
        }

        private void btn_Reset_Click(object sender, EventArgs e)
        {
            string toRemove;
            foreach (var item in lstBox_Init.Items)
            {
                toRemove = item.ToString();
                toRemove = toRemove.Remove(0, 5);
                toRemove = toRemove.Remove(toRemove.Length - 8, 8);
                initOrder.Remove(toRemove);
            }

            lstBox_Init.Items.Clear();

            endCombat();
        }

        private void lstBox_Init_SelectedIndexChanged(object sender, EventArgs e)
        {
            //currentTurnNum = lstBox_Init.SelectedIndex;
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
            if (stopWatch.IsRunning)
            {
                stopWatch.Stop();
                stopWatch.Reset();
            }

            if (timer != null)
            {
                timer.Stop();
                timer.Dispose();
            }

            lbl_Timer.Text = "00:00";
        }

        private void endCombat()
        {
            stopTimer();
            currentRound = 1;
            lbl_RoundNum.Text = "";
            active = false;
        }

        private void btn_Dmg_Click(object sender, EventArgs e)
        {
            if (lstBox_Init.SelectedItem != null)
            {
                string currentPlayer = lstBox_Init.SelectedItem.ToString();
                string current = currentPlayer.Remove(currentPlayer.Length - 2, 2);
                current = current.Remove(0, current.Length - 3);
                int currentHP = int.Parse(current);
                currentHP = currentHP - (int)num_Dmg.Value;
                current = currentPlayer.Remove(currentPlayer.Length - 5, 5);
                current = current + String.Format("{0:000}", currentHP) + "hp";
                lstBox_Init.Items.Insert(lstBox_Init.SelectedIndex, current);
                lstBox_Init.Items.Remove(lstBox_Init.SelectedItem);
                lstBox_Init.SelectedIndex = currentTurnNum;
                num_Dmg.Value = 0;
            }
        }

        private void btn_Heal_Click(object sender, EventArgs e)
        {
            if (lstBox_Init.SelectedItem != null)
            {
                string currentPlayer = lstBox_Init.SelectedItem.ToString();
                string current = currentPlayer.Remove(currentPlayer.Length - 2, 2);
                current = current.Remove(0, current.Length - 3);
                int currentHP = int.Parse(current);
                currentHP = currentHP + (int)num_Dmg.Value;
                current = currentPlayer.Remove(currentPlayer.Length - 5, 5);
                current = current + String.Format("{0:000}", currentHP) + "hp";
                lstBox_Init.Items.Insert(lstBox_Init.SelectedIndex, current);
                lstBox_Init.Items.Remove(lstBox_Init.SelectedItem);
                lstBox_Init.SelectedIndex = currentTurnNum;
                num_Dmg.Value = 0;
            }
        }

        private void btn_Prev_Click(object sender, EventArgs e)
        {
            if (active)
            {
                if (currentTurnNum > 0)
                {
                    currentTurnNum--;
                    lstBox_Init.SelectedIndex = currentTurnNum;
                }
                else
                {
                    currentTurnNum = lstBox_Init.Items.Count - 1;
                    lstBox_Init.SelectedIndex = currentTurnNum;
                    currentRound--;
                    lbl_RoundNum.Text = currentRound.ToString();
                }

                stopWatch.Restart();
            }
        }
    }
}