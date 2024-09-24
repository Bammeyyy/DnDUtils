using System.Data;

namespace DnDUtils
{
    partial class Lookup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            txtBox_Search = new TextBox();
            data_5eDB = new DataGridView();
            radio_Spells = new RadioButton();
            radio_Weps = new RadioButton();
            radio_Feats = new RadioButton();
            ((System.ComponentModel.ISupportInitialize)data_5eDB).BeginInit();
            SuspendLayout();
            // 
            // txtBox_Search
            // 
            txtBox_Search.Location = new Point(12, 14);
            txtBox_Search.Name = "txtBox_Search";
            txtBox_Search.Size = new Size(1392, 23);
            txtBox_Search.TabIndex = 0;
            txtBox_Search.TextChanged += txtBox_Search_TextChanged;
            // 
            // data_5eDB
            // 
            data_5eDB.AllowUserToAddRows = false;
            data_5eDB.AllowUserToDeleteRows = false;
            data_5eDB.AllowUserToResizeColumns = false;
            data_5eDB.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            data_5eDB.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Control;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            data_5eDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            data_5eDB.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Window;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            data_5eDB.DefaultCellStyle = dataGridViewCellStyle3;
            data_5eDB.Location = new Point(12, 68);
            data_5eDB.Name = "data_5eDB";
            data_5eDB.ReadOnly = true;
            data_5eDB.RowHeadersVisible = false;
            data_5eDB.Size = new Size(1392, 604);
            data_5eDB.TabIndex = 4;
            data_5eDB.ColumnSortModeChanged += data_5eDB_ColumnSortModeChanged;
            data_5eDB.SelectionChanged += data_5eDB_SelectionChanged;
            // 
            // radio_Spells
            // 
            radio_Spells.AutoSize = true;
            radio_Spells.Location = new Point(12, 43);
            radio_Spells.Name = "radio_Spells";
            radio_Spells.Size = new Size(55, 19);
            radio_Spells.TabIndex = 5;
            radio_Spells.Text = "Spells";
            radio_Spells.UseVisualStyleBackColor = true;
            radio_Spells.CheckedChanged += radio_Spells_CheckedChanged;
            // 
            // radio_Weps
            // 
            radio_Weps.AutoSize = true;
            radio_Weps.Location = new Point(73, 43);
            radio_Weps.Name = "radio_Weps";
            radio_Weps.Size = new Size(74, 19);
            radio_Weps.TabIndex = 5;
            radio_Weps.Text = "Weapons";
            radio_Weps.UseVisualStyleBackColor = true;
            radio_Weps.CheckedChanged += radio_Weps_CheckedChanged;
            // 
            // radio_Feats
            // 
            radio_Feats.AutoSize = true;
            radio_Feats.Location = new Point(153, 43);
            radio_Feats.Name = "radio_Feats";
            radio_Feats.Size = new Size(52, 19);
            radio_Feats.TabIndex = 5;
            radio_Feats.Text = "Feats";
            radio_Feats.UseVisualStyleBackColor = true;
            radio_Feats.CheckedChanged += radio_Feats_CheckedChanged;
            // 
            // Lookup
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1416, 684);
            Controls.Add(radio_Feats);
            Controls.Add(radio_Weps);
            Controls.Add(radio_Spells);
            Controls.Add(data_5eDB);
            Controls.Add(txtBox_Search);
            Name = "Lookup";
            Text = "D&D Utilities";
            ((System.ComponentModel.ISupportInitialize)data_5eDB).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtBox_Search;
        private DataGridView data_5eDB;
        private RadioButton radio_Spells;
        private RadioButton radio_Weps;
        private RadioButton radio_Feats;
    }
}