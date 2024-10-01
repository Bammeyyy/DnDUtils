using Microsoft.VisualBasic.Devices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace DnDUtils
{
    public partial class Lookup : Form
    {
        public Lookup()
        {
            InitializeComponent();
            data_5eDB.Visible = false;
        }

        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private DataTable dtSpells = new DataTable();
        private DataTable dtWeapons = new DataTable();
        private DataTable dtFeats = new DataTable();
        private DataTable dtItems = new DataTable();
        //private DataTable dtEmpty = new DataTable();
        private DataView dv = new DataView();

        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            dv.Table = ds.Tables[0];
            data_5eDB.DataSource = dv;
            dv.RowFilter = "name like '%" + txtBox_Search.Text + "%'";
            data_5eDB.DataSource = dv;
            data_5eDB.AutoResizeRows();
        }

        private void radio_Spells_CheckedChanged(object sender, EventArgs e)
        {
            clearData();
            string spells = "spells.xml";
            if (radio_Spells.Checked)
            {
                data_5eDB.Visible = false;
                loadData(spells);
                //data_5eDB.AutoResizeColumns();
                data_5eDB.Columns[0].Width = 100;
                data_5eDB.Columns[1].Width = 40;
                data_5eDB.Columns[2].Width = 57;
                data_5eDB.Columns[3].Width = 65;
                data_5eDB.Columns[4].Width = 730;
                data_5eDB.Columns[5].Width = 60;
                data_5eDB.Columns[6].Width = 105;
                data_5eDB.Columns[7].Width = 110;
                data_5eDB.Columns[8].Width = 80;
                data_5eDB.Columns[9].Width = 60;
                data_5eDB.Columns[10].Width = 63;
                disableSort();
                //data_5eDB.AutoResizeRows();
                data_5eDB.Refresh();
                data_5eDB.Visible = true;
            }
        }

        private void radio_Weps_CheckedChanged(object sender, EventArgs e)
        {
            clearData();
            string weapons = "weapons.xml";
            if (radio_Weps.Checked)
            {
                data_5eDB.Visible = false;
                loadData(weapons);
                //data_5eDB.AutoResizeRows();
                //data_5eDB.AutoResizeColumns();
                data_5eDB.Columns[6].Width = 500;
                disableSort();
                data_5eDB.Refresh();
                data_5eDB.Visible = true;
            }
        }

        private void radio_Feats_CheckedChanged(object sender, EventArgs e)
        {
            clearData();
            string feats = "feats.xml";
            if (radio_Feats.Checked)
            {
                loadData(feats);
                //data_5eDB.AutoResizeColumns();
                data_5eDB.Columns[0].Width = 200;
                data_5eDB.Columns[1].Width = 1100;
                disableSort();
                //data_5eDB.AutoResizeRows();
                data_5eDB.Refresh();
            }
        }

        private void radio_Items_CheckedChanged(object sender, EventArgs e)
        {
            clearData();
            string items = "items.xml";
            if (radio_Items.Checked)
            {
                loadData(items);
                data_5eDB.AutoResizeRows();
                data_5eDB.AutoResizeColumns();
                disableSort();
                data_5eDB.Refresh();
            }
        }

        private void data_5eDB_SelectionChanged(object sender, EventArgs e)
        {
            data_5eDB.CurrentCell = null;
        }

        private void data_5eDB_ColumnSortModeChanged(object sender, DataGridViewColumnEventArgs e)
        {
            data_5eDB.AutoResizeRows();
        }

        private void clearData()
        {
            ds.Dispose();
            dt.Dispose();
            dt = new DataTable();
            ds = new DataSet();
        }

        private void disableSort()
        {
            foreach (DataGridViewColumn col in data_5eDB.Columns)
            {
                col.SortMode = DataGridViewColumnSortMode.NotSortable;
            }
        }

        private void loadData(string file)
        {
            string folder = @".\data\";
            string path = folder + file;
            data_5eDB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            data_5eDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            ds.ReadXml(path);
            dt = ds.Tables[0];
            data_5eDB.DataSource = dt;
            data_5eDB.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            data_5eDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        }
    }
}