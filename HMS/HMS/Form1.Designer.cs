namespace HMS
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
			this.label1 = new System.Windows.Forms.Label();
			this.adddoc = new System.Windows.Forms.Button();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.btnclose = new System.Windows.Forms.Button();
			this.btnsave = new System.Windows.Forms.Button();
			this.cbgender = new System.Windows.Forms.ComboBox();
			this.txtsalary = new System.Windows.Forms.TextBox();
			this.txtspecialist = new System.Windows.Forms.TextBox();
			this.txtcontact = new System.Windows.Forms.TextBox();
			this.txtemail = new System.Windows.Forms.TextBox();
			this.txtaddress = new System.Windows.Forms.TextBox();
			this.txtage = new System.Windows.Forms.TextBox();
			this.txtname = new System.Windows.Forms.TextBox();
			this.txtid = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.label13 = new System.Windows.Forms.Label();
			this.label14 = new System.Windows.Forms.Label();
			this.label15 = new System.Windows.Forms.Label();
			this.label16 = new System.Windows.Forms.Label();
			this.label17 = new System.Windows.Forms.Label();
			this.label18 = new System.Windows.Forms.Label();
			this.label19 = new System.Windows.Forms.Label();
			this.label20 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.BackColor = System.Drawing.Color.White;
			this.label1.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(36, 56);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(74, 26);
			this.label1.TabIndex = 0;
			this.label1.Text = "MENU";
			// 
			// adddoc
			// 
			this.adddoc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.adddoc.Location = new System.Drawing.Point(23, 112);
			this.adddoc.Name = "adddoc";
			this.adddoc.Size = new System.Drawing.Size(117, 38);
			this.adddoc.TabIndex = 1;
			this.adddoc.Text = "Add Doctor";
			this.adddoc.UseVisualStyleBackColor = true;
			this.adddoc.Click += new System.EventHandler(this.adddoc_Click);
			// 
			// pictureBox1
			// 
			this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
			this.pictureBox1.Location = new System.Drawing.Point(163, 24);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(666, 499);
			this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.pictureBox1.TabIndex = 2;
			this.pictureBox1.TabStop = false;
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.White;
			this.panel1.Controls.Add(this.btnclose);
			this.panel1.Controls.Add(this.btnsave);
			this.panel1.Controls.Add(this.cbgender);
			this.panel1.Controls.Add(this.txtsalary);
			this.panel1.Controls.Add(this.txtspecialist);
			this.panel1.Controls.Add(this.txtcontact);
			this.panel1.Controls.Add(this.txtemail);
			this.panel1.Controls.Add(this.txtaddress);
			this.panel1.Controls.Add(this.txtage);
			this.panel1.Controls.Add(this.txtname);
			this.panel1.Controls.Add(this.txtid);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Controls.Add(this.label12);
			this.panel1.Controls.Add(this.label13);
			this.panel1.Controls.Add(this.label14);
			this.panel1.Controls.Add(this.label15);
			this.panel1.Controls.Add(this.label16);
			this.panel1.Controls.Add(this.label17);
			this.panel1.Controls.Add(this.label18);
			this.panel1.Controls.Add(this.label19);
			this.panel1.Controls.Add(this.label20);
			this.panel1.Location = new System.Drawing.Point(163, 24);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(666, 499);
			this.panel1.TabIndex = 22;
			// 
			// btnclose
			// 
			this.btnclose.BackColor = System.Drawing.Color.White;
			this.btnclose.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnclose.Location = new System.Drawing.Point(321, 419);
			this.btnclose.Name = "btnclose";
			this.btnclose.Size = new System.Drawing.Size(75, 40);
			this.btnclose.TabIndex = 20;
			this.btnclose.Text = "Close";
			this.btnclose.UseVisualStyleBackColor = false;
			this.btnclose.Click += new System.EventHandler(this.btnclose_Click_1);
			// 
			// btnsave
			// 
			this.btnsave.BackColor = System.Drawing.Color.White;
			this.btnsave.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnsave.Location = new System.Drawing.Point(185, 419);
			this.btnsave.Name = "btnsave";
			this.btnsave.Size = new System.Drawing.Size(75, 40);
			this.btnsave.TabIndex = 19;
			this.btnsave.Text = "Save";
			this.btnsave.UseVisualStyleBackColor = false;
			this.btnsave.Click += new System.EventHandler(this.btnsave_Click_1);
			// 
			// cbgender
			// 
			this.cbgender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cbgender.FormattingEnabled = true;
			this.cbgender.Items.AddRange(new object[] {
            "Male",
            "Female",
            "Transgender"});
			this.cbgender.Location = new System.Drawing.Point(176, 192);
			this.cbgender.Name = "cbgender";
			this.cbgender.Size = new System.Drawing.Size(220, 28);
			this.cbgender.TabIndex = 18;
			// 
			// txtsalary
			// 
			this.txtsalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtsalary.Location = new System.Drawing.Point(176, 375);
			this.txtsalary.Name = "txtsalary";
			this.txtsalary.Size = new System.Drawing.Size(220, 26);
			this.txtsalary.TabIndex = 17;
			// 
			// txtspecialist
			// 
			this.txtspecialist.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtspecialist.Location = new System.Drawing.Point(176, 339);
			this.txtspecialist.Name = "txtspecialist";
			this.txtspecialist.Size = new System.Drawing.Size(220, 26);
			this.txtspecialist.TabIndex = 16;
			// 
			// txtcontact
			// 
			this.txtcontact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtcontact.Location = new System.Drawing.Point(176, 303);
			this.txtcontact.Name = "txtcontact";
			this.txtcontact.Size = new System.Drawing.Size(220, 26);
			this.txtcontact.TabIndex = 15;
			// 
			// txtemail
			// 
			this.txtemail.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtemail.Location = new System.Drawing.Point(176, 268);
			this.txtemail.Name = "txtemail";
			this.txtemail.Size = new System.Drawing.Size(220, 26);
			this.txtemail.TabIndex = 14;
			// 
			// txtaddress
			// 
			this.txtaddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtaddress.Location = new System.Drawing.Point(176, 228);
			this.txtaddress.Name = "txtaddress";
			this.txtaddress.Size = new System.Drawing.Size(220, 26);
			this.txtaddress.TabIndex = 13;
			// 
			// txtage
			// 
			this.txtage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtage.Location = new System.Drawing.Point(176, 153);
			this.txtage.Name = "txtage";
			this.txtage.Size = new System.Drawing.Size(220, 26);
			this.txtage.TabIndex = 12;
			// 
			// txtname
			// 
			this.txtname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtname.Location = new System.Drawing.Point(176, 114);
			this.txtname.Name = "txtname";
			this.txtname.Size = new System.Drawing.Size(220, 26);
			this.txtname.TabIndex = 11;
			// 
			// txtid
			// 
			this.txtid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txtid.Location = new System.Drawing.Point(176, 74);
			this.txtid.Name = "txtid";
			this.txtid.ReadOnly = true;
			this.txtid.Size = new System.Drawing.Size(220, 26);
			this.txtid.TabIndex = 10;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Algerian", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(212, 14);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(199, 26);
			this.label2.TabIndex = 9;
			this.label2.Text = "Doctor Details";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(39, 373);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(53, 20);
			this.label12.TabIndex = 8;
			this.label12.Text = "Salary";
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label13.Location = new System.Drawing.Point(34, 339);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(93, 20);
			this.label13.TabIndex = 7;
			this.label13.Text = "Specialist in";
			// 
			// label14
			// 
			this.label14.AutoSize = true;
			this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label14.Location = new System.Drawing.Point(34, 301);
			this.label14.Name = "label14";
			this.label14.Size = new System.Drawing.Size(65, 20);
			this.label14.TabIndex = 6;
			this.label14.Text = "Contact";
			// 
			// label15
			// 
			this.label15.AutoSize = true;
			this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label15.Location = new System.Drawing.Point(43, 266);
			this.label15.Name = "label15";
			this.label15.Size = new System.Drawing.Size(48, 20);
			this.label15.TabIndex = 5;
			this.label15.Text = "Email";
			// 
			// label16
			// 
			this.label16.AutoSize = true;
			this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label16.Location = new System.Drawing.Point(39, 228);
			this.label16.Name = "label16";
			this.label16.Size = new System.Drawing.Size(68, 20);
			this.label16.TabIndex = 4;
			this.label16.Text = "Address";
			// 
			// label17
			// 
			this.label17.AutoSize = true;
			this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label17.Location = new System.Drawing.Point(39, 190);
			this.label17.Name = "label17";
			this.label17.Size = new System.Drawing.Size(63, 20);
			this.label17.TabIndex = 3;
			this.label17.Text = "Gender";
			// 
			// label18
			// 
			this.label18.AutoSize = true;
			this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label18.Location = new System.Drawing.Point(39, 153);
			this.label18.Name = "label18";
			this.label18.Size = new System.Drawing.Size(38, 20);
			this.label18.TabIndex = 2;
			this.label18.Text = "Age";
			// 
			// label19
			// 
			this.label19.AutoSize = true;
			this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label19.Location = new System.Drawing.Point(34, 114);
			this.label19.Name = "label19";
			this.label19.Size = new System.Drawing.Size(103, 20);
			this.label19.TabIndex = 1;
			this.label19.Text = "Doctor Name";
			// 
			// label20
			// 
			this.label20.AutoSize = true;
			this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label20.Location = new System.Drawing.Point(46, 74);
			this.label20.Name = "label20";
			this.label20.Size = new System.Drawing.Size(23, 20);
			this.label20.TabIndex = 0;
			this.label20.Text = "Id";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(883, 546);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.pictureBox1);
			this.Controls.Add(this.adddoc);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button adddoc;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btnclose;
		private System.Windows.Forms.Button btnsave;
		private System.Windows.Forms.ComboBox cbgender;
		private System.Windows.Forms.TextBox txtsalary;
		private System.Windows.Forms.TextBox txtspecialist;
		private System.Windows.Forms.TextBox txtcontact;
		private System.Windows.Forms.TextBox txtemail;
		private System.Windows.Forms.TextBox txtaddress;
		private System.Windows.Forms.TextBox txtage;
		private System.Windows.Forms.TextBox txtname;
		private System.Windows.Forms.TextBox txtid;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Label label12;
		private System.Windows.Forms.Label label13;
		private System.Windows.Forms.Label label14;
		private System.Windows.Forms.Label label15;
		private System.Windows.Forms.Label label16;
		private System.Windows.Forms.Label label17;
		private System.Windows.Forms.Label label18;
		private System.Windows.Forms.Label label19;
		private System.Windows.Forms.Label label20;
	}
}

