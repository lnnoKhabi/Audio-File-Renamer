namespace Audio_Files_Renamer
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
			this.tableLayoutPanel_Main = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel_EditBrowse = new System.Windows.Forms.TableLayoutPanel();
			this.button1_Browse = new System.Windows.Forms.Button();
			this.groupBox1_Edit = new System.Windows.Forms.GroupBox();
			this.checkBox6_All = new System.Windows.Forms.CheckBox();
			this.checkBox5_Genre = new System.Windows.Forms.CheckBox();
			this.checkBox4_Album = new System.Windows.Forms.CheckBox();
			this.checkBox3_Artist = new System.Windows.Forms.CheckBox();
			this.checkBox2_Title = new System.Windows.Forms.CheckBox();
			this.checkBox1_Name = new System.Windows.Forms.CheckBox();
			this.tableLayoutPanel1_Buttons = new System.Windows.Forms.TableLayoutPanel();
			this.button3_Save = new System.Windows.Forms.Button();
			this.button2_Cancel = new System.Windows.Forms.Button();
			this.richTextBox1 = new System.Windows.Forms.RichTextBox();
			this.groupBox_LoadedFiles = new System.Windows.Forms.GroupBox();
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1_Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader2_Title = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader3_Artist = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader4_Album = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.columnHeader5_Genre = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
			this.tableLayoutPanel_Main.SuspendLayout();
			this.tableLayoutPanel_EditBrowse.SuspendLayout();
			this.groupBox1_Edit.SuspendLayout();
			this.tableLayoutPanel1_Buttons.SuspendLayout();
			this.groupBox_LoadedFiles.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel_Main
			// 
			this.tableLayoutPanel_Main.ColumnCount = 1;
			this.tableLayoutPanel_Main.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel_EditBrowse, 0, 0);
			this.tableLayoutPanel_Main.Controls.Add(this.tableLayoutPanel1_Buttons, 0, 2);
			this.tableLayoutPanel_Main.Controls.Add(this.groupBox_LoadedFiles, 0, 1);
			this.tableLayoutPanel_Main.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_Main.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel_Main.Name = "tableLayoutPanel_Main";
			this.tableLayoutPanel_Main.RowCount = 3;
			this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
			this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 75.95628F));
			this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 9.289618F));
			this.tableLayoutPanel_Main.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel_Main.Size = new System.Drawing.Size(600, 366);
			this.tableLayoutPanel_Main.TabIndex = 0;
			// 
			// tableLayoutPanel_EditBrowse
			// 
			this.tableLayoutPanel_EditBrowse.ColumnCount = 2;
			this.tableLayoutPanel_EditBrowse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
			this.tableLayoutPanel_EditBrowse.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 24F));
			this.tableLayoutPanel_EditBrowse.Controls.Add(this.button1_Browse, 1, 0);
			this.tableLayoutPanel_EditBrowse.Controls.Add(this.groupBox1_Edit, 0, 0);
			this.tableLayoutPanel_EditBrowse.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel_EditBrowse.Location = new System.Drawing.Point(3, 3);
			this.tableLayoutPanel_EditBrowse.Name = "tableLayoutPanel_EditBrowse";
			this.tableLayoutPanel_EditBrowse.RowCount = 1;
			this.tableLayoutPanel_EditBrowse.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel_EditBrowse.Size = new System.Drawing.Size(594, 48);
			this.tableLayoutPanel_EditBrowse.TabIndex = 0;
			// 
			// button1_Browse
			// 
			this.button1_Browse.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.button1_Browse.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button1_Browse.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button1_Browse.Location = new System.Drawing.Point(454, 22);
			this.button1_Browse.Name = "button1_Browse";
			this.button1_Browse.Size = new System.Drawing.Size(137, 23);
			this.button1_Browse.TabIndex = 0;
			this.button1_Browse.Text = "Browse folder...";
			this.button1_Browse.UseVisualStyleBackColor = true;
			this.button1_Browse.Click += new System.EventHandler(this.button1_Browse_Click);
			// 
			// groupBox1_Edit
			// 
			this.groupBox1_Edit.Controls.Add(this.checkBox6_All);
			this.groupBox1_Edit.Controls.Add(this.checkBox5_Genre);
			this.groupBox1_Edit.Controls.Add(this.checkBox4_Album);
			this.groupBox1_Edit.Controls.Add(this.checkBox3_Artist);
			this.groupBox1_Edit.Controls.Add(this.checkBox2_Title);
			this.groupBox1_Edit.Controls.Add(this.checkBox1_Name);
			this.groupBox1_Edit.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox1_Edit.Location = new System.Drawing.Point(3, 3);
			this.groupBox1_Edit.Name = "groupBox1_Edit";
			this.groupBox1_Edit.Size = new System.Drawing.Size(445, 42);
			this.groupBox1_Edit.TabIndex = 1;
			this.groupBox1_Edit.TabStop = false;
			this.groupBox1_Edit.Text = "Edit";
			// 
			// checkBox6_All
			// 
			this.checkBox6_All.AutoSize = true;
			this.checkBox6_All.Dock = System.Windows.Forms.DockStyle.Left;
			this.checkBox6_All.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox6_All.Location = new System.Drawing.Point(292, 16);
			this.checkBox6_All.Name = "checkBox6_All";
			this.checkBox6_All.Size = new System.Drawing.Size(43, 23);
			this.checkBox6_All.TabIndex = 5;
			this.checkBox6_All.Text = "All";
			this.checkBox6_All.UseVisualStyleBackColor = true;
			// 
			// checkBox5_Genre
			// 
			this.checkBox5_Genre.AutoSize = true;
			this.checkBox5_Genre.Dock = System.Windows.Forms.DockStyle.Left;
			this.checkBox5_Genre.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox5_Genre.Location = new System.Drawing.Point(231, 16);
			this.checkBox5_Genre.Name = "checkBox5_Genre";
			this.checkBox5_Genre.Size = new System.Drawing.Size(61, 23);
			this.checkBox5_Genre.TabIndex = 4;
			this.checkBox5_Genre.Text = "Genre";
			this.checkBox5_Genre.UseVisualStyleBackColor = true;
			// 
			// checkBox4_Album
			// 
			this.checkBox4_Album.AutoSize = true;
			this.checkBox4_Album.Dock = System.Windows.Forms.DockStyle.Left;
			this.checkBox4_Album.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox4_Album.Location = new System.Drawing.Point(170, 16);
			this.checkBox4_Album.Name = "checkBox4_Album";
			this.checkBox4_Album.Size = new System.Drawing.Size(61, 23);
			this.checkBox4_Album.TabIndex = 3;
			this.checkBox4_Album.Text = "Album";
			this.checkBox4_Album.UseVisualStyleBackColor = true;
			// 
			// checkBox3_Artist
			// 
			this.checkBox3_Artist.AutoSize = true;
			this.checkBox3_Artist.Dock = System.Windows.Forms.DockStyle.Left;
			this.checkBox3_Artist.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox3_Artist.Location = new System.Drawing.Point(115, 16);
			this.checkBox3_Artist.Name = "checkBox3_Artist";
			this.checkBox3_Artist.Size = new System.Drawing.Size(55, 23);
			this.checkBox3_Artist.TabIndex = 2;
			this.checkBox3_Artist.Text = "Artist";
			this.checkBox3_Artist.UseVisualStyleBackColor = true;
			// 
			// checkBox2_Title
			// 
			this.checkBox2_Title.AutoSize = true;
			this.checkBox2_Title.Dock = System.Windows.Forms.DockStyle.Left;
			this.checkBox2_Title.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox2_Title.Location = new System.Drawing.Point(63, 16);
			this.checkBox2_Title.Name = "checkBox2_Title";
			this.checkBox2_Title.Size = new System.Drawing.Size(52, 23);
			this.checkBox2_Title.TabIndex = 1;
			this.checkBox2_Title.Text = "Title";
			this.checkBox2_Title.UseVisualStyleBackColor = true;
			// 
			// checkBox1_Name
			// 
			this.checkBox1_Name.AutoSize = true;
			this.checkBox1_Name.Dock = System.Windows.Forms.DockStyle.Left;
			this.checkBox1_Name.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.checkBox1_Name.Location = new System.Drawing.Point(3, 16);
			this.checkBox1_Name.Name = "checkBox1_Name";
			this.checkBox1_Name.Size = new System.Drawing.Size(60, 23);
			this.checkBox1_Name.TabIndex = 0;
			this.checkBox1_Name.Text = "Name";
			this.checkBox1_Name.UseVisualStyleBackColor = true;
			// 
			// tableLayoutPanel1_Buttons
			// 
			this.tableLayoutPanel1_Buttons.ColumnCount = 3;
			this.tableLayoutPanel1_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76F));
			this.tableLayoutPanel1_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
			this.tableLayoutPanel1_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 12F));
			this.tableLayoutPanel1_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1_Buttons.Controls.Add(this.button3_Save, 2, 0);
			this.tableLayoutPanel1_Buttons.Controls.Add(this.button2_Cancel, 1, 0);
			this.tableLayoutPanel1_Buttons.Controls.Add(this.richTextBox1, 0, 0);
			this.tableLayoutPanel1_Buttons.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1_Buttons.Location = new System.Drawing.Point(3, 334);
			this.tableLayoutPanel1_Buttons.Name = "tableLayoutPanel1_Buttons";
			this.tableLayoutPanel1_Buttons.RowCount = 1;
			this.tableLayoutPanel1_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1_Buttons.Size = new System.Drawing.Size(594, 29);
			this.tableLayoutPanel1_Buttons.TabIndex = 3;
			// 
			// button3_Save
			// 
			this.button3_Save.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button3_Save.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button3_Save.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button3_Save.Location = new System.Drawing.Point(525, 3);
			this.button3_Save.Name = "button3_Save";
			this.button3_Save.Size = new System.Drawing.Size(66, 23);
			this.button3_Save.TabIndex = 2;
			this.button3_Save.Text = "Save";
			this.button3_Save.UseVisualStyleBackColor = true;
			// 
			// button2_Cancel
			// 
			this.button2_Cancel.Dock = System.Windows.Forms.DockStyle.Fill;
			this.button2_Cancel.FlatAppearance.BorderColor = System.Drawing.Color.DimGray;
			this.button2_Cancel.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.button2_Cancel.Location = new System.Drawing.Point(454, 3);
			this.button2_Cancel.Name = "button2_Cancel";
			this.button2_Cancel.Size = new System.Drawing.Size(65, 23);
			this.button2_Cancel.TabIndex = 3;
			this.button2_Cancel.Text = "Cancel";
			this.button2_Cancel.UseVisualStyleBackColor = true;
			// 
			// richTextBox1
			// 
			this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.richTextBox1.ForeColor = System.Drawing.Color.Gray;
			this.richTextBox1.Location = new System.Drawing.Point(3, 3);
			this.richTextBox1.Name = "richTextBox1";
			this.richTextBox1.Size = new System.Drawing.Size(445, 23);
			this.richTextBox1.TabIndex = 5;
			this.richTextBox1.Text = "Enter phrase to edit here";
			// 
			// groupBox_LoadedFiles
			// 
			this.groupBox_LoadedFiles.Controls.Add(this.listView1);
			this.groupBox_LoadedFiles.Dock = System.Windows.Forms.DockStyle.Fill;
			this.groupBox_LoadedFiles.FlatStyle = System.Windows.Forms.FlatStyle.System;
			this.groupBox_LoadedFiles.Location = new System.Drawing.Point(3, 57);
			this.groupBox_LoadedFiles.Name = "groupBox_LoadedFiles";
			this.groupBox_LoadedFiles.Size = new System.Drawing.Size(594, 271);
			this.groupBox_LoadedFiles.TabIndex = 4;
			this.groupBox_LoadedFiles.TabStop = false;
			this.groupBox_LoadedFiles.Text = "Loaded files";
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1_Name,
            this.columnHeader2_Title,
            this.columnHeader3_Artist,
            this.columnHeader4_Album,
            this.columnHeader5_Genre});
			this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.listView1.FullRowSelect = true;
			this.listView1.GridLines = true;
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(3, 16);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(588, 252);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1_Name
			// 
			this.columnHeader1_Name.Text = "Name";
			this.columnHeader1_Name.Width = 169;
			// 
			// columnHeader2_Title
			// 
			this.columnHeader2_Title.Text = "Title";
			this.columnHeader2_Title.Width = 148;
			// 
			// columnHeader3_Artist
			// 
			this.columnHeader3_Artist.Text = "Artist";
			this.columnHeader3_Artist.Width = 103;
			// 
			// columnHeader4_Album
			// 
			this.columnHeader4_Album.Text = "Album";
			this.columnHeader4_Album.Width = 92;
			// 
			// columnHeader5_Genre
			// 
			this.columnHeader5_Genre.Text = "Genre";
			this.columnHeader5_Genre.Width = 65;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(600, 366);
			this.Controls.Add(this.tableLayoutPanel_Main);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Margin = new System.Windows.Forms.Padding(2);
			this.Name = "Form1";
			this.Text = "Audio File Renamer";
			this.tableLayoutPanel_Main.ResumeLayout(false);
			this.tableLayoutPanel_EditBrowse.ResumeLayout(false);
			this.groupBox1_Edit.ResumeLayout(false);
			this.groupBox1_Edit.PerformLayout();
			this.tableLayoutPanel1_Buttons.ResumeLayout(false);
			this.groupBox_LoadedFiles.ResumeLayout(false);
			this.ResumeLayout(false);

        }

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_Main;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel_EditBrowse;
		private System.Windows.Forms.Button button1_Browse;
		private System.Windows.Forms.GroupBox groupBox1_Edit;
		private System.Windows.Forms.CheckBox checkBox6_All;
		private System.Windows.Forms.CheckBox checkBox5_Genre;
		private System.Windows.Forms.CheckBox checkBox4_Album;
		private System.Windows.Forms.CheckBox checkBox3_Artist;
		private System.Windows.Forms.CheckBox checkBox2_Title;
		private System.Windows.Forms.CheckBox checkBox1_Name;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1_Buttons;
		private System.Windows.Forms.Button button3_Save;
		private System.Windows.Forms.Button button2_Cancel;
		private System.Windows.Forms.GroupBox groupBox_LoadedFiles;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ColumnHeader columnHeader1_Name;
		private System.Windows.Forms.ColumnHeader columnHeader2_Title;
		private System.Windows.Forms.ColumnHeader columnHeader3_Artist;
		private System.Windows.Forms.ColumnHeader columnHeader4_Album;
		private System.Windows.Forms.ColumnHeader columnHeader5_Genre;
		private System.Windows.Forms.RichTextBox richTextBox1;
	}
}

