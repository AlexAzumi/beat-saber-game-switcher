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
      this.label1 = new System.Windows.Forms.Label();
      this.currentVersionL = new System.Windows.Forms.Label();
      this.switchGameBtn = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label1.Location = new System.Drawing.Point(12, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(134, 19);
      this.label1.TabIndex = 0;
      this.label1.Text = "Current version:";
      // 
      // currentVersionL
      // 
      this.currentVersionL.AutoSize = true;
      this.currentVersionL.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.currentVersionL.Location = new System.Drawing.Point(143, 9);
      this.currentVersionL.Name = "currentVersionL";
      this.currentVersionL.Size = new System.Drawing.Size(13, 18);
      this.currentVersionL.TabIndex = 1;
      this.currentVersionL.Text = "-";
      // 
      // switchGameBtn
      // 
      this.switchGameBtn.Location = new System.Drawing.Point(16, 42);
      this.switchGameBtn.Name = "switchGameBtn";
      this.switchGameBtn.Size = new System.Drawing.Size(300, 126);
      this.switchGameBtn.TabIndex = 2;
      this.switchGameBtn.Text = "-";
      this.switchGameBtn.UseVisualStyleBackColor = true;
      this.switchGameBtn.Click += new System.EventHandler(this.switchGameBtn_Click);
      // 
      // MainWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(328, 180);
      this.Controls.Add(this.switchGameBtn);
      this.Controls.Add(this.currentVersionL);
      this.Controls.Add(this.label1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.Name = "MainWindow";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "Beat Saber Game Switcher (BSGS)";
      this.Shown += new System.EventHandler(this.MainWindow_Shown);
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label currentVersionL;
    private System.Windows.Forms.Button switchGameBtn;
  }
}

