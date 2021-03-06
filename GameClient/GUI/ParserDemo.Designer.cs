﻿namespace GameClient
{
    partial class frmDemoParser
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
            this.txtSend = new System.Windows.Forms.TextBox();
            this.btnSendRAW = new System.Windows.Forms.Button();
            this.btnNorth = new System.Windows.Forms.Button();
            this.btnSouth = new System.Windows.Forms.Button();
            this.btnWest = new System.Windows.Forms.Button();
            this.btnEast = new System.Windows.Forms.Button();
            this.btnShoot = new System.Windows.Forms.Button();
            this.chkEchoConsole = new System.Windows.Forms.CheckBox();
            this.chkEchoRaw = new System.Windows.Forms.CheckBox();
            this.chkEchoSent = new System.Windows.Forms.CheckBox();
            this.chkEchoParsed = new System.Windows.Forms.CheckBox();
            this.pnlControl = new System.Windows.Forms.Panel();
            this.txtHost = new System.Windows.Forms.TextBox();
            this.lblHost = new System.Windows.Forms.Label();
            this.btnConnect = new System.Windows.Forms.Button();
            this.pnlMapGUI = new System.Windows.Forms.Panel();
            this.chkEchoGameWorld = new System.Windows.Forms.CheckBox();
            this.btnKeyboard = new System.Windows.Forms.Button();
            this.btnJoin = new System.Windows.Forms.Button();
            this.pnlControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtSend
            // 
            this.txtSend.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSend.Location = new System.Drawing.Point(12, 431);
            this.txtSend.Name = "txtSend";
            this.txtSend.Size = new System.Drawing.Size(431, 20);
            this.txtSend.TabIndex = 0;
            // 
            // btnSendRAW
            // 
            this.btnSendRAW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSendRAW.Enabled = false;
            this.btnSendRAW.Location = new System.Drawing.Point(449, 431);
            this.btnSendRAW.Name = "btnSendRAW";
            this.btnSendRAW.Size = new System.Drawing.Size(75, 23);
            this.btnSendRAW.TabIndex = 1;
            this.btnSendRAW.Text = "Send";
            this.btnSendRAW.UseVisualStyleBackColor = true;
            this.btnSendRAW.Click += new System.EventHandler(this.btnSendRaw_Click);
            // 
            // btnNorth
            // 
            this.btnNorth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNorth.Location = new System.Drawing.Point(34, 7);
            this.btnNorth.Name = "btnNorth";
            this.btnNorth.Size = new System.Drawing.Size(20, 23);
            this.btnNorth.TabIndex = 4;
            this.btnNorth.Text = "N";
            this.btnNorth.UseVisualStyleBackColor = true;
            this.btnNorth.Click += new System.EventHandler(this.btnNorth_Click);
            // 
            // btnSouth
            // 
            this.btnSouth.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSouth.Location = new System.Drawing.Point(34, 50);
            this.btnSouth.Name = "btnSouth";
            this.btnSouth.Size = new System.Drawing.Size(20, 23);
            this.btnSouth.TabIndex = 5;
            this.btnSouth.Text = "S";
            this.btnSouth.UseVisualStyleBackColor = true;
            this.btnSouth.Click += new System.EventHandler(this.btnSouth_Click);
            // 
            // btnWest
            // 
            this.btnWest.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnWest.Location = new System.Drawing.Point(15, 29);
            this.btnWest.Name = "btnWest";
            this.btnWest.Size = new System.Drawing.Size(20, 23);
            this.btnWest.TabIndex = 6;
            this.btnWest.Text = "W";
            this.btnWest.UseVisualStyleBackColor = true;
            this.btnWest.Click += new System.EventHandler(this.btnWest_Click);
            // 
            // btnEast
            // 
            this.btnEast.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEast.Location = new System.Drawing.Point(53, 28);
            this.btnEast.Name = "btnEast";
            this.btnEast.Size = new System.Drawing.Size(20, 23);
            this.btnEast.TabIndex = 7;
            this.btnEast.Text = "E";
            this.btnEast.UseVisualStyleBackColor = true;
            this.btnEast.Click += new System.EventHandler(this.btnEast_Click);
            // 
            // btnShoot
            // 
            this.btnShoot.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnShoot.Location = new System.Drawing.Point(3, 79);
            this.btnShoot.Name = "btnShoot";
            this.btnShoot.Size = new System.Drawing.Size(75, 23);
            this.btnShoot.TabIndex = 8;
            this.btnShoot.Text = "Shoot";
            this.btnShoot.UseVisualStyleBackColor = true;
            this.btnShoot.Click += new System.EventHandler(this.btnShoot_Click);
            // 
            // chkEchoConsole
            // 
            this.chkEchoConsole.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEchoConsole.AutoSize = true;
            this.chkEchoConsole.Checked = true;
            this.chkEchoConsole.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEchoConsole.Location = new System.Drawing.Point(14, 381);
            this.chkEchoConsole.Name = "chkEchoConsole";
            this.chkEchoConsole.Size = new System.Drawing.Size(104, 17);
            this.chkEchoConsole.TabIndex = 9;
            this.chkEchoConsole.Text = "Echo to Console";
            this.chkEchoConsole.UseVisualStyleBackColor = true;
            // 
            // chkEchoRaw
            // 
            this.chkEchoRaw.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEchoRaw.AutoSize = true;
            this.chkEchoRaw.Location = new System.Drawing.Point(249, 381);
            this.chkEchoRaw.Name = "chkEchoRaw";
            this.chkEchoRaw.Size = new System.Drawing.Size(127, 17);
            this.chkEchoRaw.TabIndex = 10;
            this.chkEchoRaw.Text = "Echo Raw Messages";
            this.chkEchoRaw.UseVisualStyleBackColor = true;
            // 
            // chkEchoSent
            // 
            this.chkEchoSent.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEchoSent.AutoSize = true;
            this.chkEchoSent.Location = new System.Drawing.Point(375, 381);
            this.chkEchoSent.Name = "chkEchoSent";
            this.chkEchoSent.Size = new System.Drawing.Size(127, 17);
            this.chkEchoSent.TabIndex = 11;
            this.chkEchoSent.Text = "Echo Sent Messages";
            this.chkEchoSent.UseVisualStyleBackColor = true;
            // 
            // chkEchoParsed
            // 
            this.chkEchoParsed.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEchoParsed.AutoSize = true;
            this.chkEchoParsed.Checked = true;
            this.chkEchoParsed.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkEchoParsed.Location = new System.Drawing.Point(124, 381);
            this.chkEchoParsed.Name = "chkEchoParsed";
            this.chkEchoParsed.Size = new System.Drawing.Size(119, 17);
            this.chkEchoParsed.TabIndex = 12;
            this.chkEchoParsed.Text = "Echo Parser Output";
            this.chkEchoParsed.UseVisualStyleBackColor = true;
            // 
            // pnlControl
            // 
            this.pnlControl.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlControl.Controls.Add(this.btnNorth);
            this.pnlControl.Controls.Add(this.btnSouth);
            this.pnlControl.Controls.Add(this.btnWest);
            this.pnlControl.Controls.Add(this.btnEast);
            this.pnlControl.Controls.Add(this.btnShoot);
            this.pnlControl.Enabled = false;
            this.pnlControl.Location = new System.Drawing.Point(449, 79);
            this.pnlControl.Name = "pnlControl";
            this.pnlControl.Size = new System.Drawing.Size(84, 110);
            this.pnlControl.TabIndex = 13;
            // 
            // txtHost
            // 
            this.txtHost.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtHost.Location = new System.Drawing.Point(48, 9);
            this.txtHost.Name = "txtHost";
            this.txtHost.Size = new System.Drawing.Size(395, 20);
            this.txtHost.TabIndex = 14;
            this.txtHost.Text = "localhost";
            // 
            // lblHost
            // 
            this.lblHost.AutoSize = true;
            this.lblHost.Location = new System.Drawing.Point(13, 12);
            this.lblHost.Name = "lblHost";
            this.lblHost.Size = new System.Drawing.Size(29, 13);
            this.lblHost.TabIndex = 15;
            this.lblHost.Text = "Host";
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConnect.Location = new System.Drawing.Point(452, 8);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(75, 23);
            this.btnConnect.TabIndex = 16;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // pnlMapGUI
            // 
            this.pnlMapGUI.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlMapGUI.Location = new System.Drawing.Point(16, 35);
            this.pnlMapGUI.Name = "pnlMapGUI";
            this.pnlMapGUI.Size = new System.Drawing.Size(427, 331);
            this.pnlMapGUI.TabIndex = 17;
            this.pnlMapGUI.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMapGUI_Paint);
            this.pnlMapGUI.Resize += new System.EventHandler(this.pnlMapGUI_Resize);
            // 
            // chkEchoGameWorld
            // 
            this.chkEchoGameWorld.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.chkEchoGameWorld.AutoSize = true;
            this.chkEchoGameWorld.Location = new System.Drawing.Point(14, 404);
            this.chkEchoGameWorld.Name = "chkEchoGameWorld";
            this.chkEchoGameWorld.Size = new System.Drawing.Size(128, 17);
            this.chkEchoGameWorld.TabIndex = 18;
            this.chkEchoGameWorld.Text = "Game World Updates";
            this.chkEchoGameWorld.UseVisualStyleBackColor = true;
            // 
            // btnKeyboard
            // 
            this.btnKeyboard.Enabled = false;
            this.btnKeyboard.Location = new System.Drawing.Point(452, 205);
            this.btnKeyboard.Name = "btnKeyboard";
            this.btnKeyboard.Size = new System.Drawing.Size(75, 23);
            this.btnKeyboard.TabIndex = 19;
            this.btnKeyboard.Text = "Keyboard Mode";
            this.btnKeyboard.UseVisualStyleBackColor = true;
            this.btnKeyboard.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnJoin
            // 
            this.btnJoin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnJoin.Enabled = false;
            this.btnJoin.Location = new System.Drawing.Point(452, 50);
            this.btnJoin.Name = "btnJoin";
            this.btnJoin.Size = new System.Drawing.Size(75, 23);
            this.btnJoin.TabIndex = 20;
            this.btnJoin.Text = "Join";
            this.btnJoin.UseVisualStyleBackColor = true;
            this.btnJoin.Click += new System.EventHandler(this.btnJoin_Click);
            // 
            // frmDemoParser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 463);
            this.Controls.Add(this.btnJoin);
            this.Controls.Add(this.btnKeyboard);
            this.Controls.Add(this.chkEchoGameWorld);
            this.Controls.Add(this.pnlMapGUI);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblHost);
            this.Controls.Add(this.txtHost);
            this.Controls.Add(this.pnlControl);
            this.Controls.Add(this.chkEchoParsed);
            this.Controls.Add(this.chkEchoSent);
            this.Controls.Add(this.chkEchoRaw);
            this.Controls.Add(this.chkEchoConsole);
            this.Controls.Add(this.btnSendRAW);
            this.Controls.Add(this.txtSend);
            this.DoubleBuffered = true;
            this.Name = "frmDemoParser";
            this.Text = "Parser Demo";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmDemoParser_KeyDown);
            this.pnlControl.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSend;
        private System.Windows.Forms.Button btnSendRAW;
        private System.Windows.Forms.Button btnNorth;
        private System.Windows.Forms.Button btnSouth;
        private System.Windows.Forms.Button btnWest;
        private System.Windows.Forms.Button btnEast;
        private System.Windows.Forms.Button btnShoot;
        private System.Windows.Forms.CheckBox chkEchoConsole;
        private System.Windows.Forms.CheckBox chkEchoRaw;
        private System.Windows.Forms.CheckBox chkEchoSent;
        private System.Windows.Forms.CheckBox chkEchoParsed;
        private System.Windows.Forms.Panel pnlControl;
        private System.Windows.Forms.TextBox txtHost;
        private System.Windows.Forms.Label lblHost;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Panel pnlMapGUI;
        private System.Windows.Forms.CheckBox chkEchoGameWorld;
        private System.Windows.Forms.Button btnKeyboard;
        private System.Windows.Forms.Button btnJoin;
    }
}

