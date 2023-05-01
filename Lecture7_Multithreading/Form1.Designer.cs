namespace Lecture7_Multithreading
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
			this.btnSync = new System.Windows.Forms.Button();
			this.btnAsync = new System.Windows.Forms.Button();
			this.rtbDisplay = new System.Windows.Forms.RichTextBox();
			this.btnMultiThread = new System.Windows.Forms.Button();
			this.btnStopwatch = new System.Windows.Forms.Button();
			this.btnReturnValue = new System.Windows.Forms.Button();
			this.btnCallback = new System.Windows.Forms.Button();
			this.btnClear = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btnSync
			// 
			this.btnSync.Location = new System.Drawing.Point(106, 85);
			this.btnSync.Name = "btnSync";
			this.btnSync.Size = new System.Drawing.Size(134, 52);
			this.btnSync.TabIndex = 0;
			this.btnSync.Text = "Run (Sync)";
			this.btnSync.UseVisualStyleBackColor = true;
			this.btnSync.Click += new System.EventHandler(this.btnSync_Click);
			// 
			// btnAsync
			// 
			this.btnAsync.Location = new System.Drawing.Point(106, 170);
			this.btnAsync.Name = "btnAsync";
			this.btnAsync.Size = new System.Drawing.Size(134, 52);
			this.btnAsync.TabIndex = 1;
			this.btnAsync.Text = "Run (ASync)";
			this.btnAsync.UseVisualStyleBackColor = true;
			this.btnAsync.Click += new System.EventHandler(this.btnAsync_Click);
			// 
			// rtbDisplay
			// 
			this.rtbDisplay.Location = new System.Drawing.Point(261, 69);
			this.rtbDisplay.Name = "rtbDisplay";
			this.rtbDisplay.Size = new System.Drawing.Size(300, 323);
			this.rtbDisplay.TabIndex = 2;
			this.rtbDisplay.Text = "";
			// 
			// btnMultiThread
			// 
			this.btnMultiThread.Location = new System.Drawing.Point(106, 255);
			this.btnMultiThread.Name = "btnMultiThread";
			this.btnMultiThread.Size = new System.Drawing.Size(134, 44);
			this.btnMultiThread.TabIndex = 3;
			this.btnMultiThread.Text = "Run (Multiple)";
			this.btnMultiThread.UseVisualStyleBackColor = true;
			this.btnMultiThread.Click += new System.EventHandler(this.btnMultiThread_Click);
			// 
			// btnStopwatch
			// 
			this.btnStopwatch.Location = new System.Drawing.Point(106, 331);
			this.btnStopwatch.Name = "btnStopwatch";
			this.btnStopwatch.Size = new System.Drawing.Size(134, 47);
			this.btnStopwatch.TabIndex = 4;
			this.btnStopwatch.Text = "Stopwatch Example";
			this.btnStopwatch.UseVisualStyleBackColor = true;
			this.btnStopwatch.Click += new System.EventHandler(this.btnStopwatch_Click);
			// 
			// btnReturnValue
			// 
			this.btnReturnValue.Location = new System.Drawing.Point(590, 85);
			this.btnReturnValue.Name = "btnReturnValue";
			this.btnReturnValue.Size = new System.Drawing.Size(134, 52);
			this.btnReturnValue.TabIndex = 5;
			this.btnReturnValue.Text = "Return Value";
			this.btnReturnValue.UseVisualStyleBackColor = true;
			this.btnReturnValue.Click += new System.EventHandler(this.btnReturnValue_Click);
			// 
			// btnCallback
			// 
			this.btnCallback.Location = new System.Drawing.Point(590, 170);
			this.btnCallback.Name = "btnCallback";
			this.btnCallback.Size = new System.Drawing.Size(134, 52);
			this.btnCallback.TabIndex = 6;
			this.btnCallback.Text = "Callback";
			this.btnCallback.UseVisualStyleBackColor = true;
			this.btnCallback.Click += new System.EventHandler(this.btnCallback_Click);
			// 
			// btnClear
			// 
			this.btnClear.Location = new System.Drawing.Point(340, 409);
			this.btnClear.Name = "btnClear";
			this.btnClear.Size = new System.Drawing.Size(143, 23);
			this.btnClear.TabIndex = 7;
			this.btnClear.Text = "Clear";
			this.btnClear.UseVisualStyleBackColor = true;
			this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.btnClear);
			this.Controls.Add(this.btnCallback);
			this.Controls.Add(this.btnReturnValue);
			this.Controls.Add(this.btnStopwatch);
			this.Controls.Add(this.btnMultiThread);
			this.Controls.Add(this.rtbDisplay);
			this.Controls.Add(this.btnAsync);
			this.Controls.Add(this.btnSync);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button btnSync;
		private System.Windows.Forms.Button btnAsync;
		private System.Windows.Forms.RichTextBox rtbDisplay;
		private System.Windows.Forms.Button btnMultiThread;
		private System.Windows.Forms.Button btnStopwatch;
		private System.Windows.Forms.Button btnReturnValue;
		private System.Windows.Forms.Button btnCallback;
		private System.Windows.Forms.Button btnClear;
	}
}

