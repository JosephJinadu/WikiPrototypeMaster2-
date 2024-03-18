namespace WIkiPrototypeMaster
{
    partial class FormWiki
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
            this.listview_Array = new System.Windows.Forms.ListView();
            this.columnName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnCatgory = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SearchLbl = new System.Windows.Forms.Label();
            this.Searchtxtbox = new System.Windows.Forms.TextBox();
            this.SearchBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.EditBtn = new System.Windows.Forms.Button();
            this.AddBtn = new System.Windows.Forms.Button();
            this.LoadBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.ResetBtn = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.DataStructureNameLbl = new System.Windows.Forms.Label();
            this.CategoryLbl = new System.Windows.Forms.Label();
            this.DefintionLbl = new System.Windows.Forms.Label();
            this.StructureLbl = new System.Windows.Forms.Label();
            this.datastructuretxtbox = new System.Windows.Forms.TextBox();
            this.Categorytxtbox = new System.Windows.Forms.TextBox();
            this.Structuretxtbox = new System.Windows.Forms.TextBox();
            this.defintiontxtbox = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listview_Array
            // 
            this.listview_Array.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnName,
            this.columnCatgory});
            this.listview_Array.HideSelection = false;
            this.listview_Array.Location = new System.Drawing.Point(-4, -2);
            this.listview_Array.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.listview_Array.Name = "listview_Array";
            this.listview_Array.Size = new System.Drawing.Size(552, 754);
            this.listview_Array.TabIndex = 0;
            this.listview_Array.UseCompatibleStateImageBehavior = false;
            this.listview_Array.View = System.Windows.Forms.View.Details;
            this.listview_Array.SelectedIndexChanged += new System.EventHandler(this.listview_Array_SelectedIndexChanged);
            // 
            // columnName
            // 
            this.columnName.Text = "Name";
            // 
            // columnCatgory
            // 
            this.columnCatgory.Text = "Category";
            // 
            // SearchLbl
            // 
            this.SearchLbl.AutoSize = true;
            this.SearchLbl.Location = new System.Drawing.Point(738, 56);
            this.SearchLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.SearchLbl.Name = "SearchLbl";
            this.SearchLbl.Size = new System.Drawing.Size(80, 25);
            this.SearchLbl.TabIndex = 2;
            this.SearchLbl.Text = "Search";
            // 
            // Searchtxtbox
            // 
            this.Searchtxtbox.Location = new System.Drawing.Point(900, 50);
            this.Searchtxtbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Searchtxtbox.Name = "Searchtxtbox";
            this.Searchtxtbox.Size = new System.Drawing.Size(196, 31);
            this.Searchtxtbox.TabIndex = 3;
            // 
            // SearchBtn
            // 
            this.SearchBtn.Location = new System.Drawing.Point(1112, 56);
            this.SearchBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SearchBtn.Name = "SearchBtn";
            this.SearchBtn.Size = new System.Drawing.Size(150, 44);
            this.SearchBtn.TabIndex = 4;
            this.SearchBtn.Text = "Search";
            this.SearchBtn.UseVisualStyleBackColor = true;
            this.SearchBtn.Click += new System.EventHandler(this.SearchBtn_Click_1);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(1568, 492);
            this.DeleteBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(150, 88);
            this.DeleteBtn.TabIndex = 5;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // EditBtn
            // 
            this.EditBtn.Location = new System.Drawing.Point(1568, 356);
            this.EditBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.EditBtn.Name = "EditBtn";
            this.EditBtn.Size = new System.Drawing.Size(150, 88);
            this.EditBtn.TabIndex = 6;
            this.EditBtn.Text = "Edit ";
            this.EditBtn.UseVisualStyleBackColor = true;
            this.EditBtn.Click += new System.EventHandler(this.EditBtn_Click);
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(1568, 217);
            this.AddBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(150, 88);
            this.AddBtn.TabIndex = 7;
            this.AddBtn.Text = "Add";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.Location = new System.Drawing.Point(186, 779);
            this.LoadBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.Size = new System.Drawing.Size(150, 131);
            this.LoadBtn.TabIndex = 9;
            this.LoadBtn.Text = "Load";
            this.LoadBtn.UseVisualStyleBackColor = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(-4, 783);
            this.SaveBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(150, 127);
            this.SaveBtn.TabIndex = 10;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // ResetBtn
            // 
            this.ResetBtn.Location = new System.Drawing.Point(402, 779);
            this.ResetBtn.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.ResetBtn.Name = "ResetBtn";
            this.ResetBtn.Size = new System.Drawing.Size(150, 138);
            this.ResetBtn.TabIndex = 11;
            this.ResetBtn.Text = "Reset";
            this.ResetBtn.UseVisualStyleBackColor = true;
            this.ResetBtn.Click += new System.EventHandler(this.ResetBtn_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 1096);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 28, 0);
            this.statusStrip1.Size = new System.Drawing.Size(2042, 42);
            this.statusStrip1.TabIndex = 12;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(237, 32);
            this.toolStripStatusLabel1.Text = "toolStripStatusLabel1";
            // 
            // DataStructureNameLbl
            // 
            this.DataStructureNameLbl.AutoSize = true;
            this.DataStructureNameLbl.Location = new System.Drawing.Point(850, 250);
            this.DataStructureNameLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DataStructureNameLbl.Name = "DataStructureNameLbl";
            this.DataStructureNameLbl.Size = new System.Drawing.Size(212, 25);
            this.DataStructureNameLbl.TabIndex = 13;
            this.DataStructureNameLbl.Text = "Data Structure Name";
            // 
            // CategoryLbl
            // 
            this.CategoryLbl.AutoSize = true;
            this.CategoryLbl.Location = new System.Drawing.Point(966, 333);
            this.CategoryLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.CategoryLbl.Name = "CategoryLbl";
            this.CategoryLbl.Size = new System.Drawing.Size(99, 25);
            this.CategoryLbl.TabIndex = 14;
            this.CategoryLbl.Text = "Category";
            // 
            // DefintionLbl
            // 
            this.DefintionLbl.AutoSize = true;
            this.DefintionLbl.Location = new System.Drawing.Point(688, 587);
            this.DefintionLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.DefintionLbl.Name = "DefintionLbl";
            this.DefintionLbl.Size = new System.Drawing.Size(108, 25);
            this.DefintionLbl.TabIndex = 15;
            this.DefintionLbl.Text = "Definition ";
            // 
            // StructureLbl
            // 
            this.StructureLbl.AutoSize = true;
            this.StructureLbl.Location = new System.Drawing.Point(958, 458);
            this.StructureLbl.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.StructureLbl.Name = "StructureLbl";
            this.StructureLbl.Size = new System.Drawing.Size(105, 25);
            this.StructureLbl.TabIndex = 16;
            this.StructureLbl.Text = "Structure ";
            // 
            // datastructuretxtbox
            // 
            this.datastructuretxtbox.Location = new System.Drawing.Point(1076, 235);
            this.datastructuretxtbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.datastructuretxtbox.Name = "datastructuretxtbox";
            this.datastructuretxtbox.Size = new System.Drawing.Size(196, 31);
            this.datastructuretxtbox.TabIndex = 17;
            // 
            // Categorytxtbox
            // 
            this.Categorytxtbox.Location = new System.Drawing.Point(1076, 333);
            this.Categorytxtbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Categorytxtbox.Name = "Categorytxtbox";
            this.Categorytxtbox.Size = new System.Drawing.Size(196, 31);
            this.Categorytxtbox.TabIndex = 18;
            // 
            // Structuretxtbox
            // 
            this.Structuretxtbox.Location = new System.Drawing.Point(1076, 458);
            this.Structuretxtbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Structuretxtbox.Name = "Structuretxtbox";
            this.Structuretxtbox.Size = new System.Drawing.Size(196, 31);
            this.Structuretxtbox.TabIndex = 19;
            // 
            // defintiontxtbox
            // 
            this.defintiontxtbox.Location = new System.Drawing.Point(692, 617);
            this.defintiontxtbox.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.defintiontxtbox.Multiline = true;
            this.defintiontxtbox.Name = "defintiontxtbox";
            this.defintiontxtbox.Size = new System.Drawing.Size(420, 389);
            this.defintiontxtbox.TabIndex = 20;
            // 
            // FormWiki
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2042, 1138);
            this.Controls.Add(this.defintiontxtbox);
            this.Controls.Add(this.Structuretxtbox);
            this.Controls.Add(this.Categorytxtbox);
            this.Controls.Add(this.datastructuretxtbox);
            this.Controls.Add(this.StructureLbl);
            this.Controls.Add(this.DefintionLbl);
            this.Controls.Add(this.CategoryLbl);
            this.Controls.Add(this.DataStructureNameLbl);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.ResetBtn);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.LoadBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.EditBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.SearchBtn);
            this.Controls.Add(this.Searchtxtbox);
            this.Controls.Add(this.SearchLbl);
            this.Controls.Add(this.listview_Array);
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "FormWiki";
            this.Text = "Data Structure Wiki";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listview_Array;
        private System.Windows.Forms.ColumnHeader columnName;
        private System.Windows.Forms.ColumnHeader columnCatgory;
        private System.Windows.Forms.Label SearchLbl;
        private System.Windows.Forms.TextBox Searchtxtbox;
        private System.Windows.Forms.Button SearchBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button EditBtn;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button LoadBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button ResetBtn;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Label DataStructureNameLbl;
        private System.Windows.Forms.Label CategoryLbl;
        private System.Windows.Forms.Label DefintionLbl;
        private System.Windows.Forms.Label StructureLbl;
        private System.Windows.Forms.TextBox datastructuretxtbox;
        private System.Windows.Forms.TextBox Categorytxtbox;
        private System.Windows.Forms.TextBox Structuretxtbox;
        private System.Windows.Forms.TextBox defintiontxtbox;
    }
}

