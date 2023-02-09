namespace Employees
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
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.TXTSalary = new System.Windows.Forms.TextBox();
            this.LBLSalary = new System.Windows.Forms.Label();
            this.TXTName = new System.Windows.Forms.TextBox();
            this.LBLName = new System.Windows.Forms.Label();
            this.LBLID = new System.Windows.Forms.Label();
            this.TXTID = new System.Windows.Forms.TextBox();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.BTNClear = new System.Windows.Forms.Button();
            this.BTNAdd = new System.Windows.Forms.Button();
            this.BTNEdit = new System.Windows.Forms.Button();
            this.BTNDelete = new System.Windows.Forms.Button();
            this.BTNExit = new System.Windows.Forms.Button();
            this.DGV = new System.Windows.Forms.DataGridView();
            this.ColID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tableLayoutPanel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).BeginInit();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.AutoSize = true;
            this.tableLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tableLayoutPanel1.Controls.Add(this.TXTSalary, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.LBLSalary, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.TXTName, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBLName, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.LBLID, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.TXTID, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.flowLayoutPanel1, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.DGV, 1, 5);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 450);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // TXTSalary
            // 
            this.TXTSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTSalary.Location = new System.Drawing.Point(99, 55);
            this.TXTSalary.Name = "TXTSalary";
            this.TXTSalary.Size = new System.Drawing.Size(144, 20);
            this.TXTSalary.TabIndex = 5;
            // 
            // LBLSalary
            // 
            this.LBLSalary.AutoSize = true;
            this.LBLSalary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLSalary.Location = new System.Drawing.Point(3, 52);
            this.LBLSalary.Name = "LBLSalary";
            this.LBLSalary.Size = new System.Drawing.Size(90, 26);
            this.LBLSalary.TabIndex = 4;
            this.LBLSalary.Text = "Enter your salary";
            // 
            // TXTName
            // 
            this.TXTName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTName.Location = new System.Drawing.Point(99, 29);
            this.TXTName.Name = "TXTName";
            this.TXTName.Size = new System.Drawing.Size(144, 20);
            this.TXTName.TabIndex = 3;
            // 
            // LBLName
            // 
            this.LBLName.AutoSize = true;
            this.LBLName.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLName.Location = new System.Drawing.Point(3, 26);
            this.LBLName.Name = "LBLName";
            this.LBLName.Size = new System.Drawing.Size(90, 26);
            this.LBLName.TabIndex = 2;
            this.LBLName.Text = "Enter your name";
            // 
            // LBLID
            // 
            this.LBLID.AutoSize = true;
            this.LBLID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LBLID.Location = new System.Drawing.Point(3, 0);
            this.LBLID.Name = "LBLID";
            this.LBLID.Size = new System.Drawing.Size(90, 26);
            this.LBLID.TabIndex = 0;
            this.LBLID.Text = "Enter your ID";
            // 
            // TXTID
            // 
            this.TXTID.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TXTID.Location = new System.Drawing.Point(99, 3);
            this.TXTID.Name = "TXTID";
            this.TXTID.Size = new System.Drawing.Size(144, 20);
            this.TXTID.TabIndex = 1;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.tableLayoutPanel1.SetColumnSpan(this.flowLayoutPanel1, 2);
            this.flowLayoutPanel1.Controls.Add(this.BTNClear);
            this.flowLayoutPanel1.Controls.Add(this.BTNAdd);
            this.flowLayoutPanel1.Controls.Add(this.BTNEdit);
            this.flowLayoutPanel1.Controls.Add(this.BTNDelete);
            this.flowLayoutPanel1.Controls.Add(this.BTNExit);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(3, 81);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(240, 29);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // BTNClear
            // 
            this.BTNClear.AutoSize = true;
            this.BTNClear.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNClear.Location = new System.Drawing.Point(3, 3);
            this.BTNClear.Name = "BTNClear";
            this.BTNClear.Size = new System.Drawing.Size(42, 23);
            this.BTNClear.TabIndex = 0;
            this.BTNClear.Text = "&Clear";
            this.BTNClear.UseVisualStyleBackColor = true;
            this.BTNClear.Click += new System.EventHandler(this.BTNClear_Click);
            // 
            // BTNAdd
            // 
            this.BTNAdd.AutoSize = true;
            this.BTNAdd.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNAdd.Location = new System.Drawing.Point(51, 3);
            this.BTNAdd.Name = "BTNAdd";
            this.BTNAdd.Size = new System.Drawing.Size(36, 23);
            this.BTNAdd.TabIndex = 1;
            this.BTNAdd.Text = "&Add";
            this.BTNAdd.UseVisualStyleBackColor = true;
            this.BTNAdd.Click += new System.EventHandler(this.BTNAdd_Click);
            // 
            // BTNEdit
            // 
            this.BTNEdit.AutoSize = true;
            this.BTNEdit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNEdit.Location = new System.Drawing.Point(93, 3);
            this.BTNEdit.Name = "BTNEdit";
            this.BTNEdit.Size = new System.Drawing.Size(35, 23);
            this.BTNEdit.TabIndex = 2;
            this.BTNEdit.Text = "&Edit";
            this.BTNEdit.UseVisualStyleBackColor = true;
            this.BTNEdit.Click += new System.EventHandler(this.BTNEdit_Click);
            // 
            // BTNDelete
            // 
            this.BTNDelete.AutoSize = true;
            this.BTNDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNDelete.Location = new System.Drawing.Point(134, 3);
            this.BTNDelete.Name = "BTNDelete";
            this.BTNDelete.Size = new System.Drawing.Size(48, 23);
            this.BTNDelete.TabIndex = 3;
            this.BTNDelete.Text = "&Delete";
            this.BTNDelete.UseVisualStyleBackColor = true;
            this.BTNDelete.Click += new System.EventHandler(this.BTNDelete_Click);
            // 
            // BTNExit
            // 
            this.BTNExit.AutoSize = true;
            this.BTNExit.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BTNExit.Location = new System.Drawing.Point(188, 3);
            this.BTNExit.Name = "BTNExit";
            this.BTNExit.Size = new System.Drawing.Size(35, 23);
            this.BTNExit.TabIndex = 4;
            this.BTNExit.Text = "E&xit";
            this.BTNExit.UseVisualStyleBackColor = true;
            this.BTNExit.Click += new System.EventHandler(this.BTNExit_Click);
            // 
            // DGV
            // 
            this.DGV.AllowUserToAddRows = false;
            this.DGV.AllowUserToDeleteRows = false;
            this.DGV.AllowUserToResizeColumns = false;
            this.DGV.AllowUserToResizeRows = false;
            this.DGV.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGV.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColID,
            this.ColName,
            this.ColSalary});
            this.tableLayoutPanel1.SetColumnSpan(this.DGV, 2);
            this.DGV.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGV.Location = new System.Drawing.Point(3, 116);
            this.DGV.MultiSelect = false;
            this.DGV.Name = "DGV";
            this.DGV.ReadOnly = true;
            this.DGV.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DGV.ShowCellErrors = false;
            this.DGV.ShowEditingIcon = false;
            this.DGV.ShowRowErrors = false;
            this.DGV.Size = new System.Drawing.Size(240, 150);
            this.DGV.StandardTab = true;
            this.DGV.TabIndex = 7;
            this.DGV.SelectionChanged += new System.EventHandler(this.DGV_SelectionChanged);
            // 
            // ColID
            // 
            this.ColID.HeaderText = "ID";
            this.ColID.Name = "ColID";
            this.ColID.ReadOnly = true;
            // 
            // ColName
            // 
            this.ColName.HeaderText = "Name";
            this.ColName.Name = "ColName";
            this.ColName.ReadOnly = true;
            // 
            // ColSalary
            // 
            this.ColSalary.HeaderText = "Salary";
            this.ColSalary.Name = "ColSalary";
            this.ColSalary.ReadOnly = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "Form1";
            this.Opacity = 0.5D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Asignment17Employees";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox TXTSalary;
        private System.Windows.Forms.Label LBLSalary;
        private System.Windows.Forms.TextBox TXTName;
        private System.Windows.Forms.Label LBLName;
        private System.Windows.Forms.Label LBLID;
        private System.Windows.Forms.TextBox TXTID;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button BTNClear;
        private System.Windows.Forms.Button BTNAdd;
        private System.Windows.Forms.Button BTNEdit;
        private System.Windows.Forms.Button BTNDelete;
        private System.Windows.Forms.Button BTNExit;
        private System.Windows.Forms.DataGridView DGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColSalary;
    }
}

