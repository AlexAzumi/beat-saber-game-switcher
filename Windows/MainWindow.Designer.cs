namespace BeatSaberGameSwitcher
{
  partial class MainWindow
  {
    /// <summary>
    /// Variable del diseñador necesaria.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Limpiar los recursos que se estén usando.
    /// </summary>
    /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Código generado por el Diseñador de Windows Forms

    /// <summary>
    /// Método necesario para admitir el Diseñador. No se puede modificar
    /// el contenido de este método con el editor de código.
    /// </summary>
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.switchGameBtn = new System.Windows.Forms.Button();
      this.mainStrip = new System.Windows.Forms.StatusStrip();
      this.menuStrip1 = new System.Windows.Forms.MenuStrip();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changeGamePathsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.aboutThisProgramToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
      this.currentVersionL = new System.Windows.Forms.ToolStripStatusLabel();
      this.mainStrip.SuspendLayout();
      this.menuStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // switchGameBtn
      // 
      this.switchGameBtn.Location = new System.Drawing.Point(16, 27);
      this.switchGameBtn.Name = "switchGameBtn";
      this.switchGameBtn.Size = new System.Drawing.Size(300, 126);
      this.switchGameBtn.TabIndex = 2;
      this.switchGameBtn.Text = "-";
      this.switchGameBtn.UseVisualStyleBackColor = true;
      this.switchGameBtn.Click += new System.EventHandler(this.switchGameBtn_Click);
      // 
      // mainStrip
      // 
      this.mainStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.currentVersionL});
      this.mainStrip.Location = new System.Drawing.Point(0, 162);
      this.mainStrip.Name = "mainStrip";
      this.mainStrip.Size = new System.Drawing.Size(328, 22);
      this.mainStrip.TabIndex = 3;
      this.mainStrip.Text = "XDDDDDDDDDD";
      // 
      // menuStrip1
      // 
      this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.menuStrip1.Location = new System.Drawing.Point(0, 0);
      this.menuStrip1.Name = "menuStrip1";
      this.menuStrip1.Size = new System.Drawing.Size(328, 24);
      this.menuStrip1.TabIndex = 4;
      this.menuStrip1.Text = "menuStrip1";
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeGamePathsToolStripMenuItem});
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.optionsToolStripMenuItem.Text = "Options";
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutThisProgramToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "Help";
      // 
      // changeGamePathsToolStripMenuItem
      // 
      this.changeGamePathsToolStripMenuItem.Name = "changeGamePathsToolStripMenuItem";
      this.changeGamePathsToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.changeGamePathsToolStripMenuItem.Text = "Change game paths";
      this.changeGamePathsToolStripMenuItem.Click += new System.EventHandler(this.changeGamePathsToolStripMenuItem_Click);
      // 
      // aboutThisProgramToolStripMenuItem
      // 
      this.aboutThisProgramToolStripMenuItem.Name = "aboutThisProgramToolStripMenuItem";
      this.aboutThisProgramToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
      this.aboutThisProgramToolStripMenuItem.Text = "About this program";
      this.aboutThisProgramToolStripMenuItem.Click += new System.EventHandler(this.aboutThisProgramToolStripMenuItem_Click);
      // 
      // toolStripStatusLabel1
      // 
      this.toolStripStatusLabel1.Font = new System.Drawing.Font("Arial Narrow", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
      this.toolStripStatusLabel1.Size = new System.Drawing.Size(52, 17);
      this.toolStripStatusLabel1.Text = "Version:";
      // 
      // currentVersionL
      // 
      this.currentVersionL.Name = "currentVersionL";
      this.currentVersionL.Size = new System.Drawing.Size(12, 17);
      this.currentVersionL.Text = "-";
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(328, 184);
      this.Controls.Add(this.mainStrip);
      this.Controls.Add(this.menuStrip1);
      this.Controls.Add(this.switchGameBtn);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.menuStrip1;
      this.MaximizeBox = false;
      this.Name = "MainWindow";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Beat Saber Game Switcher (BSGS)";
      this.Shown += new System.EventHandler(this.MainWindow_Shown);
      this.mainStrip.ResumeLayout(false);
      this.mainStrip.PerformLayout();
      this.menuStrip1.ResumeLayout(false);
      this.menuStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button switchGameBtn;
    private System.Windows.Forms.StatusStrip mainStrip;
    private System.Windows.Forms.MenuStrip menuStrip1;
    private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem changeGamePathsToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
    private System.Windows.Forms.ToolStripMenuItem aboutThisProgramToolStripMenuItem;
    private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
    private System.Windows.Forms.ToolStripStatusLabel currentVersionL;
  }
}

