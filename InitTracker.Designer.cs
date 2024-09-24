namespace DnDUtils
{
    partial class InitTracker
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
            components = new System.ComponentModel.Container();
            lbl_TurnTimer = new Label();
            lstBox_InitList = new ListBox();
            txtBox_Name = new TextBox();
            btn_NextTurn = new Button();
            lbl_NameAndInit = new Label();
            btn_AddToInit = new Button();
            numUpDwn_InitAdd = new NumericUpDown();
            label1 = new Label();
            tmr_TurnTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)numUpDwn_InitAdd).BeginInit();
            SuspendLayout();
            // 
            // lbl_TurnTimer
            // 
            lbl_TurnTimer.AutoSize = true;
            lbl_TurnTimer.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lbl_TurnTimer.Location = new Point(12, 9);
            lbl_TurnTimer.Name = "lbl_TurnTimer";
            lbl_TurnTimer.RightToLeft = RightToLeft.No;
            lbl_TurnTimer.Size = new Size(158, 47);
            lbl_TurnTimer.TabIndex = 1;
            lbl_TurnTimer.Text = "00:00:00";
            // 
            // lstBox_InitList
            // 
            lstBox_InitList.Font = new Font("Segoe UI", 14F);
            lstBox_InitList.FormattingEnabled = true;
            lstBox_InitList.ItemHeight = 25;
            lstBox_InitList.Location = new Point(206, 12);
            lstBox_InitList.Name = "lstBox_InitList";
            lstBox_InitList.Size = new Size(193, 329);
            lstBox_InitList.TabIndex = 0;
            lstBox_InitList.TabStop = false;
            // 
            // txtBox_Name
            // 
            txtBox_Name.AcceptsReturn = true;
            txtBox_Name.Location = new Point(96, 170);
            txtBox_Name.Multiline = true;
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(100, 23);
            txtBox_Name.TabIndex = 2;
            // 
            // btn_NextTurn
            // 
            btn_NextTurn.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_NextTurn.Location = new Point(12, 60);
            btn_NextTurn.Name = "btn_NextTurn";
            btn_NextTurn.Size = new Size(188, 104);
            btn_NextTurn.TabIndex = 1;
            btn_NextTurn.Text = "Next Turn";
            btn_NextTurn.UseVisualStyleBackColor = true;
            btn_NextTurn.Click += btn_NextTurn_Click;
            // 
            // lbl_NameAndInit
            // 
            lbl_NameAndInit.AutoSize = true;
            lbl_NameAndInit.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_NameAndInit.Location = new Point(9, 167);
            lbl_NameAndInit.Name = "lbl_NameAndInit";
            lbl_NameAndInit.Size = new Size(81, 32);
            lbl_NameAndInit.TabIndex = 7;
            lbl_NameAndInit.Text = "Name";
            // 
            // btn_AddToInit
            // 
            btn_AddToInit.Font = new Font("Segoe UI", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AddToInit.Location = new Point(12, 246);
            btn_AddToInit.Name = "btn_AddToInit";
            btn_AddToInit.Size = new Size(188, 95);
            btn_AddToInit.TabIndex = 4;
            btn_AddToInit.Text = "Add Name";
            btn_AddToInit.UseVisualStyleBackColor = true;
            btn_AddToInit.Click += btn_AddToInit_Click;
            // 
            // numUpDwn_InitAdd
            // 
            numUpDwn_InitAdd.Location = new Point(96, 208);
            numUpDwn_InitAdd.Maximum = new decimal(new int[] { 99, 0, 0, 0 });
            numUpDwn_InitAdd.Name = "numUpDwn_InitAdd";
            numUpDwn_InitAdd.Size = new Size(100, 23);
            numUpDwn_InitAdd.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(62, 203);
            label1.Name = "label1";
            label1.Size = new Size(28, 32);
            label1.TabIndex = 10;
            label1.Text = "#";
            // 
            // tmr_TurnTimer
            // 
            tmr_TurnTimer.Enabled = true;
            tmr_TurnTimer.Interval = 1000;
            tmr_TurnTimer.Tick += tmr_TurnTimer_Tick;
            // 
            // InitTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 362);
            Controls.Add(label1);
            Controls.Add(numUpDwn_InitAdd);
            Controls.Add(btn_AddToInit);
            Controls.Add(lbl_NameAndInit);
            Controls.Add(btn_NextTurn);
            Controls.Add(txtBox_Name);
            Controls.Add(lstBox_InitList);
            Controls.Add(lbl_TurnTimer);
            Name = "InitTracker";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numUpDwn_InitAdd).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_TurnTimer;
        private ListBox lstBox_InitList;
        private TextBox txtBox_Name;
        private Button btn_NextTurn;
        private Label lbl_NameAndInit;
        private Button btn_AddToInit;
        private NumericUpDown numUpDwn_InitAdd;
        private Label label1;
        private System.Windows.Forms.Timer tmr_TurnTimer;
    }
}