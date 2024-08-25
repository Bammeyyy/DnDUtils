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
<<<<<<< Updated upstream
            btn_database = new Button();
            btn_soundboard = new Button();
=======
            button2 = new Button();
            button3 = new Button();
            button4 = new Button();
>>>>>>> Stashed changes
            SuspendLayout();
            // 
            // btn_initTracker
            // 
            btn_initTracker.Location = new Point(12, 12);
            btn_initTracker.Name = "btn_initTracker";
            btn_initTracker.Size = new Size(176, 65);
            btn_initTracker.TabIndex = 0;
            btn_initTracker.Text = "Initiative Tracker";
            btn_initTracker.UseVisualStyleBackColor = true;
<<<<<<< Updated upstream
            btn_initTracker.Click += this.btn_initTracker_Click;
=======
            btn_initTracker.Click += btn_initTracker_Click;
>>>>>>> Stashed changes
            // 
            // btn_database
            // 
            btn_database.Location = new Point(12, 83);
            btn_database.Name = "btn_database";
            btn_database.Size = new Size(176, 65);
            btn_database.TabIndex = 0;
            btn_database.Text = "Database";
            btn_database.UseVisualStyleBackColor = true;
            // 
            // btn_soundboard
            // 
            btn_soundboard.Location = new Point(12, 154);
            btn_soundboard.Name = "btn_soundboard";
            btn_soundboard.Size = new Size(176, 65);
            btn_soundboard.TabIndex = 0;
            btn_soundboard.Text = "Soundboard";
            btn_soundboard.UseVisualStyleBackColor = true;
            btn_soundboard.Click += btn_soundboard_Click;
            // 
            // MainWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
<<<<<<< Updated upstream
            Controls.Add(btn_soundboard);
            Controls.Add(btn_database);
=======
            Controls.Add(button4);
            Controls.Add(button3);
            Controls.Add(button2);
>>>>>>> Stashed changes
            Controls.Add(btn_initTracker);
            Name = "MainWindow";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_initTracker;
<<<<<<< Updated upstream
        private Button btn_database;
        private Button btn_soundboard;
=======
        private Button button2;
        private Button button3;
        private Button button4;
>>>>>>> Stashed changes
    }
}
