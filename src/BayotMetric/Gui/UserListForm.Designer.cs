/*
 * Created by SharpDevelop.
 * User: Dell
 * Date: 12/06/2019
 * Time: 4:19 PM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace BayotMetric.Gui
{
	partial class UserListForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		
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
		/// </summary>
		private void InitializeComponent()
		{
			this.listView1 = new System.Windows.Forms.ListView();
			this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
			this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
			this.buttonAddUser = new System.Windows.Forms.Button();
			this.buttonEditUser = new System.Windows.Forms.Button();
			this.buttonDeleteUser = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// listView1
			// 
			this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
									this.columnHeader1,
									this.columnHeader2});
			this.listView1.Location = new System.Drawing.Point(8, 8);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(216, 184);
			this.listView1.TabIndex = 0;
			this.listView1.UseCompatibleStateImageBehavior = false;
			this.listView1.View = System.Windows.Forms.View.Details;
			// 
			// columnHeader1
			// 
			this.columnHeader1.Text = "ID";
			// 
			// columnHeader2
			// 
			this.columnHeader2.Text = "Name";
			// 
			// buttonAddUser
			// 
			this.buttonAddUser.Location = new System.Drawing.Point(232, 16);
			this.buttonAddUser.Name = "buttonAddUser";
			this.buttonAddUser.Size = new System.Drawing.Size(75, 23);
			this.buttonAddUser.TabIndex = 1;
			this.buttonAddUser.Text = "Add User";
			this.buttonAddUser.UseVisualStyleBackColor = true;
			this.buttonAddUser.Click += new System.EventHandler(this.ButtonAddUserClick);
			// 
			// buttonEditUser
			// 
			this.buttonEditUser.Location = new System.Drawing.Point(232, 40);
			this.buttonEditUser.Name = "buttonEditUser";
			this.buttonEditUser.Size = new System.Drawing.Size(75, 23);
			this.buttonEditUser.TabIndex = 2;
			this.buttonEditUser.Text = "Edit User";
			this.buttonEditUser.UseVisualStyleBackColor = true;
			this.buttonEditUser.Click += new System.EventHandler(this.ButtonEditUserClick);
			// 
			// buttonDeleteUser
			// 
			this.buttonDeleteUser.Location = new System.Drawing.Point(232, 88);
			this.buttonDeleteUser.Name = "buttonDeleteUser";
			this.buttonDeleteUser.Size = new System.Drawing.Size(75, 23);
			this.buttonDeleteUser.TabIndex = 3;
			this.buttonDeleteUser.Text = "Delete User";
			this.buttonDeleteUser.UseVisualStyleBackColor = true;
			// 
			// UserListForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(454, 261);
			this.Controls.Add(this.buttonDeleteUser);
			this.Controls.Add(this.buttonEditUser);
			this.Controls.Add(this.buttonAddUser);
			this.Controls.Add(this.listView1);
			this.Name = "UserListForm";
			this.Text = "Users List";
			this.ResumeLayout(false);
		}
		private System.Windows.Forms.Button buttonDeleteUser;
		private System.Windows.Forms.Button buttonEditUser;
		private System.Windows.Forms.Button buttonAddUser;
		private System.Windows.Forms.ColumnHeader columnHeader2;
		private System.Windows.Forms.ColumnHeader columnHeader1;
		private System.Windows.Forms.ListView listView1;
	}
}
