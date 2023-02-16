using System.Windows.Forms;

namespace StudentManagement
{
    partial class Frame
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frame));
            this.sId = new System.Windows.Forms.Label();
            this.sName = new System.Windows.Forms.Label();
            this.sBirthDay = new System.Windows.Forms.Label();
            this.fTime = new System.Windows.Forms.Label();
            this.sTime = new System.Windows.Forms.Label();
            this.IId = new System.Windows.Forms.TextBox();
            this.IName = new System.Windows.Forms.TextBox();
            this.IDate = new System.Windows.Forms.DateTimePicker();
            this.IFScore = new System.Windows.Forms.TextBox();
            this.ISScore = new System.Windows.Forms.TextBox();
            this.addBtn = new System.Windows.Forms.Button();
            this.updateBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.searchBtn = new System.Windows.Forms.Button();
            this.sListView = new System.Windows.Forms.ListView();
            this.Index = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.IdColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.NameColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.birthdayColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.fTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.sTimeColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.averageColumn = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // sId
            // 
            this.sId.AutoSize = true;
            this.sId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sId.Location = new System.Drawing.Point(48, 32);
            this.sId.Name = "sId";
            this.sId.Size = new System.Drawing.Size(44, 15);
            this.sId.TabIndex = 0;
            this.sId.Text = "Mã SV:";
            // 
            // sName
            // 
            this.sName.AutoSize = true;
            this.sName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sName.Location = new System.Drawing.Point(48, 64);
            this.sName.Name = "sName";
            this.sName.Size = new System.Drawing.Size(49, 15);
            this.sName.TabIndex = 1;
            this.sName.Text = "Tên SV:";
            // 
            // sBirthDay
            // 
            this.sBirthDay.AutoSize = true;
            this.sBirthDay.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sBirthDay.Location = new System.Drawing.Point(48, 96);
            this.sBirthDay.Name = "sBirthDay";
            this.sBirthDay.Size = new System.Drawing.Size(65, 15);
            this.sBirthDay.TabIndex = 2;
            this.sBirthDay.Text = "Ngày sinh:";
            // 
            // fTime
            // 
            this.fTime.AutoSize = true;
            this.fTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.fTime.Location = new System.Drawing.Point(48, 128);
            this.fTime.Name = "fTime";
            this.fTime.Size = new System.Drawing.Size(70, 15);
            this.fTime.TabIndex = 3;
            this.fTime.Text = "Điểm lần 1:";
            // 
            // sTime
            // 
            this.sTime.AutoSize = true;
            this.sTime.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sTime.Location = new System.Drawing.Point(48, 160);
            this.sTime.Name = "sTime";
            this.sTime.Size = new System.Drawing.Size(70, 15);
            this.sTime.TabIndex = 4;
            this.sTime.Text = "Điểm lần 2:";
            // 
            // IId
            // 
            this.IId.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IId.Location = new System.Drawing.Point(152, 24);
            this.IId.Name = "IId";
            this.IId.Size = new System.Drawing.Size(264, 21);
            this.IId.TabIndex = 5;
            // 
            // IName
            // 
            this.IName.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IName.Location = new System.Drawing.Point(152, 56);
            this.IName.Name = "IName";
            this.IName.Size = new System.Drawing.Size(264, 21);
            this.IName.TabIndex = 6;
            // 
            // IDate
            // 
            this.IDate.CustomFormat = "dd/MM/yyyy";
            this.IDate.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.IDate.Location = new System.Drawing.Point(152, 88);
            this.IDate.Margin = new System.Windows.Forms.Padding(10, 3, 10, 3);
            this.IDate.MaxDate = new System.DateTime(2023, 2, 16, 17, 46, 49, 716);
            this.IDate.Name = "IDate";
            this.IDate.Size = new System.Drawing.Size(264, 21);
            this.IDate.TabIndex = 7;
            this.IDate.Value = new System.DateTime(2023, 2, 16, 17, 46, 49, 716);
            // 
            // IFScore
            // 
            this.IFScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.IFScore.Location = new System.Drawing.Point(152, 120);
            this.IFScore.Name = "IFScore";
            this.IFScore.Size = new System.Drawing.Size(264, 21);
            this.IFScore.TabIndex = 8;
            // 
            // ISScore
            // 
            this.ISScore.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.ISScore.Location = new System.Drawing.Point(152, 152);
            this.ISScore.Name = "ISScore";
            this.ISScore.Size = new System.Drawing.Size(264, 21);
            this.ISScore.TabIndex = 9;
            // 
            // addBtn
            // 
            this.addBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.addBtn.Location = new System.Drawing.Point(496, 24);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(136, 32);
            this.addBtn.TabIndex = 10;
            this.addBtn.Text = "Thêm";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // updateBtn
            // 
            this.updateBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.updateBtn.Location = new System.Drawing.Point(496, 64);
            this.updateBtn.Name = "updateBtn";
            this.updateBtn.Size = new System.Drawing.Size(136, 32);
            this.updateBtn.TabIndex = 11;
            this.updateBtn.Text = "Cập nhật";
            this.updateBtn.UseVisualStyleBackColor = true;
            this.updateBtn.Click += new System.EventHandler(this.updateBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.deleteBtn.Location = new System.Drawing.Point(496, 104);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(136, 32);
            this.deleteBtn.TabIndex = 12;
            this.deleteBtn.Text = "Xoá";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // searchBtn
            // 
            this.searchBtn.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.searchBtn.Location = new System.Drawing.Point(496, 144);
            this.searchBtn.Name = "searchBtn";
            this.searchBtn.Size = new System.Drawing.Size(136, 32);
            this.searchBtn.TabIndex = 13;
            this.searchBtn.Text = "Tìm kiếm";
            this.searchBtn.UseVisualStyleBackColor = true;
            this.searchBtn.Click += new System.EventHandler(this.searchBtn_Click);
            // 
            // sListView
            // 
            this.sListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Index,
            this.IdColumn,
            this.NameColumn,
            this.birthdayColumn,
            this.fTimeColumn,
            this.sTimeColumn,
            this.averageColumn});
            this.sListView.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.sListView.HideSelection = false;
            this.sListView.Location = new System.Drawing.Point(32, 208);
            this.sListView.Name = "sListView";
            this.sListView.Scrollable = false;
            this.sListView.Size = new System.Drawing.Size(624, 272);
            this.sListView.TabIndex = 14;
            this.sListView.UseCompatibleStateImageBehavior = false;
            this.sListView.View = System.Windows.Forms.View.Details;
            this.sListView.SelectedIndexChanged += new System.EventHandler(this.selectedIndexChanged_Click);
            // 
            // Index
            // 
            this.Index.Text = "STT";
            this.Index.Width = 40;
            // 
            // IdColumn
            // 
            this.IdColumn.Text = "Mã SV";
            this.IdColumn.Width = 71;
            // 
            // NameColumn
            // 
            this.NameColumn.Text = "Tên SV";
            this.NameColumn.Width = 187;
            // 
            // birthdayColumn
            // 
            this.birthdayColumn.Text = "Ngày sinh";
            this.birthdayColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.birthdayColumn.Width = 92;
            // 
            // fTimeColumn
            // 
            this.fTimeColumn.Text = "Điểm lần 1";
            this.fTimeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.fTimeColumn.Width = 81;
            // 
            // sTimeColumn
            // 
            this.sTimeColumn.Text = "Điểm lần 2";
            this.sTimeColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.sTimeColumn.Width = 76;
            // 
            // averageColumn
            // 
            this.averageColumn.Text = "Điểm TB";
            this.averageColumn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.averageColumn.Width = 74;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 517);
            this.Controls.Add(this.sListView);
            this.Controls.Add(this.searchBtn);
            this.Controls.Add(this.deleteBtn);
            this.Controls.Add(this.updateBtn);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.ISScore);
            this.Controls.Add(this.IFScore);
            this.Controls.Add(this.IDate);
            this.Controls.Add(this.IName);
            this.Controls.Add(this.IId);
            this.Controls.Add(this.sTime);
            this.Controls.Add(this.fTime);
            this.Controls.Add(this.sBirthDay);
            this.Controls.Add(this.sName);
            this.Controls.Add(this.sId);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label sId;
        private System.Windows.Forms.Label sName;
        private System.Windows.Forms.Label sBirthDay;
        private System.Windows.Forms.Label fTime;
        private System.Windows.Forms.Label sTime;
        private System.Windows.Forms.TextBox IId;
        private System.Windows.Forms.TextBox IName;
        private System.Windows.Forms.DateTimePicker IDate;
        private System.Windows.Forms.TextBox IFScore;
        private System.Windows.Forms.TextBox ISScore;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button updateBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button searchBtn;
        private ListView sListView;
        private ColumnHeader Index;
        private ColumnHeader IdColumn;
        private ColumnHeader NameColumn;
        private ColumnHeader birthdayColumn;
        private ColumnHeader fTimeColumn;
        private ColumnHeader sTimeColumn;
        private ColumnHeader averageColumn;
    }
}

