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
        }

        private string file;
        private DataSet ds = new DataSet();
        private DataTable dt = new DataTable();
        private DataTable dtEmpty = new DataTable();
        private DataView dv = new DataView();

        private void txtBox_Search_TextChanged(object sender, EventArgs e)
        {
            dv.Table = ds.Tables[0];
            data_5eDB.DataSource = dv;
            dv.RowFilter = "name like '%" + txtBox_Search.Text + "%'";
            data_5eDB.DataSource = dv;
        }

        private void radio_Spells_CheckedChanged(object sender, EventArgs e)
        {
            clearData();
            if (radio_Spells.Checked)
            {
                file = @"C:\Users\Bammie\Desktop\spells.xml";
                ds.ReadXml(file);
                dt = ds.Tables[0];
                data_5eDB.DataSource = dt;
                data_5eDB.AutoResizeRows();
                data_5eDB.Columns[1].Width = 1000;
                disableSort();
                data_5eDB.Refresh();
            }
        }

        private void radio_Weps_CheckedChanged(object sender, EventArgs e)
        {
            clearData();
            if (radio_Weps.Checked)
            {
                data_5eDB.DataSource = null;
                file = @"C:\Users\Bammie\Desktop\weapons.xml";
                ds.ReadXml(file);
                dt = ds.Tables[0];
                data_5eDB.DataSource = dt;
                disableSort();
                data_5eDB.Refresh();
            }
        }

        private void radio_Feats_CheckedChanged(object sender, EventArgs e)
        {
            clearData();
            if (radio_Feats.Checked)
            {
                data_5eDB.DataSource = null;
                file = @"C:\Users\Bammie\Desktop\feats.xml";
                ds.ReadXml(file);
                dt = ds.Tables[0];
                data_5eDB.DataSource = dt;
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
    }
}