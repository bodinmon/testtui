/*
 * Created by SharpDevelop.
 * User: bodin
 * Date: 26/9/2560
 * Time: 14:16
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Diagnostics;


namespace Tui_drag_drop_file_test
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
			this.listBox1.DragDrop += new System.Windows.Forms.DragEventHandler(this.listBox1_DragDrop);
			this.listBox1.DragEnter += new System.Windows.Forms.DragEventHandler(this.listBox1_DragEnter);
		}
		
		private void listBox1_DragEnter(object sender, System.Windows.Forms.DragEventArgs e)
		{
			if(e.Data.GetDataPresent(DataFormats.FileDrop))
			e.Effect = DragDropEffects.All;
			else
			e.Effect = DragDropEffects.None;
		}
		
		private void listBox1_DragDrop(object sender, System.Windows.Forms.DragEventArgs e)
		{
			string[] s = (string[]) e.Data.GetData(DataFormats.FileDrop, false);
			int i;
			listBox1.Items.Clear();
			for(i = 0; i < s.Length; i++)
			listBox1.Items.Add(s[i]);
		}

		void Button2Click(object sender, EventArgs e)
		{
			
			string packpixels = "512.jar";
			//string path = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine) + ";c:\\";
			/* 
 * string javaenvironmentPath = Environment.GetEnvironmentVariable("JAVA_HOME");
			if (string.IsNullOrEmpty(javaenvironmentPath))
			{
				System.Windows.Forms.MessageBox.Show("Java not found");
				return;
			}
			else
			{
				System.Windows.Forms.MessageBox.Show(javaenvironmentPath);
				return;
			}
			*/
			
			
			if (radioButton1.Checked)
				{packpixels = "512.jar";}
					else
				{packpixels = "1024.jar";}			

			System.Diagnostics.ProcessStartInfo startInfo = new System.Diagnostics.ProcessStartInfo();			
			startInfo.FileName =  @"C:\ProgramData\Oracle\Java\javapath\java.exe";
			
			//listBox2.Items.Clear();
			
			int i; 
			
			for(i = 0; i < listBox1.Items.Count; i++) 
			{	
					startInfo.Arguments = @"-jar " + packpixels + @" """+ listBox1.Items[i] + @"""  """+ listBox1.Items[i] + @"""";
					Process.Start(startInfo);				
					//Log text							
					listBox2.Items.Add ("RUN: "+ startInfo.Arguments);
								
			}
			listBox2.Items.Add ("Total " + listBox1.Items.Count.ToString() + " folders packed with "+ packpixels);
			
		}
		

	}
}
