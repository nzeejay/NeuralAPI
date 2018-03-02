namespace VisualisationClient
{
    partial class Main
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
            this.Control = new System.Windows.Forms.Panel();
            this.ControlSplitter = new System.Windows.Forms.SplitContainer();
            this.lblLayerInfo = new System.Windows.Forms.Label();
            this.txtLayerInfo = new System.Windows.Forms.TextBox();
            this.grpKernelSettings = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblSize = new System.Windows.Forms.Label();
            this.btnLayerSave = new System.Windows.Forms.Button();
            this.btnLayerNew = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Toolbar = new System.Windows.Forms.ToolStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.comboBox5 = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlSplitter)).BeginInit();
            this.ControlSplitter.Panel1.SuspendLayout();
            this.ControlSplitter.Panel2.SuspendLayout();
            this.ControlSplitter.SuspendLayout();
            this.grpKernelSettings.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabView.SuspendLayout();
            this.SuspendLayout();
            // 
            // Control
            // 
            this.Control.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Control.Controls.Add(this.ControlSplitter);
            this.Control.Location = new System.Drawing.Point(0, 28);
            this.Control.Name = "Control";
            this.Control.Size = new System.Drawing.Size(200, 583);
            this.Control.TabIndex = 0;
            // 
            // ControlSplitter
            // 
            this.ControlSplitter.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ControlSplitter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ControlSplitter.Location = new System.Drawing.Point(0, 0);
            this.ControlSplitter.Name = "ControlSplitter";
            this.ControlSplitter.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // ControlSplitter.Panel1
            // 
            this.ControlSplitter.Panel1.Controls.Add(this.lblLayerInfo);
            this.ControlSplitter.Panel1.Controls.Add(this.txtLayerInfo);
            this.ControlSplitter.Panel1MinSize = 60;
            // 
            // ControlSplitter.Panel2
            // 
            this.ControlSplitter.Panel2.Controls.Add(this.grpKernelSettings);
            this.ControlSplitter.Panel2.Controls.Add(this.comboBox3);
            this.ControlSplitter.Panel2.Controls.Add(this.label3);
            this.ControlSplitter.Panel2.Controls.Add(this.comboBox2);
            this.ControlSplitter.Panel2.Controls.Add(this.label2);
            this.ControlSplitter.Panel2.Controls.Add(this.textBox1);
            this.ControlSplitter.Panel2.Controls.Add(this.lblSize);
            this.ControlSplitter.Panel2.Controls.Add(this.btnLayerSave);
            this.ControlSplitter.Panel2.Controls.Add(this.btnLayerNew);
            this.ControlSplitter.Panel2.Controls.Add(this.comboBox1);
            this.ControlSplitter.Panel2.Controls.Add(this.label1);
            this.ControlSplitter.Size = new System.Drawing.Size(200, 583);
            this.ControlSplitter.SplitterDistance = 140;
            this.ControlSplitter.TabIndex = 2;
            // 
            // lblLayerInfo
            // 
            this.lblLayerInfo.AutoSize = true;
            this.lblLayerInfo.Location = new System.Drawing.Point(3, 9);
            this.lblLayerInfo.Name = "lblLayerInfo";
            this.lblLayerInfo.Size = new System.Drawing.Size(112, 13);
            this.lblLayerInfo.TabIndex = 3;
            this.lblLayerInfo.Text = "Layer Info ({0} Layers}";
            // 
            // txtLayerInfo
            // 
            this.txtLayerInfo.AcceptsReturn = true;
            this.txtLayerInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLayerInfo.BackColor = System.Drawing.SystemColors.Window;
            this.txtLayerInfo.Location = new System.Drawing.Point(3, 25);
            this.txtLayerInfo.Multiline = true;
            this.txtLayerInfo.Name = "txtLayerInfo";
            this.txtLayerInfo.ReadOnly = true;
            this.txtLayerInfo.Size = new System.Drawing.Size(192, 109);
            this.txtLayerInfo.TabIndex = 2;
            // 
            // grpKernelSettings
            // 
            this.grpKernelSettings.Controls.Add(this.textBox3);
            this.grpKernelSettings.Controls.Add(this.label5);
            this.grpKernelSettings.Controls.Add(this.textBox2);
            this.grpKernelSettings.Controls.Add(this.label4);
            this.grpKernelSettings.Enabled = false;
            this.grpKernelSettings.Location = new System.Drawing.Point(4, 103);
            this.grpKernelSettings.Name = "grpKernelSettings";
            this.grpKernelSettings.Size = new System.Drawing.Size(192, 145);
            this.grpKernelSettings.TabIndex = 15;
            this.grpKernelSettings.TabStop = false;
            this.grpKernelSettings.Text = "Kernel Settings";
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox3.Location = new System.Drawing.Point(102, 48);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(84, 23);
            this.textBox3.TabIndex = 18;
            this.textBox3.Text = "1024";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 54);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(37, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "Stride:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox2.Location = new System.Drawing.Point(95, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(91, 23);
            this.textBox2.TabIndex = 16;
            this.textBox2.Text = "1024,1024";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(30, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Size:";
            // 
            // comboBox3
            // 
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(63, 254);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox3.Size = new System.Drawing.Size(106, 21);
            this.comboBox3.TabIndex = 14;
            this.comboBox3.Text = "Sigmoid";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Activation:";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(69, 76);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(100, 21);
            this.comboBox2.TabIndex = 12;
            this.comboBox2.Text = "Fully Connected";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 11;
            this.label2.Text = "Layer Type:";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox1.Location = new System.Drawing.Point(36, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(133, 24);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "1024,1024,1024";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lblSize
            // 
            this.lblSize.AutoSize = true;
            this.lblSize.Location = new System.Drawing.Point(0, 53);
            this.lblSize.Name = "lblSize";
            this.lblSize.Size = new System.Drawing.Size(30, 13);
            this.lblSize.TabIndex = 9;
            this.lblSize.Text = "Size:";
            // 
            // btnLayerSave
            // 
            this.btnLayerSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLayerSave.Location = new System.Drawing.Point(120, 411);
            this.btnLayerSave.Name = "btnLayerSave";
            this.btnLayerSave.Size = new System.Drawing.Size(75, 23);
            this.btnLayerSave.TabIndex = 8;
            this.btnLayerSave.Text = "Save";
            this.btnLayerSave.UseVisualStyleBackColor = true;
            // 
            // btnLayerNew
            // 
            this.btnLayerNew.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnLayerNew.Location = new System.Drawing.Point(4, 411);
            this.btnLayerNew.Name = "btnLayerNew";
            this.btnLayerNew.Size = new System.Drawing.Size(75, 23);
            this.btnLayerNew.TabIndex = 7;
            this.btnLayerNew.Text = "New";
            this.btnLayerNew.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(42, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(70, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(0, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Layer:";
            // 
            // Toolbar
            // 
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(874, 25);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "Toolbar";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.splitContainer1);
            this.panel1.Location = new System.Drawing.Point(674, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 583);
            this.panel1.TabIndex = 3;
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.label6);
            this.splitContainer1.Panel1.Controls.Add(this.textBox4);
            this.splitContainer1.Panel1MinSize = 60;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox4);
            this.splitContainer1.Panel2.Controls.Add(this.label9);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox5);
            this.splitContainer1.Panel2.Controls.Add(this.label10);
            this.splitContainer1.Panel2.Controls.Add(this.textBox7);
            this.splitContainer1.Panel2.Controls.Add(this.label11);
            this.splitContainer1.Panel2.Controls.Add(this.button1);
            this.splitContainer1.Panel2.Controls.Add(this.button2);
            this.splitContainer1.Panel2.Controls.Add(this.comboBox6);
            this.splitContainer1.Panel2.Controls.Add(this.label12);
            this.splitContainer1.Size = new System.Drawing.Size(200, 583);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(112, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Layer Info ({0} Layers}";
            // 
            // textBox4
            // 
            this.textBox4.AcceptsReturn = true;
            this.textBox4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox4.BackColor = System.Drawing.SystemColors.Window;
            this.textBox4.Location = new System.Drawing.Point(3, 25);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.ReadOnly = true;
            this.textBox4.Size = new System.Drawing.Size(192, 109);
            this.textBox4.TabIndex = 2;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(4, 103);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 145);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Kernel Settings";
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox5.Location = new System.Drawing.Point(102, 48);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(84, 23);
            this.textBox5.TabIndex = 18;
            this.textBox5.Text = "1024";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(37, 13);
            this.label7.TabIndex = 17;
            this.label7.Text = "Stride:";
            // 
            // textBox6
            // 
            this.textBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
            this.textBox6.Location = new System.Drawing.Point(95, 19);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(91, 23);
            this.textBox6.TabIndex = 16;
            this.textBox6.Text = "1024,1024";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(7, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(30, 13);
            this.label8.TabIndex = 16;
            this.label8.Text = "Size:";
            // 
            // comboBox4
            // 
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(63, 254);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.comboBox4.Size = new System.Drawing.Size(106, 21);
            this.comboBox4.TabIndex = 14;
            this.comboBox4.Text = "Sigmoid";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(0, 257);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(57, 13);
            this.label9.TabIndex = 13;
            this.label9.Text = "Activation:";
            // 
            // comboBox5
            // 
            this.comboBox5.FormattingEnabled = true;
            this.comboBox5.Location = new System.Drawing.Point(69, 76);
            this.comboBox5.Name = "comboBox5";
            this.comboBox5.Size = new System.Drawing.Size(100, 21);
            this.comboBox5.TabIndex = 12;
            this.comboBox5.Text = "Fully Connected";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(0, 79);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(63, 13);
            this.label10.TabIndex = 11;
            this.label10.Text = "Layer Type:";
            // 
            // textBox7
            // 
            this.textBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F);
            this.textBox7.Location = new System.Drawing.Point(36, 46);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(133, 24);
            this.textBox7.TabIndex = 10;
            this.textBox7.Text = "1024,1024,1024";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(0, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(30, 13);
            this.label11.TabIndex = 9;
            this.label11.Text = "Size:";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button1.Location = new System.Drawing.Point(120, 411);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 8;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.button2.Location = new System.Drawing.Point(4, 411);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 7;
            this.button2.Text = "New";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(42, 4);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(70, 21);
            this.comboBox6.TabIndex = 6;
            this.comboBox6.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(0, 7);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(36, 13);
            this.label12.TabIndex = 5;
            this.label12.Text = "Layer:";
            // 
            // tabView
            // 
            this.tabView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabView.Controls.Add(this.tabPage1);
            this.tabView.Controls.Add(this.tabPage2);
            this.tabView.Location = new System.Drawing.Point(198, 28);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(478, 583);
            this.tabView.TabIndex = 4;
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(470, 557);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Error Graph";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(470, 557);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 611);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.Control);
            this.Controls.Add(this.tabView);
            this.Name = "Main";
            this.Text = "Neural Network Controller";
            this.Control.ResumeLayout(false);
            this.ControlSplitter.Panel1.ResumeLayout(false);
            this.ControlSplitter.Panel1.PerformLayout();
            this.ControlSplitter.Panel2.ResumeLayout(false);
            this.ControlSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlSplitter)).EndInit();
            this.ControlSplitter.ResumeLayout(false);
            this.grpKernelSettings.ResumeLayout(false);
            this.grpKernelSettings.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabView.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel Control;
        private System.Windows.Forms.SplitContainer ControlSplitter;
        private System.Windows.Forms.Label lblLayerInfo;
        private System.Windows.Forms.TextBox txtLayerInfo;
        private System.Windows.Forms.ToolStrip Toolbar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnLayerNew;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnLayerSave;
        private System.Windows.Forms.Label lblSize;
        private System.Windows.Forms.GroupBox grpKernelSettings;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox comboBox4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboBox5;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}