namespace Boomberman
{
	partial class FormGame
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
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGame));
			this.menuStrip1 = new System.Windows.Forms.MenuStrip();
			this.panelGame = new System.Windows.Forms.Panel();
			this.labelGame = new System.Windows.Forms.Label();
			this.menuStrip = new System.Windows.Forms.MenuStrip();
			this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.aboutAuthorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
			this.timerClearFire = new System.Windows.Forms.Timer(this.components);
			this.timerGameOver = new System.Windows.Forms.Timer(this.components);
			this.menuStrip.SuspendLayout();
			this.SuspendLayout();
			// 
			// menuStrip1
			// 
			this.menuStrip1.Location = new System.Drawing.Point(0, 24);
			this.menuStrip1.Name = "menuStrip1";
			this.menuStrip1.Size = new System.Drawing.Size(841, 24);
			this.menuStrip1.TabIndex = 3;
			// 
			// panelGame
			// 
			this.panelGame.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.panelGame.Location = new System.Drawing.Point(12, 83);
			this.panelGame.Name = "panelGame";
			this.panelGame.Size = new System.Drawing.Size(817, 402);
			this.panelGame.TabIndex = 1;
			// 
			// labelGame
			// 
			this.labelGame.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
			this.labelGame.Location = new System.Drawing.Point(12, 48);
			this.labelGame.Name = "labelGame";
			this.labelGame.Size = new System.Drawing.Size(761, 32);
			this.labelGame.TabIndex = 2;
			this.labelGame.Text = "asdasd";
			this.labelGame.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// menuStrip
			// 
			this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
			this.menuStrip.Location = new System.Drawing.Point(0, 0);
			this.menuStrip.Name = "menuStrip";
			this.menuStrip.Size = new System.Drawing.Size(841, 24);
			this.menuStrip.TabIndex = 4;
			this.menuStrip.Text = "menuStrip2";
			// 
			// fileToolStripMenuItem
			// 
			this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.exitToolStripMenuItem});
			this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
			this.fileToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
			this.fileToolStripMenuItem.Text = "File";
			// 
			// newGameToolStripMenuItem
			// 
			this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
			this.newGameToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.newGameToolStripMenuItem.Text = "NewGame";
			this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
			// 
			// exitToolStripMenuItem
			// 
			this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
			this.exitToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
			this.exitToolStripMenuItem.Text = "Exit";
			this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
			// 
			// helpToolStripMenuItem
			// 
			this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGameToolStripMenuItem,
            this.aboutAuthorToolStripMenuItem});
			this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
			this.helpToolStripMenuItem.Size = new System.Drawing.Size(40, 20);
			this.helpToolStripMenuItem.Text = "Help";
			// 
			// aboutGameToolStripMenuItem
			// 
			this.aboutGameToolStripMenuItem.Name = "aboutGameToolStripMenuItem";
			this.aboutGameToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.aboutGameToolStripMenuItem.Text = "About Game";
			this.aboutGameToolStripMenuItem.Click += new System.EventHandler(this.aboutGameToolStripMenuItem_Click);
			// 
			// aboutAuthorToolStripMenuItem
			// 
			this.aboutAuthorToolStripMenuItem.Name = "aboutAuthorToolStripMenuItem";
			this.aboutAuthorToolStripMenuItem.Size = new System.Drawing.Size(139, 22);
			this.aboutAuthorToolStripMenuItem.Text = "About Author";
			this.aboutAuthorToolStripMenuItem.Click += new System.EventHandler(this.aboutAuthorToolStripMenuItem_Click);
			// 
			// timerClearFire
			// 
			this.timerClearFire.Tick += new System.EventHandler(this.timerClearFire_Tick);
			// 
			// timerGameOver
			// 
			this.timerGameOver.Tick += new System.EventHandler(this.timerGameOver_Tick);
			// 
			// FormGame
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(841, 518);
			this.Controls.Add(this.labelGame);
			this.Controls.Add(this.panelGame);
			this.Controls.Add(this.menuStrip1);
			this.Controls.Add(this.menuStrip);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.MainMenuStrip = this.menuStrip1;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "FormGame";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ЦНТИ Прогресс!!! Найди скидку на семинар )))";
			this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.FormGame_KeyDown);
			this.menuStrip.ResumeLayout(false);
			this.menuStrip.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.MenuStrip menuStrip1;
		private System.Windows.Forms.Panel panelGame;
		private System.Windows.Forms.Label labelGame;
		private System.Windows.Forms.MenuStrip menuStrip;
		private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutGameToolStripMenuItem;
		private System.Windows.Forms.ToolStripMenuItem aboutAuthorToolStripMenuItem;
		private System.Windows.Forms.Timer timerClearFire;
		private System.Windows.Forms.Timer timerGameOver;

	}
}

