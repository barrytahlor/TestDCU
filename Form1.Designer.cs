namespace Termie
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
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel3 = new System.Windows.Forms.Panel();
            this.textRx1 = new System.Windows.Forms.TextBox();
            this.port1Label = new System.Windows.Forms.Label();
            this.masterLED1 = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.textAreaPort1write = new System.Windows.Forms.TextBox();
            this.textStatusPort1 = new System.Windows.Forms.TextBox();
            this.closePort1 = new System.Windows.Forms.Button();
            this.settingPort1 = new System.Windows.Forms.Button();
            this.checkBoxBadCRC1 = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(10, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1265, 393);
            this.splitContainer1.SplitterDistance = 25;
            this.splitContainer1.TabIndex = 2;
            // 
            // button4
            // 
            this.button4.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.button4.Location = new System.Drawing.Point(566, 3);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(61, 25);
            this.button4.TabIndex = 3;
            this.button4.Text = "Exit";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(504, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(61, 25);
            this.button3.TabIndex = 2;
            this.button3.Text = "About";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button_about_Click);
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.panel3);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.label2);
            this.splitContainer2.Panel2.Controls.Add(this.button5);
            this.splitContainer2.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel2_Paint);
            this.splitContainer2.Size = new System.Drawing.Size(1265, 364);
            this.splitContainer2.SplitterDistance = 313;
            this.splitContainer2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightCoral;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.textRx1);
            this.panel3.Controls.Add(this.port1Label);
            this.panel3.Controls.Add(this.masterLED1);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.textAreaPort1write);
            this.panel3.Controls.Add(this.textStatusPort1);
            this.panel3.Controls.Add(this.closePort1);
            this.panel3.Controls.Add(this.settingPort1);
            this.panel3.Controls.Add(this.checkBoxBadCRC1);
            this.panel3.Location = new System.Drawing.Point(31, 13);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1138, 287);
            this.panel3.TabIndex = 48;
            // 
            // textRx1
            // 
            this.textRx1.AcceptsReturn = true;
            this.textRx1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textRx1.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textRx1.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textRx1.Location = new System.Drawing.Point(3, 31);
            this.textRx1.Multiline = true;
            this.textRx1.Name = "textRx1";
            this.textRx1.ReadOnly = true;
            this.textRx1.Size = new System.Drawing.Size(1126, 34);
            this.textRx1.TabIndex = 64;
            // 
            // port1Label
            // 
            this.port1Label.AutoSize = true;
            this.port1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.port1Label.ForeColor = System.Drawing.Color.MediumBlue;
            this.port1Label.Location = new System.Drawing.Point(3, 6);
            this.port1Label.Name = "port1Label";
            this.port1Label.Size = new System.Drawing.Size(47, 20);
            this.port1Label.TabIndex = 63;
            this.port1Label.Text = "label";
            // 
            // masterLED1
            // 
            this.masterLED1.BackColor = System.Drawing.Color.LightCoral;
            this.masterLED1.BackgroundImage = global::DCUTester.Properties.Resources.amberLED;
            this.masterLED1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.masterLED1.FlatAppearance.BorderSize = 0;
            this.masterLED1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.masterLED1.Location = new System.Drawing.Point(182, 115);
            this.masterLED1.Name = "masterLED1";
            this.masterLED1.Size = new System.Drawing.Size(28, 31);
            this.masterLED1.TabIndex = 62;
            this.masterLED1.UseVisualStyleBackColor = false;
            // 
            // label6
            // 
            this.label6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label6.AutoSize = true;
            this.label6.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label6.Font = new System.Drawing.Font("Courier New", 13.8F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(436, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(175, 22);
            this.label6.TabIndex = 46;
            this.label6.Text = "DCU 1.0  Tester";
            // 
            // textAreaPort1write
            // 
            this.textAreaPort1write.AcceptsReturn = true;
            this.textAreaPort1write.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textAreaPort1write.BackColor = System.Drawing.SystemColors.MenuBar;
            this.textAreaPort1write.Font = new System.Drawing.Font("Arial Black", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textAreaPort1write.Location = new System.Drawing.Point(3, 63);
            this.textAreaPort1write.Multiline = true;
            this.textAreaPort1write.Name = "textAreaPort1write";
            this.textAreaPort1write.ReadOnly = true;
            this.textAreaPort1write.Size = new System.Drawing.Size(1126, 34);
            this.textAreaPort1write.TabIndex = 61;
            this.textAreaPort1write.TextChanged += new System.EventHandler(this.textAreaPort1write_TextChanged);
            // 
            // textStatusPort1
            // 
            this.textStatusPort1.AllowDrop = true;
            this.textStatusPort1.BackColor = System.Drawing.Color.Khaki;
            this.textStatusPort1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textStatusPort1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textStatusPort1.Location = new System.Drawing.Point(3, 171);
            this.textStatusPort1.Name = "textStatusPort1";
            this.textStatusPort1.ReadOnly = true;
            this.textStatusPort1.Size = new System.Drawing.Size(1130, 21);
            this.textStatusPort1.TabIndex = 3;
            // 
            // closePort1
            // 
            this.closePort1.BackColor = System.Drawing.Color.Yellow;
            this.closePort1.BackgroundImage = global::DCUTester.Properties.Resources._2000px_USB_Icon_svg;
            this.closePort1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.closePort1.FlatAppearance.BorderSize = 0;
            this.closePort1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.closePort1.Location = new System.Drawing.Point(26, 119);
            this.closePort1.Name = "closePort1";
            this.closePort1.Size = new System.Drawing.Size(60, 23);
            this.closePort1.TabIndex = 7;
            this.closePort1.UseVisualStyleBackColor = false;
            this.closePort1.Click += new System.EventHandler(this.closePort1_Click);
            // 
            // settingPort1
            // 
            this.settingPort1.BackgroundImage = global::DCUTester.Properties.Resources.dsub_237547_640;
            this.settingPort1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.settingPort1.FlatAppearance.BorderSize = 0;
            this.settingPort1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.settingPort1.Location = new System.Drawing.Point(92, 106);
            this.settingPort1.Name = "settingPort1";
            this.settingPort1.Size = new System.Drawing.Size(72, 48);
            this.settingPort1.TabIndex = 0;
            this.settingPort1.UseVisualStyleBackColor = true;
            this.settingPort1.Click += new System.EventHandler(this.settingPort1_Click);
            // 
            // checkBoxBadCRC1
            // 
            this.checkBoxBadCRC1.AutoSize = true;
            this.checkBoxBadCRC1.BackColor = System.Drawing.Color.LightCoral;
            this.checkBoxBadCRC1.Location = new System.Drawing.Point(274, 124);
            this.checkBoxBadCRC1.Name = "checkBoxBadCRC1";
            this.checkBoxBadCRC1.Size = new System.Drawing.Size(152, 18);
            this.checkBoxBadCRC1.TabIndex = 7;
            this.checkBoxBadCRC1.Text = "Display Rate 1 Sec";
            this.checkBoxBadCRC1.UseVisualStyleBackColor = false;
            this.checkBoxBadCRC1.CheckedChanged += new System.EventHandler(this.checkBoxBadCRC1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(22, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 15);
            this.label2.TabIndex = 4;
            this.label2.Text = "Send:";
            // 
            // button5
            // 
            this.button5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button5.Font = new System.Drawing.Font("Wingdings 3", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(2)));
            this.button5.Location = new System.Drawing.Point(566, 55);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(34, 25);
            this.button5.TabIndex = 3;
            this.button5.Text = "";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AcceptButton = this.button5;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.CancelButton = this.button4;
            this.ClientSize = new System.Drawing.Size(1275, 393);
            this.Controls.Add(this.splitContainer1);
            this.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximumSize = new System.Drawing.Size(1340, 780);
            this.MinimumSize = new System.Drawing.Size(550, 300);
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.Text = "EMS - Tester DCU 1.0";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            this.splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button settingPort1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textStatusPort1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button button5;
		private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button closePort1;
        private System.Windows.Forms.CheckBox checkBoxBadCRC1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textAreaPort1write;
        private System.Windows.Forms.Button masterLED1;
        private System.Windows.Forms.Label port1Label;
        private System.Windows.Forms.TextBox textRx1;
    }
}

