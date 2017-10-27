namespace FightClub
{
    partial class Game
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarPlayer1 = new System.Windows.Forms.ProgressBar();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonHead = new System.Windows.Forms.Button();
            this.buttonBody = new System.Windows.Forms.Button();
            this.buttonLegs = new System.Windows.Forms.Button();
            this.lbRound = new System.Windows.Forms.Label();
            this.lbPlayer1 = new System.Windows.Forms.Label();
            this.lbPlayer2 = new System.Windows.Forms.Label();
            this.progressBarPlayer2 = new System.Windows.Forms.ProgressBar();
            this.buttonSound = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.lbTurn = new System.Windows.Forms.Label();
            this.lbHP1 = new System.Windows.Forms.Label();
            this.lbHP2 = new System.Windows.Forms.Label();
            this.pictureBoxJim = new System.Windows.Forms.PictureBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.C1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJim)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            resources.ApplyResources(this.pictureBox1, "pictureBox1");
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.TabStop = false;
            // 
            // progressBarPlayer1
            // 
            this.progressBarPlayer1.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.progressBarPlayer1, "progressBarPlayer1");
            this.progressBarPlayer1.Name = "progressBarPlayer1";
            // 
            // pictureBox2
            // 
            resources.ApplyResources(this.pictureBox2, "pictureBox2");
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.TabStop = false;
            // 
            // buttonHead
            // 
            this.buttonHead.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonHead, "buttonHead");
            this.buttonHead.FlatAppearance.BorderSize = 0;
            this.buttonHead.Name = "buttonHead";
            this.buttonHead.UseVisualStyleBackColor = false;
            this.buttonHead.Click += new System.EventHandler(this.buttonHead_Click);
            // 
            // buttonBody
            // 
            this.buttonBody.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonBody, "buttonBody");
            this.buttonBody.FlatAppearance.BorderSize = 0;
            this.buttonBody.Name = "buttonBody";
            this.buttonBody.UseVisualStyleBackColor = false;
            this.buttonBody.Click += new System.EventHandler(this.buttonHead_Click);
            // 
            // buttonLegs
            // 
            this.buttonLegs.BackColor = System.Drawing.Color.Transparent;
            resources.ApplyResources(this.buttonLegs, "buttonLegs");
            this.buttonLegs.FlatAppearance.BorderSize = 0;
            this.buttonLegs.Name = "buttonLegs";
            this.buttonLegs.UseVisualStyleBackColor = true;
            this.buttonLegs.Click += new System.EventHandler(this.buttonHead_Click);
            // 
            // lbRound
            // 
            resources.ApplyResources(this.lbRound, "lbRound");
            this.lbRound.BackColor = System.Drawing.Color.Transparent;
            this.lbRound.ForeColor = System.Drawing.Color.Red;
            this.lbRound.Name = "lbRound";
            // 
            // lbPlayer1
            // 
            resources.ApplyResources(this.lbPlayer1, "lbPlayer1");
            this.lbPlayer1.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.lbPlayer1.Name = "lbPlayer1";
            // 
            // lbPlayer2
            // 
            resources.ApplyResources(this.lbPlayer2, "lbPlayer2");
            this.lbPlayer2.BackColor = System.Drawing.Color.Transparent;
            this.lbPlayer2.ForeColor = System.Drawing.Color.Cyan;
            this.lbPlayer2.Name = "lbPlayer2";
            // 
            // progressBarPlayer2
            // 
            this.progressBarPlayer2.BackColor = System.Drawing.Color.White;
            this.progressBarPlayer2.ForeColor = System.Drawing.Color.Red;
            resources.ApplyResources(this.progressBarPlayer2, "progressBarPlayer2");
            this.progressBarPlayer2.Name = "progressBarPlayer2";
            // 
            // buttonSound
            // 
            resources.ApplyResources(this.buttonSound, "buttonSound");
            this.buttonSound.Name = "buttonSound";
            this.buttonSound.UseVisualStyleBackColor = true;
            this.buttonSound.Click += new System.EventHandler(this.buttonSound_Click);
            // 
            // button4
            // 
            resources.ApplyResources(this.button4, "button4");
            this.button4.Name = "button4";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // lbTurn
            // 
            resources.ApplyResources(this.lbTurn, "lbTurn");
            this.lbTurn.BackColor = System.Drawing.Color.Transparent;
            this.lbTurn.ForeColor = System.Drawing.Color.Snow;
            this.lbTurn.Name = "lbTurn";
            // 
            // lbHP1
            // 
            resources.ApplyResources(this.lbHP1, "lbHP1");
            this.lbHP1.BackColor = System.Drawing.Color.Transparent;
            this.lbHP1.ForeColor = System.Drawing.Color.Lime;
            this.lbHP1.Name = "lbHP1";
            // 
            // lbHP2
            // 
            resources.ApplyResources(this.lbHP2, "lbHP2");
            this.lbHP2.BackColor = System.Drawing.Color.Transparent;
            this.lbHP2.ForeColor = System.Drawing.Color.Lime;
            this.lbHP2.Name = "lbHP2";
            // 
            // pictureBoxJim
            // 
            resources.ApplyResources(this.pictureBoxJim, "pictureBoxJim");
            this.pictureBoxJim.BackColor = System.Drawing.Color.Transparent;
            this.pictureBoxJim.Name = "pictureBoxJim";
            this.pictureBoxJim.TabStop = false;
            // 
            // btnReset
            // 
            resources.ApplyResources(this.btnReset, "btnReset");
            this.btnReset.ForeColor = System.Drawing.Color.Red;
            this.btnReset.Name = "btnReset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.C1});
            resources.ApplyResources(this.dataGridView1, "dataGridView1");
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.StandardTab = true;
            // 
            // C1
            // 
            resources.ApplyResources(this.C1, "C1");
            this.C1.Name = "C1";
            this.C1.ReadOnly = true;
            // 
            // Game
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.pictureBoxJim);
            this.Controls.Add(this.lbHP2);
            this.Controls.Add(this.lbHP1);
            this.Controls.Add(this.lbTurn);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonSound);
            this.Controls.Add(this.lbPlayer2);
            this.Controls.Add(this.progressBarPlayer2);
            this.Controls.Add(this.lbPlayer1);
            this.Controls.Add(this.lbRound);
            this.Controls.Add(this.buttonLegs);
            this.Controls.Add(this.buttonBody);
            this.Controls.Add(this.buttonHead);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.progressBarPlayer1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Game";
            this.Load += new System.EventHandler(this.Game_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxJim)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarPlayer1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button buttonHead;
        private System.Windows.Forms.Button buttonBody;
        private System.Windows.Forms.Button buttonLegs;
        private System.Windows.Forms.Label lbRound;
        private System.Windows.Forms.Label lbPlayer1;
        private System.Windows.Forms.Label lbPlayer2;
        private System.Windows.Forms.ProgressBar progressBarPlayer2;
        private System.Windows.Forms.Button buttonSound;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label lbTurn;
        private System.Windows.Forms.Label lbHP1;
        private System.Windows.Forms.Label lbHP2;
        private System.Windows.Forms.PictureBox pictureBoxJim;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn C1;
    }
}

