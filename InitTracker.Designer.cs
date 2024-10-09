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
            lbl_Timer = new Label();
            lstBox_Init = new ListBox();
            btn_addToInitOrder = new Button();
            btn_StartInit = new Button();
            txtBox_Name = new TextBox();
            num_InitValue = new NumericUpDown();
            btn_Remove = new Button();
            lbl_Name = new Label();
            lbl_InitValue = new Label();
            btn_Next = new Button();
            lbl_Round = new Label();
            btn_EndInit = new Button();
            lbl_RoundNum = new Label();
            btn_Reset = new Button();
            ((System.ComponentModel.ISupportInitialize)num_InitValue).BeginInit();
            SuspendLayout();
            // 
            // lbl_Timer
            // 
            lbl_Timer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Timer.Location = new Point(214, 41);
            lbl_Timer.Name = "lbl_Timer";
            lbl_Timer.Size = new Size(77, 30);
            lbl_Timer.TabIndex = 0;
            lbl_Timer.Text = "00:00";
            lbl_Timer.TextAlign = ContentAlignment.TopRight;
            // 
            // lstBox_Init
            // 
            lstBox_Init.FormattingEnabled = true;
            lstBox_Init.ItemHeight = 15;
            lstBox_Init.Location = new Point(6, 118);
            lstBox_Init.Name = "lstBox_Init";
            lstBox_Init.Size = new Size(202, 259);
            lstBox_Init.TabIndex = 1;
            lstBox_Init.SelectedIndexChanged += lstBox_Init_SelectedIndexChanged;
            // 
            // btn_addToInitOrder
            // 
            btn_addToInitOrder.Location = new Point(214, 119);
            btn_addToInitOrder.Name = "btn_addToInitOrder";
            btn_addToInitOrder.Size = new Size(75, 23);
            btn_addToInitOrder.TabIndex = 2;
            btn_addToInitOrder.Text = "Add";
            btn_addToInitOrder.UseVisualStyleBackColor = true;
            btn_addToInitOrder.Click += btn_addToInitOrder_Click;
            // 
            // btn_StartInit
            // 
            btn_StartInit.Location = new Point(6, 6);
            btn_StartInit.Name = "btn_StartInit";
            btn_StartInit.Size = new Size(95, 32);
            btn_StartInit.TabIndex = 4;
            btn_StartInit.Text = "Start Combat";
            btn_StartInit.UseVisualStyleBackColor = true;
            btn_StartInit.Click += btn_StartInit_Click;
            // 
            // txtBox_Name
            // 
            txtBox_Name.Location = new Point(6, 89);
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(202, 23);
            txtBox_Name.TabIndex = 5;
            // 
            // num_InitValue
            // 
            num_InitValue.Location = new Point(214, 90);
            num_InitValue.Name = "num_InitValue";
            num_InitValue.Size = new Size(75, 23);
            num_InitValue.TabIndex = 6;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(214, 148);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(75, 39);
            btn_Remove.TabIndex = 7;
            btn_Remove.Text = "Remove Selected";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(6, 71);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(39, 15);
            lbl_Name.TabIndex = 8;
            lbl_Name.Text = "Name";
            // 
            // lbl_InitValue
            // 
            lbl_InitValue.AutoSize = true;
            lbl_InitValue.Location = new Point(214, 72);
            lbl_InitValue.Name = "lbl_InitValue";
            lbl_InitValue.Size = new Size(52, 15);
            lbl_InitValue.TabIndex = 9;
            lbl_InitValue.Text = "Initiative";
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(216, 346);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(75, 31);
            btn_Next.TabIndex = 10;
            btn_Next.Text = "Next Turn";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // lbl_Round
            // 
            lbl_Round.AutoSize = true;
            lbl_Round.Location = new Point(7, 41);
            lbl_Round.Name = "lbl_Round";
            lbl_Round.Size = new Size(45, 15);
            lbl_Round.TabIndex = 11;
            lbl_Round.Text = "Round:";
            // 
            // btn_EndInit
            // 
            btn_EndInit.Location = new Point(107, 6);
            btn_EndInit.Name = "btn_EndInit";
            btn_EndInit.Size = new Size(93, 32);
            btn_EndInit.TabIndex = 12;
            btn_EndInit.Text = "End Combat";
            btn_EndInit.UseVisualStyleBackColor = true;
            btn_EndInit.Click += btn_EndInit_Click;
            // 
            // lbl_RoundNum
            // 
            lbl_RoundNum.AutoSize = true;
            lbl_RoundNum.Location = new Point(49, 41);
            lbl_RoundNum.Name = "lbl_RoundNum";
            lbl_RoundNum.Size = new Size(87, 15);
            lbl_RoundNum.TabIndex = 13;
            lbl_RoundNum.Text = "lbl_RoundNum";
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(206, 6);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(85, 32);
            btn_Reset.TabIndex = 14;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // InitTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(294, 389);
            Controls.Add(btn_Reset);
            Controls.Add(lbl_RoundNum);
            Controls.Add(btn_EndInit);
            Controls.Add(lbl_Round);
            Controls.Add(btn_Next);
            Controls.Add(lbl_InitValue);
            Controls.Add(lbl_Name);
            Controls.Add(btn_Remove);
            Controls.Add(num_InitValue);
            Controls.Add(txtBox_Name);
            Controls.Add(btn_StartInit);
            Controls.Add(btn_addToInitOrder);
            Controls.Add(lstBox_Init);
            Controls.Add(lbl_Timer);
            Name = "InitTracker";
            Text = "Initiative Tracker";
            ((System.ComponentModel.ISupportInitialize)num_InitValue).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }


        #endregion

        private Label lbl_Timer;
        private ListBox lstBox_Init;
        private Button btn_addToInitOrder;
        private Button btn_StartInit;
        private TextBox txtBox_Name;
        private NumericUpDown num_InitValue;
        private Button btn_Remove;
        private Label lbl_Name;
        private Label lbl_InitValue;
        private Button btn_Next;
        private Label lbl_Round;
        private Button btn_EndInit;
        private Label lbl_RoundNum;
        private Button btn_Reset;
    }
}