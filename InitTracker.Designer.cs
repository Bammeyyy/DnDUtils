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
            lbl_TurnTimer = new Label();
            lstBox_InitList = new ListBox();
            lbl_AddName = new Label();
            txtBox_Name = new TextBox();
            btn_NextTurn = new Button();
            lbl_Name = new Label();
            btn_ = new Button();
            SuspendLayout();
            // 
            // lbl_TurnTimer
            // 
            lbl_TurnTimer.AutoSize = true;
            lbl_TurnTimer.Font = new Font("Segoe UI", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_TurnTimer.Location = new Point(12, 9);
            lbl_TurnTimer.Name = "lbl_TurnTimer";
            lbl_TurnTimer.RightToLeft = RightToLeft.No;
            lbl_TurnTimer.Size = new Size(107, 45);
            lbl_TurnTimer.TabIndex = 1;
            lbl_TurnTimer.Text = "Timer";
            // 
            // lstBox_InitList
            // 
            lstBox_InitList.FormattingEnabled = true;
            lstBox_InitList.ItemHeight = 15;
            lstBox_InitList.Location = new Point(664, 12);
            lstBox_InitList.Name = "lstBox_InitList";
            lstBox_InitList.Size = new Size(124, 229);
            lstBox_InitList.TabIndex = 2;
            // 
            // lbl_AddName
            // 
            lbl_AddName.AutoSize = true;
            lbl_AddName.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lbl_AddName.Location = new Point(476, 12);
            lbl_AddName.Name = "lbl_AddName";
            lbl_AddName.Size = new Size(0, 45);
            lbl_AddName.TabIndex = 4;
            // 
            // txtBox_Name
            // 
            txtBox_Name.AcceptsReturn = true;
            txtBox_Name.Location = new Point(484, 60);
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(100, 23);
            txtBox_Name.TabIndex = 5;
            txtBox_Name.KeyDown += txtBox_Name_KeyDown;
            // 
            // btn_NextTurn
            // 
            btn_NextTurn.Location = new Point(12, 60);
            btn_NextTurn.Name = "btn_NextTurn";
            btn_NextTurn.Size = new Size(75, 23);
            btn_NextTurn.TabIndex = 6;
            btn_NextTurn.Text = "Next";
            btn_NextTurn.UseVisualStyleBackColor = true;
            btn_NextTurn.Click += btn_NextTurn_Click;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(521, 19);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(38, 15);
            lbl_Name.TabIndex = 7;
            lbl_Name.Text = "label1";
            // 
            // btn_
            // 
            btn_.Location = new Point(484, 89);
            btn_.Name = "btn_";
            btn_.Size = new Size(75, 23);
            btn_.TabIndex = 8;
            btn_.Text = "button1";
            btn_.UseVisualStyleBackColor = true;
            // 
            // InitTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_);
            Controls.Add(lbl_Name);
            Controls.Add(btn_NextTurn);
            Controls.Add(txtBox_Name);
            Controls.Add(lbl_AddName);
            Controls.Add(lstBox_InitList);
            Controls.Add(lbl_TurnTimer);
            Name = "InitTracker";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lbl_TurnTimer;
        private ListBox lstBox_InitList;
        private Label lbl_AddName;
        private TextBox txtBox_Name;
        private Button btn_NextTurn;
        private Label lbl_Name;
        private Button btn_;
    }
}