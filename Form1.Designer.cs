namespace HASPHLDongleVirtualizer
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button15 = new System.Windows.Forms.Button();
            this.button14 = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.codedByBaranCopyleft2010ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.justFollowTheStepsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(72, 203);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 29);
            this.button1.TabIndex = 0;
            this.button1.Text = "1) [Optional] Detect the dongle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(72, 155);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 27);
            this.button2.TabIndex = 1;
            this.button2.Text = "0) Check for the color of the dongle :)";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(72, 238);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(226, 65);
            this.button3.TabIndex = 2;
            this.button3.Text = "2a) Call HASP HL 2010, install driver, service, click refresh";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(448, 376);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(414, 35);
            this.button4.TabIndex = 3;
            this.button4.Text = "3ab) Call h5dmp.exe if fails/stuck cmd: h5dmp.exe HexKey1 HexKey2";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(72, 421);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(188, 41);
            this.button5.TabIndex = 4;
            this.button5.Text = "4) Call UniDumpToReg";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(72, 485);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(188, 34);
            this.button6.TabIndex = 5;
            this.button6.Text = "5a) Call haSploGer";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(72, 534);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(188, 42);
            this.button7.TabIndex = 6;
            this.button7.Text = "6a) Call LogsToTables, if fails/nothing happens, run manually!";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(72, 596);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(188, 34);
            this.button8.TabIndex = 7;
            this.button8.Text = "7) Append the reg file";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // button9
            // 
            this.button9.Location = new System.Drawing.Point(72, 653);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(188, 35);
            this.button9.TabIndex = 8;
            this.button9.Text = "8a) Install Emulator";
            this.button9.UseVisualStyleBackColor = true;
            this.button9.Click += new System.EventHandler(this.button9_Click);
            // 
            // button10
            // 
            this.button10.Location = new System.Drawing.Point(117, 714);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(713, 50);
            this.button10.TabIndex = 9;
            this.button10.Text = "9) Remove the dongle and run it freely:)";
            this.button10.UseVisualStyleBackColor = true;
            this.button10.Click += new System.EventHandler(this.button10_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(72, 382);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(131, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "0x";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(239, 382);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(131, 20);
            this.textBox2.TabIndex = 11;
            this.textBox2.Text = "0x";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.Filter = "Registry files (*.reg)|*.reg";
            this.openFileDialog1.InitialDirectory = "C:";
            // 
            // button11
            // 
            this.button11.Location = new System.Drawing.Point(451, 251);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(411, 38);
            this.button11.TabIndex = 12;
            this.button11.Text = "2b) Don\'t understand?/Not Working?";
            this.button11.UseVisualStyleBackColor = true;
            this.button11.Click += new System.EventHandler(this.button11_Click);
            // 
            // button12
            // 
            this.button12.Location = new System.Drawing.Point(451, 503);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(411, 36);
            this.button12.TabIndex = 14;
            this.button12.Text = "5b-6b) Don\'t understand?/Not Working?";
            this.button12.UseVisualStyleBackColor = true;
            this.button12.Click += new System.EventHandler(this.button12_Click);
            // 
            // button13
            // 
            this.button13.Location = new System.Drawing.Point(451, 653);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(411, 34);
            this.button13.TabIndex = 15;
            this.button13.Text = "8b) Fail?/Remove emulator and other files?";
            this.button13.UseVisualStyleBackColor = true;
            this.button13.Click += new System.EventHandler(this.button13_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 357);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Hex Key1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(236, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Hex Key2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button15);
            this.groupBox1.Controls.Add(this.button14);
            this.groupBox1.Location = new System.Drawing.Point(72, 23);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 92);
            this.groupBox1.TabIndex = 19;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "These are the very first steps to do!";
            // 
            // button15
            // 
            this.button15.Location = new System.Drawing.Point(18, 57);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(772, 28);
            this.button15.TabIndex = 1;
            this.button15.Text = "-1) Registry Backup!";
            this.button15.UseVisualStyleBackColor = true;
            this.button15.Click += new System.EventHandler(this.button15_Click);
            // 
            // button14
            // 
            this.button14.Location = new System.Drawing.Point(18, 17);
            this.button14.Name = "button14";
            this.button14.Size = new System.Drawing.Size(772, 28);
            this.button14.TabIndex = 0;
            this.button14.Text = "-2) System Restore!, may fail:), do it manually!";
            this.button14.UseVisualStyleBackColor = true;
            this.button14.Click += new System.EventHandler(this.button14_Click);
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.Filter = "Registry files (*.reg)|*.reg";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 328);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(386, 13);
            this.label3.TabIndex = 20;
            this.label3.Text = "Explode Hex keys XXXX:XXXX into Hex Key 1 0xXXXX and Hex Key 2 0xXXXX ";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1013, 24);
            this.menuStrip1.TabIndex = 21;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.codedByBaranCopyleft2010ToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // codedByBaranCopyleft2010ToolStripMenuItem
            // 
            this.codedByBaranCopyleft2010ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.justFollowTheStepsToolStripMenuItem});
            this.codedByBaranCopyleft2010ToolStripMenuItem.Name = "codedByBaranCopyleft2010ToolStripMenuItem";
            this.codedByBaranCopyleft2010ToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.codedByBaranCopyleft2010ToolStripMenuItem.Text = "Coded by Baran Copyleft 2010";
            // 
            // justFollowTheStepsToolStripMenuItem
            // 
            this.justFollowTheStepsToolStripMenuItem.Name = "justFollowTheStepsToolStripMenuItem";
            this.justFollowTheStepsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.justFollowTheStepsToolStripMenuItem.Text = "Just follow the steps";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 811);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button13);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Baran Topal HASP Dongle Virtualizer";
            this.groupBox1.ResumeLayout(false);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button14;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem codedByBaranCopyleft2010ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem justFollowTheStepsToolStripMenuItem;
    }
}

