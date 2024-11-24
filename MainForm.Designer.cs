namespace AccountingSoftN
{
    partial class MainForm
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("Customers");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("Sales");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("Purchase Bill");
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("Invoince", new System.Windows.Forms.TreeNode[] {
            treeNode2,
            treeNode3});
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("Spend");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("Recive");
            System.Windows.Forms.TreeNode treeNode7 = new System.Windows.Forms.TreeNode("Payments", new System.Windows.Forms.TreeNode[] {
            treeNode5,
            treeNode6});
            System.Windows.Forms.TreeNode treeNode8 = new System.Windows.Forms.TreeNode("Expense");
            System.Windows.Forms.TreeNode treeNode9 = new System.Windows.Forms.TreeNode("All Tools", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode4,
            treeNode7,
            treeNode8});
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.button6);
            this.panel1.Controls.Add(this.button5);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1504, 96);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Location = new System.Drawing.Point(12, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(291, 388);
            this.panel3.TabIndex = 2;
            this.panel3.Visible = false;
            // 
            // button6
            // 
            this.button6.BackgroundImage = global::AccountingSoftN.Properties.Resources.butt_background;
            this.button6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button6.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button6.Image = global::AccountingSoftN.Properties.Resources.top_Help_butt;
            this.button6.Location = new System.Drawing.Point(481, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(142, 80);
            this.button6.TabIndex = 4;
            this.button6.Text = "help";
            this.button6.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button6.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button6.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.BackgroundImage = global::AccountingSoftN.Properties.Resources.butt_background;
            this.button5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button5.Image = global::AccountingSoftN.Properties.Resources.top_Tools_butt;
            this.button5.Location = new System.Drawing.Point(333, 12);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(142, 80);
            this.button5.TabIndex = 4;
            this.button5.Text = "tools";
            this.button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button5.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button5.UseVisualStyleBackColor = true;
            // 
            // button4
            // 
            this.button4.BackgroundImage = global::AccountingSoftN.Properties.Resources.butt_background;
            this.button4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Image = global::AccountingSoftN.Properties.Resources.top_report_butt;
            this.button4.Location = new System.Drawing.Point(170, 12);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(142, 80);
            this.button4.TabIndex = 4;
            this.button4.Text = "report";
            this.button4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.BackgroundImage = global::AccountingSoftN.Properties.Resources.butt_background;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Image = global::AccountingSoftN.Properties.Resources.top_input_butt;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(142, 80);
            this.button3.TabIndex = 3;
            this.button3.Text = "accounting";
            this.button3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.button3.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Image = global::AccountingSoftN.Properties.Resources.min_butt;
            this.button2.Location = new System.Drawing.Point(1428, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(29, 34);
            this.button2.TabIndex = 2;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Image = global::AccountingSoftN.Properties.Resources.Close_butt;
            this.button1.Location = new System.Drawing.Point(1463, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(29, 34);
            this.button1.TabIndex = 0;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // treeView1
            // 
            this.treeView1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.treeView1.HotTracking = true;
            this.treeView1.ImageIndex = 0;
            this.treeView1.ImageList = this.imageList1;
            this.treeView1.Indent = 40;
            this.treeView1.ItemHeight = 40;
            this.treeView1.Location = new System.Drawing.Point(12, 98);
            this.treeView1.Name = "treeView1";
            treeNode1.ImageIndex = 3;
            treeNode1.Name = "Customers";
            treeNode1.Text = "Customers";
            treeNode2.ImageIndex = 11;
            treeNode2.Name = "Sales";
            treeNode2.Text = "Sales";
            treeNode3.ImageIndex = 7;
            treeNode3.Name = "Purchase Bill";
            treeNode3.Text = "Purchase Bill";
            treeNode4.ImageIndex = 5;
            treeNode4.Name = "Invoince";
            treeNode4.Text = "Invoince";
            treeNode5.ImageIndex = 12;
            treeNode5.Name = "Spend";
            treeNode5.Text = "Spend";
            treeNode6.ImageIndex = 8;
            treeNode6.Name = "Recive";
            treeNode6.Text = "Recive";
            treeNode7.ImageIndex = 6;
            treeNode7.Name = "Payments";
            treeNode7.Text = "Payments";
            treeNode8.ImageIndex = 4;
            treeNode8.Name = "Expense";
            treeNode8.Text = "Expense";
            treeNode9.ImageIndex = 10;
            treeNode9.Name = "ROOT";
            treeNode9.Text = "All Tools";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode9});
            this.treeView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.treeView1.SelectedImageIndex = 0;
            this.treeView1.Size = new System.Drawing.Size(291, 388);
            this.treeView1.TabIndex = 0;
            this.treeView1.Visible = false;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            this.treeView1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseClick);
            this.treeView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.treeView1_MouseDoubleClick);
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "collapse.png");
            this.imageList1.Images.SetKeyName(1, "expand.png");
            this.imageList1.Images.SetKeyName(2, "products.png");
            this.imageList1.Images.SetKeyName(3, "tree_customers.png");
            this.imageList1.Images.SetKeyName(4, "tree_expense.png");
            this.imageList1.Images.SetKeyName(5, "tree_invoice.png");
            this.imageList1.Images.SetKeyName(6, "tree_payment.png");
            this.imageList1.Images.SetKeyName(7, "tree_purchase_bill.png");
            this.imageList1.Images.SetKeyName(8, "tree_receive.png");
            this.imageList1.Images.SetKeyName(9, "tree_reports.png");
            this.imageList1.Images.SetKeyName(10, "tree_root.png");
            this.imageList1.Images.SetKeyName(11, "tree_sale_invoice.png");
            this.imageList1.Images.SetKeyName(12, "tree_spend.png");
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.comboBox1);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 640);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1504, 41);
            this.panel2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(506, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 25);
            this.label2.TabIndex = 3;
            this.label2.Text = "jjjjjjj";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(270, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(66, 34);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "image 1",
            "image 2",
            "image 3"});
            this.comboBox1.Location = new System.Drawing.Point(119, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 33);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "background";
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1504, 681);
            this.Controls.Add(this.treeView1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button button2;
        private Button button1;
        private Panel panel2;
        private Button button3;
        private Button button6;
        private Button button5;
        private Button button4;
        private PictureBox pictureBox1;
        private ComboBox comboBox1;
        private Label label1;
        private System.Windows.Forms.Timer timer1;
        private Label label2;
        private TreeView treeView1;
        private Panel panel3;
        private ImageList imageList1;
    }
}