namespace senzor
{
    partial class sensor
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
            this.registerbox = new System.Windows.Forms.GroupBox();
            this.registerbutton = new System.Windows.Forms.Button();
            this.usernametextbox = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.infobox = new System.Windows.Forms.GroupBox();
            this.longitudetextbox = new System.Windows.Forms.TextBox();
            this.latitudetextbox = new System.Windows.Forms.TextBox();
            this.porttextbox = new System.Windows.Forms.TextBox();
            this.IPtextbox = new System.Windows.Forms.TextBox();
            this.latitudelabel = new System.Windows.Forms.Label();
            this.longitudelabel = new System.Windows.Forms.Label();
            this.portlabel = new System.Windows.Forms.Label();
            this.IPlabel = new System.Windows.Forms.Label();
            this.connectbox = new System.Windows.Forms.GroupBox();
            this.sendbutton = new System.Windows.Forms.Button();
            this.nexttextbox = new System.Windows.Forms.TextBox();
            this.nextlabel = new System.Windows.Forms.Label();
            this.outbox = new System.Windows.Forms.GroupBox();
            this.connectedtolabel = new System.Windows.Forms.Label();
            this.resultbox = new System.Windows.Forms.ListBox();
            this.connectedto = new System.Windows.Forms.TextBox();
            this.sendtoserver = new System.Windows.Forms.Button();
            this.registerbox.SuspendLayout();
            this.infobox.SuspendLayout();
            this.connectbox.SuspendLayout();
            this.outbox.SuspendLayout();
            this.SuspendLayout();
            // 
            // registerbox
            // 
            this.registerbox.Controls.Add(this.registerbutton);
            this.registerbox.Controls.Add(this.usernametextbox);
            this.registerbox.Controls.Add(this.usernamelabel);
            this.registerbox.Location = new System.Drawing.Point(12, 12);
            this.registerbox.Name = "registerbox";
            this.registerbox.Size = new System.Drawing.Size(291, 86);
            this.registerbox.TabIndex = 0;
            this.registerbox.TabStop = false;
            // 
            // registerbutton
            // 
            this.registerbutton.Location = new System.Drawing.Point(84, 45);
            this.registerbutton.Name = "registerbutton";
            this.registerbutton.Size = new System.Drawing.Size(122, 23);
            this.registerbutton.TabIndex = 2;
            this.registerbutton.Text = "Register to server";
            this.registerbutton.UseVisualStyleBackColor = true;
            this.registerbutton.Click += new System.EventHandler(this.register);
            // 
            // usernametextbox
            // 
            this.usernametextbox.Location = new System.Drawing.Point(84, 19);
            this.usernametextbox.Name = "usernametextbox";
            this.usernametextbox.Size = new System.Drawing.Size(175, 20);
            this.usernametextbox.TabIndex = 1;
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Location = new System.Drawing.Point(23, 22);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(55, 13);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "Username";
            // 
            // infobox
            // 
            this.infobox.Controls.Add(this.longitudetextbox);
            this.infobox.Controls.Add(this.latitudetextbox);
            this.infobox.Controls.Add(this.porttextbox);
            this.infobox.Controls.Add(this.IPtextbox);
            this.infobox.Controls.Add(this.latitudelabel);
            this.infobox.Controls.Add(this.longitudelabel);
            this.infobox.Controls.Add(this.portlabel);
            this.infobox.Controls.Add(this.IPlabel);
            this.infobox.Location = new System.Drawing.Point(12, 104);
            this.infobox.Name = "infobox";
            this.infobox.Size = new System.Drawing.Size(291, 186);
            this.infobox.TabIndex = 1;
            this.infobox.TabStop = false;
            // 
            // longitudetextbox
            // 
            this.longitudetextbox.Enabled = false;
            this.longitudetextbox.Location = new System.Drawing.Point(106, 128);
            this.longitudetextbox.Name = "longitudetextbox";
            this.longitudetextbox.Size = new System.Drawing.Size(142, 20);
            this.longitudetextbox.TabIndex = 7;
            // 
            // latitudetextbox
            // 
            this.latitudetextbox.Enabled = false;
            this.latitudetextbox.Location = new System.Drawing.Point(106, 92);
            this.latitudetextbox.Name = "latitudetextbox";
            this.latitudetextbox.Size = new System.Drawing.Size(142, 20);
            this.latitudetextbox.TabIndex = 6;
            // 
            // porttextbox
            // 
            this.porttextbox.Enabled = false;
            this.porttextbox.Location = new System.Drawing.Point(106, 54);
            this.porttextbox.Name = "porttextbox";
            this.porttextbox.Size = new System.Drawing.Size(142, 20);
            this.porttextbox.TabIndex = 5;
            // 
            // IPtextbox
            // 
            this.IPtextbox.Enabled = false;
            this.IPtextbox.Location = new System.Drawing.Point(106, 16);
            this.IPtextbox.Name = "IPtextbox";
            this.IPtextbox.Size = new System.Drawing.Size(142, 20);
            this.IPtextbox.TabIndex = 4;
            // 
            // latitudelabel
            // 
            this.latitudelabel.AutoSize = true;
            this.latitudelabel.Enabled = false;
            this.latitudelabel.Location = new System.Drawing.Point(61, 95);
            this.latitudelabel.Name = "latitudelabel";
            this.latitudelabel.Size = new System.Drawing.Size(45, 13);
            this.latitudelabel.TabIndex = 3;
            this.latitudelabel.Text = "Latitude";
            // 
            // longitudelabel
            // 
            this.longitudelabel.AutoSize = true;
            this.longitudelabel.Enabled = false;
            this.longitudelabel.Location = new System.Drawing.Point(49, 131);
            this.longitudelabel.Name = "longitudelabel";
            this.longitudelabel.Size = new System.Drawing.Size(54, 13);
            this.longitudelabel.TabIndex = 2;
            this.longitudelabel.Text = "Longitude";
            // 
            // portlabel
            // 
            this.portlabel.AutoSize = true;
            this.portlabel.Enabled = false;
            this.portlabel.Location = new System.Drawing.Point(80, 57);
            this.portlabel.Name = "portlabel";
            this.portlabel.Size = new System.Drawing.Size(26, 13);
            this.portlabel.TabIndex = 1;
            this.portlabel.Text = "Port";
            // 
            // IPlabel
            // 
            this.IPlabel.AutoSize = true;
            this.IPlabel.Enabled = false;
            this.IPlabel.Location = new System.Drawing.Point(49, 19);
            this.IPlabel.Name = "IPlabel";
            this.IPlabel.Size = new System.Drawing.Size(57, 13);
            this.IPlabel.TabIndex = 0;
            this.IPlabel.Text = "IP address";
            // 
            // connectbox
            // 
            this.connectbox.Controls.Add(this.sendbutton);
            this.connectbox.Controls.Add(this.nexttextbox);
            this.connectbox.Controls.Add(this.nextlabel);
            this.connectbox.Enabled = false;
            this.connectbox.Location = new System.Drawing.Point(314, 12);
            this.connectbox.Name = "connectbox";
            this.connectbox.Size = new System.Drawing.Size(291, 86);
            this.connectbox.TabIndex = 2;
            this.connectbox.TabStop = false;
            // 
            // sendbutton
            // 
            this.sendbutton.Location = new System.Drawing.Point(84, 45);
            this.sendbutton.Name = "sendbutton";
            this.sendbutton.Size = new System.Drawing.Size(122, 23);
            this.sendbutton.TabIndex = 3;
            this.sendbutton.Text = "Find and collect data";
            this.sendbutton.UseVisualStyleBackColor = true;
            this.sendbutton.Click += new System.EventHandler(this.measuresend);
            // 
            // nexttextbox
            // 
            this.nexttextbox.Enabled = false;
            this.nexttextbox.Location = new System.Drawing.Point(120, 19);
            this.nexttextbox.Name = "nexttextbox";
            this.nexttextbox.Size = new System.Drawing.Size(149, 20);
            this.nexttextbox.TabIndex = 1;
            // 
            // nextlabel
            // 
            this.nextlabel.AutoSize = true;
            this.nextlabel.Location = new System.Drawing.Point(23, 22);
            this.nextlabel.Name = "nextlabel";
            this.nextlabel.Size = new System.Drawing.Size(91, 13);
            this.nextlabel.TabIndex = 0;
            this.nextlabel.Text = "Closest neighbour";
            // 
            // outbox
            // 
            this.outbox.Controls.Add(this.sendtoserver);
            this.outbox.Controls.Add(this.connectedto);
            this.outbox.Controls.Add(this.resultbox);
            this.outbox.Controls.Add(this.connectedtolabel);
            this.outbox.Enabled = false;
            this.outbox.Location = new System.Drawing.Point(314, 106);
            this.outbox.Name = "outbox";
            this.outbox.Size = new System.Drawing.Size(291, 186);
            this.outbox.TabIndex = 3;
            this.outbox.TabStop = false;
            // 
            // connectedtolabel
            // 
            this.connectedtolabel.AutoSize = true;
            this.connectedtolabel.Location = new System.Drawing.Point(43, 19);
            this.connectedtolabel.Name = "connectedtolabel";
            this.connectedtolabel.Size = new System.Drawing.Size(71, 13);
            this.connectedtolabel.TabIndex = 0;
            this.connectedtolabel.Text = "Connected to";
            // 
            // resultbox
            // 
            this.resultbox.Enabled = false;
            this.resultbox.FormattingEnabled = true;
            this.resultbox.Location = new System.Drawing.Point(26, 51);
            this.resultbox.Name = "resultbox";
            this.resultbox.Size = new System.Drawing.Size(242, 82);
            this.resultbox.TabIndex = 1;
            // 
            // connectedto
            // 
            this.connectedto.Location = new System.Drawing.Point(120, 16);
            this.connectedto.Name = "connectedto";
            this.connectedto.Size = new System.Drawing.Size(148, 20);
            this.connectedto.TabIndex = 2;
            // 
            // sendtoserver
            // 
            this.sendtoserver.Location = new System.Drawing.Point(84, 148);
            this.sendtoserver.Name = "sendtoserver";
            this.sendtoserver.Size = new System.Drawing.Size(122, 28);
            this.sendtoserver.TabIndex = 3;
            this.sendtoserver.Text = "Send to server";
            this.sendtoserver.UseVisualStyleBackColor = true;
            this.sendtoserver.Click += new System.EventHandler(this.store);
            // 
            // sensor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(617, 304);
            this.Controls.Add(this.outbox);
            this.Controls.Add(this.connectbox);
            this.Controls.Add(this.infobox);
            this.Controls.Add(this.registerbox);
            this.Name = "sensor";
            this.Text = "New sensor";
            this.registerbox.ResumeLayout(false);
            this.registerbox.PerformLayout();
            this.infobox.ResumeLayout(false);
            this.infobox.PerformLayout();
            this.connectbox.ResumeLayout(false);
            this.connectbox.PerformLayout();
            this.outbox.ResumeLayout(false);
            this.outbox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox registerbox;
        private System.Windows.Forms.Button registerbutton;
        private System.Windows.Forms.TextBox usernametextbox;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.GroupBox infobox;
        private System.Windows.Forms.TextBox longitudetextbox;
        private System.Windows.Forms.TextBox latitudetextbox;
        private System.Windows.Forms.TextBox porttextbox;
        private System.Windows.Forms.TextBox IPtextbox;
        private System.Windows.Forms.Label latitudelabel;
        private System.Windows.Forms.Label longitudelabel;
        private System.Windows.Forms.Label portlabel;
        private System.Windows.Forms.Label IPlabel;
        private System.Windows.Forms.GroupBox connectbox;
        private System.Windows.Forms.Button sendbutton;
        private System.Windows.Forms.TextBox nexttextbox;
        private System.Windows.Forms.Label nextlabel;
        private System.Windows.Forms.GroupBox outbox;
        private System.Windows.Forms.Button sendtoserver;
        private System.Windows.Forms.TextBox connectedto;
        private System.Windows.Forms.ListBox resultbox;
        private System.Windows.Forms.Label connectedtolabel;
    }
}

