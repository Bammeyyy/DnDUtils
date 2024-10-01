namespace DnDUtils
{
    partial class MainWindow
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_initTracker = new Button();
            btn_Lookup = new Button();
            btn_Soundboard = new Button();
            SuspendLayout();
            // 
            // btn_initTracker
            // 
            btn_initTracker.Location = new Point(12, 12);
            btn_initTracker.Name = "btn_initTracker";
            btn_initTracker.Size = new Size(135, 77);
            btn_initTracker.TabIndex = 0;
            btn_initTracker.TabStop = false;
            btn_initTracker.Text = "Initiative Tracker";
            btn_initTracker.UseVisualStyleBackColor = true;
            btn_initTracker.Click += btn_initTracker_Click;
            // 
            // btn_Lookup
            // 
            btn_Lookup.Location = new Point(153, 12);
            btn_Lookup.Name = "btn_Lookup";
            btn_Lookup.Size = new Size(135, 77);
            btn_Lookup.TabIndex = 1;
            btn_Lookup.TabStop = false;
            btn_Lookup.Text = "Lookup";
            btn_Lookup.UseVisualStyleBackColor = true;
            btn_Lookup.Click += btn_Lookup_Click;
            // 
            // btn_Soundboard
            // 
            btn_Soundboard.Location = new Point(294, 12);
            btn_Soundboard.Name = "btn_Soundboard";
            btn_Soundboard.Size = new Size(135, 77);
            btn_Soundboard.TabIndex = 2;
            btn_Soundboard.TabStop = false;
            btn_Soundboard.Text = "Soundboard";
            btn_Soundboard.UseVisualStyleBackColor = true;
            btn_Soundboard.Click += btn_Soundboard_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 100);
            Controls.Add(btn_Soundboard);
            Controls.Add(btn_Lookup);
            Controls.Add(btn_initTracker);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "MainWindow";
            SizeGripStyle = SizeGripStyle.Hide;
            Text = "D&D Utilities";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_initTracker;
        private Button btn_Lookup;
        private Button btn_Soundboard;
    }
}
