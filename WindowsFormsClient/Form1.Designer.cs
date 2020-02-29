namespace WindowsFormsClient
{
	partial class Form1
	{
		private System.ComponentModel.IContainer components = null;

		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		private void InitializeComponent()
		{
			this.mainTextBox = new System.Windows.Forms.RichTextBox();
			this.arrays = new System.Windows.Forms.Button();
			this.average = new System.Windows.Forms.Button();
			this.multiplication = new System.Windows.Forms.Button();
			this.exit = new System.Windows.Forms.Button();
			this.sortingDescending = new System.Windows.Forms.Button();
			this.sortingAscending = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// mainTextBox
			// 
			this.mainTextBox.Location = new System.Drawing.Point(12, 12);
			this.mainTextBox.Name = "mainTextBox";
			this.mainTextBox.Size = new System.Drawing.Size(363, 195);
			this.mainTextBox.TabIndex = 0;
			this.mainTextBox.Text = "";
			// 
			// arrays
			// 
			this.arrays.Location = new System.Drawing.Point(12, 213);
			this.arrays.Name = "arrays";
			this.arrays.Size = new System.Drawing.Size(118, 37);
			this.arrays.TabIndex = 1;
			this.arrays.Text = "Arrays";
			this.arrays.UseVisualStyleBackColor = true;
			// 
			// average
			// 
			this.average.Location = new System.Drawing.Point(135, 213);
			this.average.Name = "average";
			this.average.Size = new System.Drawing.Size(118, 37);
			this.average.TabIndex = 2;
			this.average.Text = "Average";
			this.average.UseVisualStyleBackColor = true;
			// 
			// multiplication
			// 
			this.multiplication.Location = new System.Drawing.Point(258, 213);
			this.multiplication.Name = "multiplication";
			this.multiplication.Size = new System.Drawing.Size(117, 37);
			this.multiplication.TabIndex = 3;
			this.multiplication.Text = "Multiplication";
			this.multiplication.UseVisualStyleBackColor = true;
			// 
			// exit
			// 
			this.exit.Location = new System.Drawing.Point(258, 256);
			this.exit.Name = "exit";
			this.exit.Size = new System.Drawing.Size(117, 37);
			this.exit.TabIndex = 6;
			this.exit.Text = "Exit";
			this.exit.UseVisualStyleBackColor = true;
			// 
			// sortingDescending
			// 
			this.sortingDescending.Location = new System.Drawing.Point(135, 256);
			this.sortingDescending.Name = "sortingDescending";
			this.sortingDescending.Size = new System.Drawing.Size(118, 37);
			this.sortingDescending.TabIndex = 5;
			this.sortingDescending.Text = "Sorting (descending)";
			this.sortingDescending.UseVisualStyleBackColor = true;
			// 
			// sortingAscending
			// 
			this.sortingAscending.Location = new System.Drawing.Point(12, 256);
			this.sortingAscending.Name = "sortingAscending";
			this.sortingAscending.Size = new System.Drawing.Size(118, 37);
			this.sortingAscending.TabIndex = 4;
			this.sortingAscending.Text = "Sorting (ascending)";
			this.sortingAscending.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(387, 303);
			this.Controls.Add(this.exit);
			this.Controls.Add(this.sortingDescending);
			this.Controls.Add(this.sortingAscending);
			this.Controls.Add(this.multiplication);
			this.Controls.Add(this.average);
			this.Controls.Add(this.arrays);
			this.Controls.Add(this.mainTextBox);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.Name = "Form1";
			this.Text = "Web service testing";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.RichTextBox mainTextBox;
		private System.Windows.Forms.Button arrays;
		private System.Windows.Forms.Button average;
		private System.Windows.Forms.Button multiplication;
		private System.Windows.Forms.Button exit;
		private System.Windows.Forms.Button sortingDescending;
		private System.Windows.Forms.Button sortingAscending;
	}
}

