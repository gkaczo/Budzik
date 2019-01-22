namespace budzik
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label1 = new System.Windows.Forms.Label();
            this.lblAktualnyCzas = new System.Windows.Forms.Label();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.txtAlarm = new System.Windows.Forms.TextBox();
            this.btnAlarm = new System.Windows.Forms.Button();
            this.ikonaTray = new System.Windows.Forms.NotifyIcon(this.components);
            this.mnuTray = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.wyswietlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.txtWylacz = new System.Windows.Forms.TextBox();
            this.btnWylacz = new System.Windows.Forms.Button();
            this.mnuTray.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(63, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Czas";
            // 
            // lblAktualnyCzas
            // 
            this.lblAktualnyCzas.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblAktualnyCzas.Location = new System.Drawing.Point(109, 39);
            this.lblAktualnyCzas.Name = "lblAktualnyCzas";
            this.lblAktualnyCzas.Size = new System.Drawing.Size(100, 23);
            this.lblAktualnyCzas.TabIndex = 1;
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(66, 94);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Alarm";
            // 
            // txtAlarm
            // 
            this.txtAlarm.Location = new System.Drawing.Point(109, 94);
            this.txtAlarm.Name = "txtAlarm";
            this.txtAlarm.Size = new System.Drawing.Size(100, 20);
            this.txtAlarm.TabIndex = 3;
            this.txtAlarm.Visible = false;
            // 
            // btnAlarm
            // 
            this.btnAlarm.Location = new System.Drawing.Point(250, 94);
            this.btnAlarm.Name = "btnAlarm";
            this.btnAlarm.Size = new System.Drawing.Size(87, 23);
            this.btnAlarm.TabIndex = 4;
            this.btnAlarm.Text = "UstawAlarm";
            this.btnAlarm.UseVisualStyleBackColor = true;
            this.btnAlarm.Click += new System.EventHandler(this.btnAlarm_Click);
            // 
            // ikonaTray
            // 
            this.ikonaTray.ContextMenuStrip = this.mnuTray;
            this.ikonaTray.Icon = ((System.Drawing.Icon)(resources.GetObject("ikonaTray.Icon")));
            this.ikonaTray.Text = "budzik";
            this.ikonaTray.Visible = true;
            // 
            // mnuTray
            // 
            this.mnuTray.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wyswietlToolStripMenuItem});
            this.mnuTray.Name = "mnuTray";
            this.mnuTray.Size = new System.Drawing.Size(122, 26);
            // 
            // wyswietlToolStripMenuItem
            // 
            this.wyswietlToolStripMenuItem.Name = "wyswietlToolStripMenuItem";
            this.wyswietlToolStripMenuItem.Size = new System.Drawing.Size(121, 22);
            this.wyswietlToolStripMenuItem.Text = "Wyswietl";
            this.wyswietlToolStripMenuItem.Click += new System.EventHandler(this.wyswietlToolStripMenuItem_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 138);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Wylacz";
            // 
            // txtWylacz
            // 
            this.txtWylacz.Location = new System.Drawing.Point(109, 130);
            this.txtWylacz.Name = "txtWylacz";
            this.txtWylacz.Size = new System.Drawing.Size(100, 20);
            this.txtWylacz.TabIndex = 6;
            this.txtWylacz.Visible = false;
            // 
            // btnWylacz
            // 
            this.btnWylacz.Location = new System.Drawing.Point(250, 138);
            this.btnWylacz.Name = "btnWylacz";
            this.btnWylacz.Size = new System.Drawing.Size(87, 23);
            this.btnWylacz.TabIndex = 7;
            this.btnWylacz.Text = "UstawWylacz";
            this.btnWylacz.UseVisualStyleBackColor = true;
            this.btnWylacz.Click += new System.EventHandler(this.btnWylacz_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(493, 297);
            this.Controls.Add(this.btnWylacz);
            this.Controls.Add(this.txtWylacz);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAlarm);
            this.Controls.Add(this.txtAlarm);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblAktualnyCzas);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.MinimumSizeChanged += new System.EventHandler(this.Form1_MinimumSizeChanged);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Resize += new System.EventHandler(this.Form1_Resize);
            this.mnuTray.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAktualnyCzas;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAlarm;
        private System.Windows.Forms.Button btnAlarm;
        private System.Windows.Forms.NotifyIcon ikonaTray;
        private System.Windows.Forms.ContextMenuStrip mnuTray;
        private System.Windows.Forms.ToolStripMenuItem wyswietlToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtWylacz;
        private System.Windows.Forms.Button btnWylacz;
    }
}

