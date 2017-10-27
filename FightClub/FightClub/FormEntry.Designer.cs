namespace FightClub
{
    partial class FormEntry
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormEntry));
            this.lbWolf_say = new System.Windows.Forms.Label();
            this.chbLog = new System.Windows.Forms.CheckBox();
            this.btnPlay = new System.Windows.Forms.Button();
            this.tbName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbHit = new System.Windows.Forms.ComboBox();
            this.btnRules = new System.Windows.Forms.Button();
            this.toolTipPlay = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // lbWolf_say
            // 
            this.lbWolf_say.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbWolf_say.AutoSize = true;
            this.lbWolf_say.BackColor = System.Drawing.Color.Transparent;
            this.lbWolf_say.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbWolf_say.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.lbWolf_say.Location = new System.Drawing.Point(32, 44);
            this.lbWolf_say.Name = "lbWolf_say";
            this.lbWolf_say.Size = new System.Drawing.Size(155, 50);
            this.lbWolf_say.TabIndex = 0;
            this.lbWolf_say.Text = "Welcome \r\nin our club, friend!";
            // 
            // chbLog
            // 
            this.chbLog.AutoSize = true;
            this.chbLog.BackColor = System.Drawing.Color.Transparent;
            this.chbLog.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.chbLog.ForeColor = System.Drawing.Color.Red;
            this.chbLog.Location = new System.Drawing.Point(354, 257);
            this.chbLog.Name = "chbLog";
            this.chbLog.Size = new System.Drawing.Size(94, 27);
            this.chbLog.TabIndex = 1;
            this.chbLog.Text = "Log to file";
            this.chbLog.UseVisualStyleBackColor = false;
            // 
            // btnPlay
            // 
            this.btnPlay.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPlay.ForeColor = System.Drawing.Color.Red;
            this.btnPlay.Location = new System.Drawing.Point(386, 324);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(107, 47);
            this.btnPlay.TabIndex = 2;
            this.btnPlay.Text = "Play!";
            this.toolTipPlay.SetToolTip(this.btnPlay, "Button don\'t work, if you don\'t write name \r\nand selected number of hits\r\n");
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(354, 136);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(174, 20);
            this.tbName.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(325, 108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(203, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter your name, fighter";
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(337, 170);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 46);
            this.label2.TabIndex = 6;
            this.label2.Text = "Selected number of hits \r\nper round ";
            // 
            // cbHit
            // 
            this.cbHit.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.cbHit.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbHit.FormattingEnabled = true;
            this.cbHit.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cbHit.Location = new System.Drawing.Point(354, 219);
            this.cbHit.Name = "cbHit";
            this.cbHit.Size = new System.Drawing.Size(176, 21);
            this.cbHit.TabIndex = 7;
            // 
            // btnRules
            // 
            this.btnRules.Font = new System.Drawing.Font("Papyrus", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRules.ForeColor = System.Drawing.Color.Red;
            this.btnRules.Location = new System.Drawing.Point(27, 324);
            this.btnRules.Name = "btnRules";
            this.btnRules.Size = new System.Drawing.Size(107, 47);
            this.btnRules.TabIndex = 8;
            this.btnRules.Text = "RULES";
            this.btnRules.UseVisualStyleBackColor = true;
            this.btnRules.Click += new System.EventHandler(this.btnRules_Click);
            // 
            // FormEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(540, 410);
            this.Controls.Add(this.btnRules);
            this.Controls.Add(this.cbHit);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbName);
            this.Controls.Add(this.btnPlay);
            this.Controls.Add(this.chbLog);
            this.Controls.Add(this.lbWolf_say);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FormEntry";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome to our club";
            this.Load += new System.EventHandler(this.FormEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbWolf_say;
        private System.Windows.Forms.CheckBox chbLog;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbHit;
        private System.Windows.Forms.Button btnRules;
        private System.Windows.Forms.ToolTip toolTipPlay;
    }
}