/*
 * Created by SharpDevelop.
 * User: bodin
 * Date: 26/9/2560
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace Tui_drag_drop_file_test
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Button button2;
		private System.Windows.Forms.RadioButton radioButton1;
		private System.Windows.Forms.RadioButton radioButton2;		
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.ListBox listBox2;
		private System.Windows.Forms.Label label1;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		
		private void InitializeComponent()
		{
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.button2 = new System.Windows.Forms.Button();
			this.radioButton1 = new System.Windows.Forms.RadioButton();
			this.radioButton2 = new System.Windows.Forms.RadioButton();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.listBox2 = new System.Windows.Forms.ListBox();
			this.label1 = new System.Windows.Forms.Label();
			this.groupBox1.SuspendLayout();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.AllowDrop = true;
			this.listBox1.FormattingEnabled = true;
			this.listBox1.Location = new System.Drawing.Point(12, 36);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(541, 108);
			this.listBox1.TabIndex = 0;
			// 
			// button2
			// 
			this.button2.Location = new System.Drawing.Point(197, 159);
			this.button2.Name = "button2";
			this.button2.Size = new System.Drawing.Size(134, 54);
			this.button2.TabIndex = 2;
			this.button2.Text = "Pack it!";
			this.button2.UseVisualStyleBackColor = true;
			this.button2.Click += new System.EventHandler(this.Button2Click);
			// 
			// radioButton1
			// 
			this.radioButton1.Checked = true;
			this.radioButton1.Location = new System.Drawing.Point(12, 159);
			this.radioButton1.Name = "radioButton1";
			this.radioButton1.Size = new System.Drawing.Size(104, 24);
			this.radioButton1.TabIndex = 4;
			this.radioButton1.TabStop = true;
			this.radioButton1.Text = "512 pixels";
			this.radioButton1.UseVisualStyleBackColor = true;
			// 
			// radioButton2
			// 
			this.radioButton2.Location = new System.Drawing.Point(12, 189);
			this.radioButton2.Name = "radioButton2";
			this.radioButton2.Size = new System.Drawing.Size(104, 24);
			this.radioButton2.TabIndex = 5;
			this.radioButton2.Text = "1024 pixels";
			this.radioButton2.UseVisualStyleBackColor = true;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.listBox2);
			this.groupBox1.Location = new System.Drawing.Point(12, 230);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(541, 176);
			this.groupBox1.TabIndex = 6;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Status";
			// 
			// listBox2
			// 
			this.listBox2.BackColor = System.Drawing.SystemColors.Control;
			this.listBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
			this.listBox2.FormattingEnabled = true;
			this.listBox2.Items.AddRange(new object[] {
			"I\'m at your service"});
			this.listBox2.Location = new System.Drawing.Point(6, 19);
			this.listBox2.Name = "listBox2";
			this.listBox2.Size = new System.Drawing.Size(529, 143);
			this.listBox2.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(12, 10);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 23);
			this.label1.TabIndex = 7;
			this.label1.Text = "Drag/Drop folder here";
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(566, 416);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.radioButton2);
			this.Controls.Add(this.radioButton1);
			this.Controls.Add(this.button2);
			this.Controls.Add(this.listBox1);
			this.Name = "MainForm";
			this.Text = "PNG packer GUI";
			this.groupBox1.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}