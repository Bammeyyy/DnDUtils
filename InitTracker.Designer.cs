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
            num_HPValue = new NumericUpDown();
            lbl_HP = new Label();
            lbl_Dmg = new Label();
            num_Dmg = new NumericUpDown();
            btn_Dmg = new Button();
            btn_Heal = new Button();
            btn_Prev = new Button();
            ((System.ComponentModel.ISupportInitialize)num_InitValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_HPValue).BeginInit();
            ((System.ComponentModel.ISupportInitialize)num_Dmg).BeginInit();
            SuspendLayout();
            // 
            // lbl_Timer
            // 
            lbl_Timer.Font = new Font("Segoe UI", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbl_Timer.Location = new Point(245, 55);
            lbl_Timer.Name = "lbl_Timer";
            lbl_Timer.Size = new Size(88, 40);
            lbl_Timer.TabIndex = 0;
            lbl_Timer.Text = "00:00";
            lbl_Timer.TextAlign = ContentAlignment.TopRight;
            // 
            // lstBox_Init
            // 
            lstBox_Init.FormattingEnabled = true;
            lstBox_Init.Location = new Point(7, 157);
            lstBox_Init.Margin = new Padding(3, 4, 3, 4);
            lstBox_Init.Name = "lstBox_Init";
            lstBox_Init.Size = new Size(230, 344);
            lstBox_Init.TabIndex = 1;
            lstBox_Init.SelectedIndexChanged += lstBox_Init_SelectedIndexChanged;
            // 
            // btn_addToInitOrder
            // 
            btn_addToInitOrder.Location = new Point(243, 210);
            btn_addToInitOrder.Margin = new Padding(3, 4, 3, 4);
            btn_addToInitOrder.Name = "btn_addToInitOrder";
            btn_addToInitOrder.Size = new Size(86, 31);
            btn_addToInitOrder.TabIndex = 2;
            btn_addToInitOrder.Text = "Add";
            btn_addToInitOrder.UseVisualStyleBackColor = true;
            btn_addToInitOrder.Click += btn_addToInitOrder_Click;
            // 
            // btn_StartInit
            // 
            btn_StartInit.Location = new Point(7, 8);
            btn_StartInit.Margin = new Padding(3, 4, 3, 4);
            btn_StartInit.Name = "btn_StartInit";
            btn_StartInit.Size = new Size(109, 43);
            btn_StartInit.TabIndex = 4;
            btn_StartInit.Text = "Start Combat";
            btn_StartInit.UseVisualStyleBackColor = true;
            btn_StartInit.Click += btn_StartInit_Click;
            // 
            // txtBox_Name
            // 
            txtBox_Name.Location = new Point(7, 119);
            txtBox_Name.Margin = new Padding(3, 4, 3, 4);
            txtBox_Name.Name = "txtBox_Name";
            txtBox_Name.Size = new Size(230, 27);
            txtBox_Name.TabIndex = 5;
            // 
            // num_InitValue
            // 
            num_InitValue.Location = new Point(245, 120);
            num_InitValue.Margin = new Padding(3, 4, 3, 4);
            num_InitValue.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_InitValue.Name = "num_InitValue";
            num_InitValue.Size = new Size(86, 27);
            num_InitValue.TabIndex = 6;
            // 
            // btn_Remove
            // 
            btn_Remove.Location = new Point(243, 249);
            btn_Remove.Margin = new Padding(3, 4, 3, 4);
            btn_Remove.Name = "btn_Remove";
            btn_Remove.Size = new Size(86, 52);
            btn_Remove.TabIndex = 7;
            btn_Remove.Text = "Remove Selected";
            btn_Remove.UseVisualStyleBackColor = true;
            btn_Remove.Click += btn_Remove_Click;
            // 
            // lbl_Name
            // 
            lbl_Name.AutoSize = true;
            lbl_Name.Location = new Point(7, 95);
            lbl_Name.Name = "lbl_Name";
            lbl_Name.Size = new Size(49, 20);
            lbl_Name.TabIndex = 8;
            lbl_Name.Text = "Name";
            // 
            // lbl_InitValue
            // 
            lbl_InitValue.AutoSize = true;
            lbl_InitValue.Location = new Point(245, 96);
            lbl_InitValue.Name = "lbl_InitValue";
            lbl_InitValue.Size = new Size(66, 20);
            lbl_InitValue.TabIndex = 9;
            lbl_InitValue.Text = "Initiative";
            // 
            // btn_Next
            // 
            btn_Next.Location = new Point(338, 52);
            btn_Next.Margin = new Padding(3, 4, 3, 4);
            btn_Next.Name = "btn_Next";
            btn_Next.Size = new Size(113, 43);
            btn_Next.TabIndex = 10;
            btn_Next.Text = "Next Turn";
            btn_Next.UseVisualStyleBackColor = true;
            btn_Next.Click += btn_Next_Click;
            // 
            // lbl_Round
            // 
            lbl_Round.AutoSize = true;
            lbl_Round.Location = new Point(8, 55);
            lbl_Round.Name = "lbl_Round";
            lbl_Round.Size = new Size(55, 20);
            lbl_Round.TabIndex = 11;
            lbl_Round.Text = "Round:";
            // 
            // btn_EndInit
            // 
            btn_EndInit.Location = new Point(122, 8);
            btn_EndInit.Margin = new Padding(3, 4, 3, 4);
            btn_EndInit.Name = "btn_EndInit";
            btn_EndInit.Size = new Size(106, 43);
            btn_EndInit.TabIndex = 12;
            btn_EndInit.Text = "End Combat";
            btn_EndInit.UseVisualStyleBackColor = true;
            btn_EndInit.Click += btn_EndInit_Click;
            // 
            // lbl_RoundNum
            // 
            lbl_RoundNum.AutoSize = true;
            lbl_RoundNum.Location = new Point(56, 55);
            lbl_RoundNum.Name = "lbl_RoundNum";
            lbl_RoundNum.Size = new Size(107, 20);
            lbl_RoundNum.TabIndex = 13;
            lbl_RoundNum.Text = "lbl_RoundNum";
            // 
            // btn_Reset
            // 
            btn_Reset.Location = new Point(235, 8);
            btn_Reset.Margin = new Padding(3, 4, 3, 4);
            btn_Reset.Name = "btn_Reset";
            btn_Reset.Size = new Size(97, 43);
            btn_Reset.TabIndex = 14;
            btn_Reset.Text = "Reset";
            btn_Reset.UseVisualStyleBackColor = true;
            btn_Reset.Click += btn_Reset_Click;
            // 
            // num_HPValue
            // 
            num_HPValue.Location = new Point(243, 176);
            num_HPValue.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_HPValue.Name = "num_HPValue";
            num_HPValue.Size = new Size(81, 27);
            num_HPValue.TabIndex = 15;
            // 
            // lbl_HP
            // 
            lbl_HP.AutoSize = true;
            lbl_HP.Location = new Point(245, 153);
            lbl_HP.Name = "lbl_HP";
            lbl_HP.Size = new Size(28, 20);
            lbl_HP.TabIndex = 16;
            lbl_HP.Text = "HP";
            // 
            // lbl_Dmg
            // 
            lbl_Dmg.AutoSize = true;
            lbl_Dmg.Location = new Point(348, 95);
            lbl_Dmg.Name = "lbl_Dmg";
            lbl_Dmg.Size = new Size(103, 20);
            lbl_Dmg.TabIndex = 17;
            lbl_Dmg.Text = "Damage/Heal";
            // 
            // num_Dmg
            // 
            num_Dmg.Location = new Point(348, 118);
            num_Dmg.Maximum = new decimal(new int[] { 5000, 0, 0, 0 });
            num_Dmg.Name = "num_Dmg";
            num_Dmg.Size = new Size(103, 27);
            num_Dmg.TabIndex = 18;
            // 
            // btn_Dmg
            // 
            btn_Dmg.Location = new Point(348, 151);
            btn_Dmg.Name = "btn_Dmg";
            btn_Dmg.Size = new Size(103, 29);
            btn_Dmg.TabIndex = 19;
            btn_Dmg.Text = "Damage";
            btn_Dmg.UseVisualStyleBackColor = true;
            btn_Dmg.Click += btn_Dmg_Click;
            // 
            // btn_Heal
            // 
            btn_Heal.Location = new Point(348, 186);
            btn_Heal.Name = "btn_Heal";
            btn_Heal.Size = new Size(103, 29);
            btn_Heal.TabIndex = 20;
            btn_Heal.Text = "Heal";
            btn_Heal.UseVisualStyleBackColor = true;
            btn_Heal.Click += btn_Heal_Click;
            // 
            // btn_Prev
            // 
            btn_Prev.Location = new Point(338, 8);
            btn_Prev.Name = "btn_Prev";
            btn_Prev.Size = new Size(113, 43);
            btn_Prev.TabIndex = 21;
            btn_Prev.Text = "Previous Turn";
            btn_Prev.UseVisualStyleBackColor = true;
            btn_Prev.Click += btn_Prev_Click;
            // 
            // InitTracker
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(458, 519);
            Controls.Add(btn_Prev);
            Controls.Add(btn_Heal);
            Controls.Add(btn_Dmg);
            Controls.Add(num_Dmg);
            Controls.Add(lbl_Dmg);
            Controls.Add(lbl_HP);
            Controls.Add(num_HPValue);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "InitTracker";
            Text = "Initiative Tracker";
            ((System.ComponentModel.ISupportInitialize)num_InitValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_HPValue).EndInit();
            ((System.ComponentModel.ISupportInitialize)num_Dmg).EndInit();
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
        private NumericUpDown num_HPValue;
        private Label lbl_HP;
        private Label lbl_Dmg;
        private NumericUpDown num_Dmg;
        private Button btn_Dmg;
        private Button btn_Heal;
        private Button btn_Prev;
    }
}