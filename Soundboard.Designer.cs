namespace DnDUtils
{
    partial class Soundboard
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
            list_Characters = new ComboBox();
            btn_PlayCharacters = new Button();
            btn_Stop = new Button();
            lbl_KillingBlows = new Label();
            lbl_Ambience = new Label();
            list_Ambience = new ComboBox();
            btn_PlayAmbience = new Button();
            lbl_Memes = new Label();
            list_Memes = new ComboBox();
            btn_PlayMemes = new Button();
            btn_Wow = new Button();
            btn_Crickets = new Button();
            btn_FBI = new Button();
            btn_Bruh = new Button();
            SuspendLayout();
            // 
            // list_Characters
            // 
            list_Characters.FormattingEnabled = true;
            list_Characters.Location = new Point(14, 36);
            list_Characters.Margin = new Padding(3, 4, 3, 4);
            list_Characters.Name = "list_Characters";
            list_Characters.Size = new Size(138, 28);
            list_Characters.TabIndex = 1;
            // 
            // btn_PlayCharacters
            // 
            btn_PlayCharacters.Location = new Point(169, 36);
            btn_PlayCharacters.Margin = new Padding(3, 4, 3, 4);
            btn_PlayCharacters.Name = "btn_PlayCharacters";
            btn_PlayCharacters.Size = new Size(86, 31);
            btn_PlayCharacters.TabIndex = 2;
            btn_PlayCharacters.Text = "Play";
            btn_PlayCharacters.UseVisualStyleBackColor = true;
            btn_PlayCharacters.Click += btn_PlayCharacters_Click;
            // 
            // btn_Stop
            // 
            btn_Stop.Font = new Font("Segoe UI", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_Stop.ForeColor = SystemColors.HotTrack;
            btn_Stop.Location = new Point(297, 36);
            btn_Stop.Margin = new Padding(3, 4, 3, 4);
            btn_Stop.Name = "btn_Stop";
            btn_Stop.Size = new Size(286, 363);
            btn_Stop.TabIndex = 3;
            btn_Stop.Text = "STOP";
            btn_Stop.UseVisualStyleBackColor = true;
            btn_Stop.Click += btn_Stop_Click;
            // 
            // lbl_KillingBlows
            // 
            lbl_KillingBlows.AutoSize = true;
            lbl_KillingBlows.Location = new Point(14, 12);
            lbl_KillingBlows.Name = "lbl_KillingBlows";
            lbl_KillingBlows.Size = new Size(116, 20);
            lbl_KillingBlows.TabIndex = 4;
            lbl_KillingBlows.Text = "Character Songs";
            // 
            // lbl_Ambience
            // 
            lbl_Ambience.AutoSize = true;
            lbl_Ambience.Location = new Point(14, 83);
            lbl_Ambience.Name = "lbl_Ambience";
            lbl_Ambience.Size = new Size(76, 20);
            lbl_Ambience.TabIndex = 5;
            lbl_Ambience.Text = "Ambience";
            // 
            // list_Ambience
            // 
            list_Ambience.FormattingEnabled = true;
            list_Ambience.Location = new Point(14, 107);
            list_Ambience.Margin = new Padding(3, 4, 3, 4);
            list_Ambience.Name = "list_Ambience";
            list_Ambience.Size = new Size(138, 28);
            list_Ambience.TabIndex = 1;
            // 
            // btn_PlayAmbience
            // 
            btn_PlayAmbience.Location = new Point(169, 107);
            btn_PlayAmbience.Margin = new Padding(3, 4, 3, 4);
            btn_PlayAmbience.Name = "btn_PlayAmbience";
            btn_PlayAmbience.Size = new Size(86, 31);
            btn_PlayAmbience.TabIndex = 2;
            btn_PlayAmbience.Text = "Play";
            btn_PlayAmbience.UseVisualStyleBackColor = true;
            btn_PlayAmbience.Click += btn_PlayAmbience_Click;
            // 
            // lbl_Memes
            // 
            lbl_Memes.AutoSize = true;
            lbl_Memes.Location = new Point(14, 187);
            lbl_Memes.Name = "lbl_Memes";
            lbl_Memes.Size = new Size(57, 20);
            lbl_Memes.TabIndex = 6;
            lbl_Memes.Text = "Memes";
            // 
            // list_Memes
            // 
            list_Memes.FormattingEnabled = true;
            list_Memes.Location = new Point(13, 211);
            list_Memes.Margin = new Padding(3, 4, 3, 4);
            list_Memes.Name = "list_Memes";
            list_Memes.Size = new Size(138, 28);
            list_Memes.TabIndex = 1;
            // 
            // btn_PlayMemes
            // 
            btn_PlayMemes.Location = new Point(169, 211);
            btn_PlayMemes.Margin = new Padding(3, 4, 3, 4);
            btn_PlayMemes.Name = "btn_PlayMemes";
            btn_PlayMemes.Size = new Size(86, 31);
            btn_PlayMemes.TabIndex = 2;
            btn_PlayMemes.Text = "Play";
            btn_PlayMemes.UseVisualStyleBackColor = true;
            btn_PlayMemes.Click += btn_PlayMemes_Click;
            // 
            // btn_Wow
            // 
            btn_Wow.Location = new Point(14, 249);
            btn_Wow.Margin = new Padding(3, 4, 3, 4);
            btn_Wow.Name = "btn_Wow";
            btn_Wow.Size = new Size(86, 31);
            btn_Wow.TabIndex = 7;
            btn_Wow.Text = "Wow";
            btn_Wow.UseVisualStyleBackColor = true;
            btn_Wow.Click += btn_Wow_Click;
            // 
            // btn_Crickets
            // 
            btn_Crickets.Location = new Point(14, 288);
            btn_Crickets.Margin = new Padding(3, 4, 3, 4);
            btn_Crickets.Name = "btn_Crickets";
            btn_Crickets.Size = new Size(86, 31);
            btn_Crickets.TabIndex = 7;
            btn_Crickets.Text = "Crickets";
            btn_Crickets.UseVisualStyleBackColor = true;
            btn_Crickets.Click += btn_Crickets_Click;
            // 
            // btn_FBI
            // 
            btn_FBI.Location = new Point(13, 329);
            btn_FBI.Margin = new Padding(3, 4, 3, 4);
            btn_FBI.Name = "btn_FBI";
            btn_FBI.Size = new Size(86, 31);
            btn_FBI.TabIndex = 7;
            btn_FBI.Text = "FBI";
            btn_FBI.UseVisualStyleBackColor = true;
            btn_FBI.Click += btn_FBI_Click;
            // 
            // btn_Bruh
            // 
            btn_Bruh.Location = new Point(13, 368);
            btn_Bruh.Margin = new Padding(3, 4, 3, 4);
            btn_Bruh.Name = "btn_Bruh";
            btn_Bruh.Size = new Size(86, 31);
            btn_Bruh.TabIndex = 7;
            btn_Bruh.Text = "Bruh";
            btn_Bruh.UseVisualStyleBackColor = true;
            btn_Bruh.Click += btn_Bruh_Click;
            // 
            // Soundboard
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(608, 416);
            Controls.Add(btn_Bruh);
            Controls.Add(btn_FBI);
            Controls.Add(btn_Crickets);
            Controls.Add(btn_Wow);
            Controls.Add(lbl_Memes);
            Controls.Add(lbl_Ambience);
            Controls.Add(lbl_KillingBlows);
            Controls.Add(btn_Stop);
            Controls.Add(btn_PlayMemes);
            Controls.Add(btn_PlayAmbience);
            Controls.Add(btn_PlayCharacters);
            Controls.Add(list_Memes);
            Controls.Add(list_Ambience);
            Controls.Add(list_Characters);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "Soundboard";
            Text = "Soundboard";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox list_Characters;
        private Button btn_PlayCharacters;
        private Button btn_Stop;
        private Label lbl_KillingBlows;
        private Label lbl_Ambience;
        private ComboBox list_Ambience;
        private Button btn_PlayAmbience;
        private Label lbl_Memes;
        private ComboBox list_Memes;
        private Button btn_PlayMemes;
        private Button btn_Wow;
        private Button btn_Crickets;
        private Button btn_FBI;
        private Button btn_Bruh;
    }
}