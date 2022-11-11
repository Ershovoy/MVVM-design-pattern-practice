namespace EventSystemPractice
{
	partial class EventForm
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.FullNameLabel = new System.Windows.Forms.Label();
			this.FullNameTextBox = new System.Windows.Forms.TextBox();
			this.PhoneNumberLabel = new System.Windows.Forms.Label();
			this.PhoneNumberTextBox = new System.Windows.Forms.TextBox();
			this.AddressLabel = new System.Windows.Forms.Label();
			this.AddressTextBox = new System.Windows.Forms.TextBox();
			this.CloseButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// FullNameLabel
			// 
			this.FullNameLabel.AutoSize = true;
			this.FullNameLabel.Location = new System.Drawing.Point(12, 24);
			this.FullNameLabel.Name = "FullNameLabel";
			this.FullNameLabel.Size = new System.Drawing.Size(64, 15);
			this.FullNameLabel.TabIndex = 0;
			this.FullNameLabel.Text = "Full Name:";
			// 
			// FullNameTextBox
			// 
			this.FullNameTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.FullNameTextBox.Location = new System.Drawing.Point(12, 42);
			this.FullNameTextBox.Name = "FullNameTextBox";
			this.FullNameTextBox.Size = new System.Drawing.Size(200, 23);
			this.FullNameTextBox.TabIndex = 1;
			// 
			// PhoneNumberLabel
			// 
			this.PhoneNumberLabel.AutoSize = true;
			this.PhoneNumberLabel.Location = new System.Drawing.Point(12, 83);
			this.PhoneNumberLabel.Name = "PhoneNumberLabel";
			this.PhoneNumberLabel.Size = new System.Drawing.Size(91, 15);
			this.PhoneNumberLabel.TabIndex = 2;
			this.PhoneNumberLabel.Text = "Phone Number:";
			// 
			// PhoneNumberTextBox
			// 
			this.PhoneNumberTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.PhoneNumberTextBox.Location = new System.Drawing.Point(12, 101);
			this.PhoneNumberTextBox.Name = "PhoneNumberTextBox";
			this.PhoneNumberTextBox.Size = new System.Drawing.Size(200, 23);
			this.PhoneNumberTextBox.TabIndex = 3;
			// 
			// AddressLabel
			// 
			this.AddressLabel.AutoSize = true;
			this.AddressLabel.Location = new System.Drawing.Point(12, 142);
			this.AddressLabel.Name = "AddressLabel";
			this.AddressLabel.Size = new System.Drawing.Size(49, 15);
			this.AddressLabel.TabIndex = 4;
			this.AddressLabel.Text = "Address";
			// 
			// AddressTextBox
			// 
			this.AddressTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.AddressTextBox.Location = new System.Drawing.Point(12, 160);
			this.AddressTextBox.Name = "AddressTextBox";
			this.AddressTextBox.Size = new System.Drawing.Size(200, 23);
			this.AddressTextBox.TabIndex = 5;
			// 
			// CloseButton
			// 
			this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CloseButton.Location = new System.Drawing.Point(137, 246);
			this.CloseButton.Name = "CloseButton";
			this.CloseButton.Size = new System.Drawing.Size(75, 23);
			this.CloseButton.TabIndex = 6;
			this.CloseButton.Text = "Close";
			this.CloseButton.UseVisualStyleBackColor = true;
			// 
			// EventForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(224, 281);
			this.Controls.Add(this.CloseButton);
			this.Controls.Add(this.AddressTextBox);
			this.Controls.Add(this.AddressLabel);
			this.Controls.Add(this.PhoneNumberTextBox);
			this.Controls.Add(this.PhoneNumberLabel);
			this.Controls.Add(this.FullNameTextBox);
			this.Controls.Add(this.FullNameLabel);
			this.MinimumSize = new System.Drawing.Size(240, 320);
			this.Name = "EventForm";
			this.ShowIcon = false;
			this.Text = "Main Form";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Label FullNameLabel;
		private TextBox FullNameTextBox;
		private Label PhoneNumberLabel;
		private TextBox PhoneNumberTextBox;
		private Label AddressLabel;
		private TextBox AddressTextBox;
		private Button CloseButton;
	}
}