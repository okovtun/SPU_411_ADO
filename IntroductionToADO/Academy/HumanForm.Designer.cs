namespace Academy
{
	partial class HumanForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.labelID = new System.Windows.Forms.Label();
			this.labelFirstName = new System.Windows.Forms.Label();
			this.labelMiddleName = new System.Windows.Forms.Label();
			this.labelBirthDate = new System.Windows.Forms.Label();
			this.rtbLastName = new System.Windows.Forms.RichTextBox();
			this.rtbFirstName = new System.Windows.Forms.RichTextBox();
			this.rtbMiddleName = new System.Windows.Forms.RichTextBox();
			this.dtpBirthDate = new System.Windows.Forms.DateTimePicker();
			this.pictureBoxPhoto = new System.Windows.Forms.PictureBox();
			this.buttonPhoto = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.label1.Location = new System.Drawing.Point(75, 47);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(110, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Фамилия:";
			// 
			// labelID
			// 
			this.labelID.AutoSize = true;
			this.labelID.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelID.Location = new System.Drawing.Point(147, 13);
			this.labelID.Name = "labelID";
			this.labelID.Size = new System.Drawing.Size(38, 25);
			this.labelID.TabIndex = 1;
			this.labelID.Text = "ID:";
			// 
			// labelFirstName
			// 
			this.labelFirstName.AutoSize = true;
			this.labelFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelFirstName.Location = new System.Drawing.Point(126, 82);
			this.labelFirstName.Name = "labelFirstName";
			this.labelFirstName.Size = new System.Drawing.Size(59, 25);
			this.labelFirstName.TabIndex = 2;
			this.labelFirstName.Text = "Имя:";
			// 
			// labelMiddleName
			// 
			this.labelMiddleName.AutoSize = true;
			this.labelMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelMiddleName.Location = new System.Drawing.Point(74, 120);
			this.labelMiddleName.Name = "labelMiddleName";
			this.labelMiddleName.Size = new System.Drawing.Size(111, 25);
			this.labelMiddleName.TabIndex = 3;
			this.labelMiddleName.Text = "Отчество:";
			// 
			// labelBirthDate
			// 
			this.labelBirthDate.AutoSize = true;
			this.labelBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelBirthDate.Location = new System.Drawing.Point(13, 155);
			this.labelBirthDate.Name = "labelBirthDate";
			this.labelBirthDate.Size = new System.Drawing.Size(172, 25);
			this.labelBirthDate.TabIndex = 4;
			this.labelBirthDate.Text = "Дата рождения:";
			// 
			// rtbLastName
			// 
			this.rtbLastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbLastName.Location = new System.Drawing.Point(191, 47);
			this.rtbLastName.Multiline = false;
			this.rtbLastName.Name = "rtbLastName";
			this.rtbLastName.Size = new System.Drawing.Size(223, 25);
			this.rtbLastName.TabIndex = 5;
			this.rtbLastName.Text = "";
			// 
			// rtbFirstName
			// 
			this.rtbFirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbFirstName.Location = new System.Drawing.Point(191, 82);
			this.rtbFirstName.Multiline = false;
			this.rtbFirstName.Name = "rtbFirstName";
			this.rtbFirstName.Size = new System.Drawing.Size(223, 25);
			this.rtbFirstName.TabIndex = 6;
			this.rtbFirstName.Text = "";
			// 
			// rtbMiddleName
			// 
			this.rtbMiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.rtbMiddleName.Location = new System.Drawing.Point(191, 120);
			this.rtbMiddleName.Multiline = false;
			this.rtbMiddleName.Name = "rtbMiddleName";
			this.rtbMiddleName.Size = new System.Drawing.Size(223, 25);
			this.rtbMiddleName.TabIndex = 7;
			this.rtbMiddleName.Text = "";
			// 
			// dtpBirthDate
			// 
			this.dtpBirthDate.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpBirthDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.dtpBirthDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtpBirthDate.Location = new System.Drawing.Point(191, 155);
			this.dtpBirthDate.Name = "dtpBirthDate";
			this.dtpBirthDate.Size = new System.Drawing.Size(223, 31);
			this.dtpBirthDate.TabIndex = 8;
			// 
			// pictureBoxPhoto
			// 
			this.pictureBoxPhoto.Location = new System.Drawing.Point(445, 13);
			this.pictureBoxPhoto.Name = "pictureBoxPhoto";
			this.pictureBoxPhoto.Size = new System.Drawing.Size(168, 232);
			this.pictureBoxPhoto.TabIndex = 9;
			this.pictureBoxPhoto.TabStop = false;
			// 
			// buttonPhoto
			// 
			this.buttonPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.buttonPhoto.Location = new System.Drawing.Point(445, 251);
			this.buttonPhoto.Name = "buttonPhoto";
			this.buttonPhoto.Size = new System.Drawing.Size(168, 45);
			this.buttonPhoto.TabIndex = 10;
			this.buttonPhoto.Text = "Обзор";
			this.buttonPhoto.UseVisualStyleBackColor = true;
			// 
			// HumanForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(639, 310);
			this.Controls.Add(this.buttonPhoto);
			this.Controls.Add(this.pictureBoxPhoto);
			this.Controls.Add(this.dtpBirthDate);
			this.Controls.Add(this.rtbMiddleName);
			this.Controls.Add(this.rtbFirstName);
			this.Controls.Add(this.rtbLastName);
			this.Controls.Add(this.labelBirthDate);
			this.Controls.Add(this.labelMiddleName);
			this.Controls.Add(this.labelFirstName);
			this.Controls.Add(this.labelID);
			this.Controls.Add(this.label1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Name = "HumanForm";
			this.Text = "Human";
			((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhoto)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label labelID;
		private System.Windows.Forms.Label labelFirstName;
		private System.Windows.Forms.Label labelMiddleName;
		protected System.Windows.Forms.Label labelBirthDate;
		protected System.Windows.Forms.PictureBox pictureBoxPhoto;
		protected System.Windows.Forms.Button buttonPhoto;
		protected System.Windows.Forms.RichTextBox rtbLastName;
		protected System.Windows.Forms.RichTextBox rtbFirstName;
		protected System.Windows.Forms.RichTextBox rtbMiddleName;
		protected System.Windows.Forms.DateTimePicker dtpBirthDate;
	}
}