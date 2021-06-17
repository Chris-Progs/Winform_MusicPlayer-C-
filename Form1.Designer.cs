
namespace AudioPlayer
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.listOfSongs = new System.Windows.Forms.ListBox();
            this.btnStartSong = new System.Windows.Forms.Button();
            this.btnNextSong = new System.Windows.Forms.Button();
            this.btnBackSong = new System.Windows.Forms.Button();
            this.btnLastSong = new System.Windows.Forms.Button();
            this.axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            this.btnAddSong = new System.Windows.Forms.Button();
            this.btnRemoveSong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).BeginInit();
            this.SuspendLayout();
            // 
            // listOfSongs
            // 
            this.listOfSongs.FormattingEnabled = true;
            this.listOfSongs.Location = new System.Drawing.Point(12, 12);
            this.listOfSongs.Name = "listOfSongs";
            this.listOfSongs.Size = new System.Drawing.Size(214, 225);
            this.listOfSongs.TabIndex = 0;
            // 
            // btnStartSong
            // 
            this.btnStartSong.Location = new System.Drawing.Point(232, 20);
            this.btnStartSong.Name = "btnStartSong";
            this.btnStartSong.Size = new System.Drawing.Size(89, 30);
            this.btnStartSong.TabIndex = 1;
            this.btnStartSong.Text = "Start";
            this.btnStartSong.UseVisualStyleBackColor = true;
            this.btnStartSong.Click += new System.EventHandler(this.btnStartSong_Click);
            // 
            // btnNextSong
            // 
            this.btnNextSong.Location = new System.Drawing.Point(232, 56);
            this.btnNextSong.Name = "btnNextSong";
            this.btnNextSong.Size = new System.Drawing.Size(89, 30);
            this.btnNextSong.TabIndex = 2;
            this.btnNextSong.Text = "Next";
            this.btnNextSong.UseVisualStyleBackColor = true;
            this.btnNextSong.Click += new System.EventHandler(this.btnNextSong_Click);
            // 
            // btnBackSong
            // 
            this.btnBackSong.Location = new System.Drawing.Point(232, 92);
            this.btnBackSong.Name = "btnBackSong";
            this.btnBackSong.Size = new System.Drawing.Size(89, 30);
            this.btnBackSong.TabIndex = 3;
            this.btnBackSong.Text = "Back";
            this.btnBackSong.UseVisualStyleBackColor = true;
            this.btnBackSong.Click += new System.EventHandler(this.btnBackSong_Click);
            // 
            // btnLastSong
            // 
            this.btnLastSong.Location = new System.Drawing.Point(232, 128);
            this.btnLastSong.Name = "btnLastSong";
            this.btnLastSong.Size = new System.Drawing.Size(89, 30);
            this.btnLastSong.TabIndex = 4;
            this.btnLastSong.Text = "Last";
            this.btnLastSong.UseVisualStyleBackColor = true;
            this.btnLastSong.Click += new System.EventHandler(this.btnLastSong_Click);
            // 
            // axWindowsMediaPlayer1
            // 
            this.axWindowsMediaPlayer1.Enabled = true;
            this.axWindowsMediaPlayer1.Location = new System.Drawing.Point(12, 252);
            this.axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            this.axWindowsMediaPlayer1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axWindowsMediaPlayer1.OcxState")));
            this.axWindowsMediaPlayer1.Size = new System.Drawing.Size(309, 153);
            this.axWindowsMediaPlayer1.TabIndex = 5;
            // 
            // btnAddSong
            // 
            this.btnAddSong.Location = new System.Drawing.Point(232, 164);
            this.btnAddSong.Name = "btnAddSong";
            this.btnAddSong.Size = new System.Drawing.Size(89, 30);
            this.btnAddSong.TabIndex = 6;
            this.btnAddSong.Text = "Add";
            this.btnAddSong.UseVisualStyleBackColor = true;
            this.btnAddSong.Click += new System.EventHandler(this.btnAddSong_Click);
            // 
            // btnRemoveSong
            // 
            this.btnRemoveSong.Location = new System.Drawing.Point(232, 200);
            this.btnRemoveSong.Name = "btnRemoveSong";
            this.btnRemoveSong.Size = new System.Drawing.Size(89, 30);
            this.btnRemoveSong.TabIndex = 7;
            this.btnRemoveSong.Text = "Remove";
            this.btnRemoveSong.UseVisualStyleBackColor = true;
            this.btnRemoveSong.Click += new System.EventHandler(this.btnRemoveSong_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 417);
            this.Controls.Add(this.btnRemoveSong);
            this.Controls.Add(this.btnAddSong);
            this.Controls.Add(this.axWindowsMediaPlayer1);
            this.Controls.Add(this.btnLastSong);
            this.Controls.Add(this.btnBackSong);
            this.Controls.Add(this.btnNextSong);
            this.Controls.Add(this.btnStartSong);
            this.Controls.Add(this.listOfSongs);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.axWindowsMediaPlayer1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox listOfSongs;
        private System.Windows.Forms.Button btnStartSong;
        private System.Windows.Forms.Button btnNextSong;
        private System.Windows.Forms.Button btnBackSong;
        private System.Windows.Forms.Button btnLastSong;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private System.Windows.Forms.Button btnAddSong;
        private System.Windows.Forms.Button btnRemoveSong;
    }
}

