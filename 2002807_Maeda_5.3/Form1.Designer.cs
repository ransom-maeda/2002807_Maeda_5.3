namespace _2002807_Maeda_5._3
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.payToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.summaryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clearToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.fontToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.colorChange = new System.Windows.Forms.ColorDialog();
            this.fontChange = new System.Windows.Forms.FontDialog();
            this.nameInput = new System.Windows.Forms.TextBox();
            this.weeklyInput = new System.Windows.Forms.TextBox();
            this.labelName = new System.Windows.Forms.Label();
            this.labelWeekly = new System.Windows.Forms.Label();
            this.labelPay = new System.Windows.Forms.Label();
            this.payOutput = new System.Windows.Forms.TextBox();
            this.commissionOutput = new System.Windows.Forms.TextBox();
            this.labelCommission = new System.Windows.Forms.Label();
            this.salesOutput = new System.Windows.Forms.TextBox();
            this.labelSales = new System.Windows.Forms.Label();
            this.menuStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(800, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.payToolStripMenuItem,
            this.summaryToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // payToolStripMenuItem
            // 
            this.payToolStripMenuItem.Name = "payToolStripMenuItem";
            this.payToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.payToolStripMenuItem.Text = "&Pay";
            this.payToolStripMenuItem.Click += new System.EventHandler(this.payToolStripMenuItem_Click);
            // 
            // summaryToolStripMenuItem
            // 
            this.summaryToolStripMenuItem.Name = "summaryToolStripMenuItem";
            this.summaryToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.summaryToolStripMenuItem.Text = "&Summary";
            this.summaryToolStripMenuItem.Click += new System.EventHandler(this.summaryToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clearToolStripMenuItem,
            this.toolStripSeparator1,
            this.fontToolStripMenuItem,
            this.colorToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // clearToolStripMenuItem
            // 
            this.clearToolStripMenuItem.Name = "clearToolStripMenuItem";
            this.clearToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.clearToolStripMenuItem.Text = "C&lear";
            this.clearToolStripMenuItem.Click += new System.EventHandler(this.clearToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // fontToolStripMenuItem
            // 
            this.fontToolStripMenuItem.Name = "fontToolStripMenuItem";
            this.fontToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.fontToolStripMenuItem.Text = "&Font";
            this.fontToolStripMenuItem.Click += new System.EventHandler(this.fontToolStripMenuItem_Click);
            // 
            // colorToolStripMenuItem
            // 
            this.colorToolStripMenuItem.Name = "colorToolStripMenuItem";
            this.colorToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.colorToolStripMenuItem.Text = "&Color";
            this.colorToolStripMenuItem.Click += new System.EventHandler(this.colorToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // nameInput
            // 
            this.nameInput.Location = new System.Drawing.Point(114, 138);
            this.nameInput.Name = "nameInput";
            this.nameInput.Size = new System.Drawing.Size(100, 20);
            this.nameInput.TabIndex = 1;
            // 
            // weeklyInput
            // 
            this.weeklyInput.Location = new System.Drawing.Point(114, 164);
            this.weeklyInput.Name = "weeklyInput";
            this.weeklyInput.Size = new System.Drawing.Size(100, 20);
            this.weeklyInput.TabIndex = 2;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(12, 141);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(96, 13);
            this.labelName.TabIndex = 3;
            this.labelName.Text = "Salesperson Name";
            // 
            // labelWeekly
            // 
            this.labelWeekly.AutoSize = true;
            this.labelWeekly.Location = new System.Drawing.Point(12, 167);
            this.labelWeekly.Name = "labelWeekly";
            this.labelWeekly.Size = new System.Drawing.Size(72, 13);
            this.labelWeekly.TabIndex = 4;
            this.labelWeekly.Text = "Weekly Sales";
            // 
            // labelPay
            // 
            this.labelPay.AutoSize = true;
            this.labelPay.Location = new System.Drawing.Point(12, 257);
            this.labelPay.Name = "labelPay";
            this.labelPay.Size = new System.Drawing.Size(25, 13);
            this.labelPay.TabIndex = 5;
            this.labelPay.Text = "Pay";
            // 
            // payOutput
            // 
            this.payOutput.Location = new System.Drawing.Point(114, 257);
            this.payOutput.Name = "payOutput";
            this.payOutput.Size = new System.Drawing.Size(100, 20);
            this.payOutput.TabIndex = 6;
            // 
            // commissionOutput
            // 
            this.commissionOutput.Location = new System.Drawing.Point(114, 280);
            this.commissionOutput.Name = "commissionOutput";
            this.commissionOutput.Size = new System.Drawing.Size(100, 20);
            this.commissionOutput.TabIndex = 7;
            // 
            // labelCommission
            // 
            this.labelCommission.AutoSize = true;
            this.labelCommission.Location = new System.Drawing.Point(12, 283);
            this.labelCommission.Name = "labelCommission";
            this.labelCommission.Size = new System.Drawing.Size(62, 13);
            this.labelCommission.TabIndex = 8;
            this.labelCommission.Text = "Commission";
            // 
            // salesOutput
            // 
            this.salesOutput.Location = new System.Drawing.Point(114, 306);
            this.salesOutput.Name = "salesOutput";
            this.salesOutput.Size = new System.Drawing.Size(100, 20);
            this.salesOutput.TabIndex = 9;
            // 
            // labelSales
            // 
            this.labelSales.AutoSize = true;
            this.labelSales.Location = new System.Drawing.Point(12, 309);
            this.labelSales.Name = "labelSales";
            this.labelSales.Size = new System.Drawing.Size(33, 13);
            this.labelSales.TabIndex = 10;
            this.labelSales.Text = "Sales";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelSales);
            this.Controls.Add(this.salesOutput);
            this.Controls.Add(this.labelCommission);
            this.Controls.Add(this.commissionOutput);
            this.Controls.Add(this.payOutput);
            this.Controls.Add(this.labelPay);
            this.Controls.Add(this.labelWeekly);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.weeklyInput);
            this.Controls.Add(this.nameInput);
            this.Controls.Add(this.menuStrip);
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Form1";
            this.Text = "5.3";
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem payToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem summaryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clearToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem fontToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem colorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ColorDialog colorChange;
        private System.Windows.Forms.FontDialog fontChange;
        private System.Windows.Forms.TextBox nameInput;
        private System.Windows.Forms.TextBox weeklyInput;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelWeekly;
        private System.Windows.Forms.Label labelPay;
        private System.Windows.Forms.TextBox payOutput;
        private System.Windows.Forms.TextBox commissionOutput;
        private System.Windows.Forms.Label labelCommission;
        private System.Windows.Forms.TextBox salesOutput;
        private System.Windows.Forms.Label labelSales;
    }
}

