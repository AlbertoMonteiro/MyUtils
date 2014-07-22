namespace BackupWatcher
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
            this.directoryWatcher = new System.IO.FileSystemWatcher();
            this.label1 = new System.Windows.Forms.Label();
            this.directoryDisplay = new System.Windows.Forms.Label();
            this.logDisplay = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.folderDialog = new System.Windows.Forms.FolderBrowserDialog();
            ((System.ComponentModel.ISupportInitialize)(this.directoryWatcher)).BeginInit();
            this.SuspendLayout();
            // 
            // directoryWatcher
            // 
            this.directoryWatcher.EnableRaisingEvents = true;
            this.directoryWatcher.SynchronizingObject = this;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Diretório:";
            // 
            // directoryDisplay
            // 
            this.directoryDisplay.AutoSize = true;
            this.directoryDisplay.Location = new System.Drawing.Point(64, 9);
            this.directoryDisplay.Name = "directoryDisplay";
            this.directoryDisplay.Size = new System.Drawing.Size(35, 13);
            this.directoryDisplay.TabIndex = 1;
            this.directoryDisplay.Text = "directoryDisplay";
            // 
            // logDisplay
            // 
            this.logDisplay.Location = new System.Drawing.Point(12, 54);
            this.logDisplay.Multiline = true;
            this.logDisplay.Name = "logDisplay";
            this.logDisplay.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.logDisplay.Size = new System.Drawing.Size(400, 195);
            this.logDisplay.TabIndex = 2;
            this.logDisplay.WordWrap = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 25);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(400, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Alterar diretório";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(424, 261);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.logDisplay);
            this.Controls.Add(this.directoryDisplay);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Backup Renamer";
            ((System.ComponentModel.ISupportInitialize)(this.directoryWatcher)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.IO.FileSystemWatcher directoryWatcher;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox logDisplay;
        private System.Windows.Forms.Label directoryDisplay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FolderBrowserDialog folderDialog;
    }
}

