namespace Q1
{
	partial class Form1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.Nowbutton = new System.Windows.Forms.Button();
			this.Secondbutton = new System.Windows.Forms.Button();
			this.Timelabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// Nowbutton
			// 
			this.Nowbutton.Location = new System.Drawing.Point(115, 205);
			this.Nowbutton.Name = "Nowbutton";
			this.Nowbutton.Size = new System.Drawing.Size(75, 23);
			this.Nowbutton.TabIndex = 0;
			this.Nowbutton.Text = "First";
			this.Nowbutton.UseVisualStyleBackColor = true;
			this.Nowbutton.Click += new System.EventHandler(this.Nowbutton_Click);
			// 
			// Secondbutton
			// 
			this.Secondbutton.Location = new System.Drawing.Point(284, 205);
			this.Secondbutton.Name = "Secondbutton";
			this.Secondbutton.Size = new System.Drawing.Size(75, 23);
			this.Secondbutton.TabIndex = 0;
			this.Secondbutton.Text = "Second";
			this.Secondbutton.UseVisualStyleBackColor = true;
			this.Secondbutton.Click += new System.EventHandler(this.Secondbutton_Click);
			// 
			// Timelabel
			// 
			this.Timelabel.AutoSize = true;
			this.Timelabel.Font = new System.Drawing.Font("新細明體", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.Timelabel.Location = new System.Drawing.Point(25, 107);
			this.Timelabel.Name = "Timelabel";
			this.Timelabel.Size = new System.Drawing.Size(87, 29);
			this.Timelabel.TabIndex = 1;
			this.Timelabel.Text = "label1";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(473, 285);
			this.Controls.Add(this.Timelabel);
			this.Controls.Add(this.Secondbutton);
			this.Controls.Add(this.Nowbutton);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button Nowbutton;
		private System.Windows.Forms.Button Secondbutton;
		private System.Windows.Forms.Label Timelabel;
	}
}

