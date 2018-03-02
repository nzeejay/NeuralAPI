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
            this.components = new System.ComponentModel.Container();
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
            this.toolFile = new System.Windows.Forms.ToolStripDropDownButton();
            this.newToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.tabView = new System.Windows.Forms.TabControl();
            this.tabErrorPage = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.errorDrawing = new System.Windows.Forms.Panel();
            this.Control.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlSplitter)).BeginInit();
            this.ControlSplitter.Panel1.SuspendLayout();
            this.ControlSplitter.Panel2.SuspendLayout();
            this.ControlSplitter.SuspendLayout();
            this.grpKernelSettings.SuspendLayout();
            this.Toolbar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            this.tabView.SuspendLayout();
            this.tabErrorPage.SuspendLayout();
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
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolFile});
            this.Toolbar.Location = new System.Drawing.Point(0, 0);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(874, 25);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "Toolbar";
            // 
            // toolFile
            // 
            this.toolFile.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newToolStripMenuItem,
            this.toolStripSeparator1,
            this.saveToolStripMenuItem});
            this.toolFile.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolFile.Name = "toolFile";
            this.toolFile.Size = new System.Drawing.Size(38, 22);
            this.toolFile.Text = "FIle";
            // 
            // newToolStripMenuItem
            // 
            this.newToolStripMenuItem.Name = "newToolStripMenuItem";
            this.newToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.newToolStripMenuItem.Text = "New";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(104, 6);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(107, 22);
            this.saveToolStripMenuItem.Text = "Save...";
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
            this.splitContainer1.Panel1MinSize = 60;
            this.splitContainer1.Size = new System.Drawing.Size(200, 583);
            this.splitContainer1.SplitterDistance = 140;
            this.splitContainer1.TabIndex = 2;
            // 
            // tabView
            // 
            this.tabView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabView.Controls.Add(this.tabErrorPage);
            this.tabView.Controls.Add(this.tabPage2);
            this.tabView.Location = new System.Drawing.Point(198, 28);
            this.tabView.Name = "tabView";
            this.tabView.SelectedIndex = 0;
            this.tabView.Size = new System.Drawing.Size(478, 583);
            this.tabView.TabIndex = 4;
            // 
            // tabErrorPage
            // 
            this.tabErrorPage.Controls.Add(this.errorDrawing);
            this.tabErrorPage.Location = new System.Drawing.Point(4, 22);
            this.tabErrorPage.Name = "tabErrorPage";
            this.tabErrorPage.Padding = new System.Windows.Forms.Padding(3);
            this.tabErrorPage.Size = new System.Drawing.Size(470, 557);
            this.tabErrorPage.TabIndex = 0;
            this.tabErrorPage.Text = "Error Graph";
            this.tabErrorPage.UseVisualStyleBackColor = true;
            this.tabErrorPage.Resize += new System.EventHandler(this.drawError);
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
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // errorDrawing
            // 
            this.errorDrawing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorDrawing.Location = new System.Drawing.Point(3, 3);
            this.errorDrawing.Name = "errorDrawing";
            this.errorDrawing.Size = new System.Drawing.Size(464, 551);
            this.errorDrawing.TabIndex = 0;
            this.errorDrawing.Paint += new System.Windows.Forms.PaintEventHandler(this.errorDrawing_Paint);
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
            this.Load += new System.EventHandler(this.Main_Load);
            this.Control.ResumeLayout(false);
            this.ControlSplitter.Panel1.ResumeLayout(false);
            this.ControlSplitter.Panel1.PerformLayout();
            this.ControlSplitter.Panel2.ResumeLayout(false);
            this.ControlSplitter.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ControlSplitter)).EndInit();
            this.ControlSplitter.ResumeLayout(false);
            this.grpKernelSettings.ResumeLayout(false);
            this.grpKernelSettings.PerformLayout();
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.tabView.ResumeLayout(false);
            this.tabErrorPage.ResumeLayout(false);
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
        private System.Windows.Forms.TabControl tabView;
        private System.Windows.Forms.TabPage tabErrorPage;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ToolStripDropDownButton toolFile;
        private System.Windows.Forms.ToolStripMenuItem newToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Panel errorDrawing;
    }
}