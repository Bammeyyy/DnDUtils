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
            btn_eatDick = new Button();
            SuspendLayout();
            // 
            // btn_eatDick
            // 
            btn_eatDick.Location = new Point(135, 73);
            btn_eatDick.Name = "btn_eatDick";
            btn_eatDick.Size = new Size(500, 242);
            btn_eatDick.TabIndex = 0;
            btn_eatDick.Text = "eat dick";
            btn_eatDick.UseVisualStyleBackColor = true;
            btn_eatDick.Click += this.btn_eatDick_Click;
            // 
            // InitTracker
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_eatDick);
            Name = "InitTracker";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btn_eatDick;
    }
}