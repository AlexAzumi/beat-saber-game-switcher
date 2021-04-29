namespace BeatSaberGameSwitcher
{
  partial class SetupWindow
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
      this.groupBox1 = new System.Windows.Forms.GroupBox();
      this.vanillaPathTB = new System.Windows.Forms.TextBox();
      this.moddedPathTB = new System.Windows.Forms.TextBox();
      this.vanillaPathL = new System.Windows.Forms.Label();
      this.moddedPathL = new System.Windows.Forms.Label();
      this.vanillaPathBtn = new System.Windows.Forms.Button();
      this.moddedPathBtn = new System.Windows.Forms.Button();
      this.saveBtn = new System.Windows.Forms.Button();
      this.groupBox1.SuspendLayout();
      this.SuspendLayout();
      // 
      // groupBox1
      // 
      this.groupBox1.Controls.Add(this.moddedPathBtn);
      this.groupBox1.Controls.Add(this.vanillaPathBtn);
      this.groupBox1.Controls.Add(this.moddedPathL);
      this.groupBox1.Controls.Add(this.vanillaPathL);
      this.groupBox1.Controls.Add(this.moddedPathTB);
      this.groupBox1.Controls.Add(this.vanillaPathTB);
      this.groupBox1.Location = new System.Drawing.Point(12, 12);
      this.groupBox1.Name = "groupBox1";
      this.groupBox1.Size = new System.Drawing.Size(349, 120);
      this.groupBox1.TabIndex = 0;
      this.groupBox1.TabStop = false;
      this.groupBox1.Text = "Beat Saber paths";
      // 
      // vanillaPathTB
      // 
      this.vanillaPathTB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vanillaPathTB.Location = new System.Drawing.Point(6, 36);
      this.vanillaPathTB.Name = "vanillaPathTB";
      this.vanillaPathTB.ReadOnly = true;
      this.vanillaPathTB.Size = new System.Drawing.Size(231, 26);
      this.vanillaPathTB.TabIndex = 0;
      // 
      // moddedPathTB
      // 
      this.moddedPathTB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.moddedPathTB.Location = new System.Drawing.Point(6, 85);
      this.moddedPathTB.Name = "moddedPathTB";
      this.moddedPathTB.ReadOnly = true;
      this.moddedPathTB.Size = new System.Drawing.Size(231, 26);
      this.moddedPathTB.TabIndex = 1;
      // 
      // vanillaPathL
      // 
      this.vanillaPathL.AutoSize = true;
      this.vanillaPathL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vanillaPathL.Location = new System.Drawing.Point(6, 16);
      this.vanillaPathL.Name = "vanillaPathL";
      this.vanillaPathL.Size = new System.Drawing.Size(167, 17);
      this.vanillaPathL.TabIndex = 2;
      this.vanillaPathL.Text = "Beat Saber path (vanilla)";
      // 
      // moddedPathL
      // 
      this.moddedPathL.AutoSize = true;
      this.moddedPathL.Font = new System.Drawing.Font("Arial", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.moddedPathL.Location = new System.Drawing.Point(6, 65);
      this.moddedPathL.Name = "moddedPathL";
      this.moddedPathL.Size = new System.Drawing.Size(180, 17);
      this.moddedPathL.TabIndex = 3;
      this.moddedPathL.Text = "Beat Saber path (modded)";
      // 
      // vanillaPathBtn
      // 
      this.vanillaPathBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.vanillaPathBtn.Location = new System.Drawing.Point(243, 36);
      this.vanillaPathBtn.Name = "vanillaPathBtn";
      this.vanillaPathBtn.Size = new System.Drawing.Size(100, 26);
      this.vanillaPathBtn.TabIndex = 4;
      this.vanillaPathBtn.Text = "Search";
      this.vanillaPathBtn.UseVisualStyleBackColor = true;
      this.vanillaPathBtn.Click += new System.EventHandler(this.vanillaPathBtn_Click);
      // 
      // moddedPathBtn
      // 
      this.moddedPathBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.moddedPathBtn.Location = new System.Drawing.Point(243, 85);
      this.moddedPathBtn.Name = "moddedPathBtn";
      this.moddedPathBtn.Size = new System.Drawing.Size(100, 26);
      this.moddedPathBtn.TabIndex = 5;
      this.moddedPathBtn.Text = "Search";
      this.moddedPathBtn.UseVisualStyleBackColor = true;
      this.moddedPathBtn.Click += new System.EventHandler(this.moddedPathBtn_Click);
      // 
      // saveBtn
      // 
      this.saveBtn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.saveBtn.Location = new System.Drawing.Point(255, 138);
      this.saveBtn.Name = "saveBtn";
      this.saveBtn.Size = new System.Drawing.Size(100, 26);
      this.saveBtn.TabIndex = 6;
      this.saveBtn.Text = "Save";
      this.saveBtn.UseVisualStyleBackColor = true;
      this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
      // 
      // SetupWindow
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(373, 174);
      this.Controls.Add(this.saveBtn);
      this.Controls.Add(this.groupBox1);
      this.MaximizeBox = false;
      this.Name = "SetupWindow";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "BSGS | Set up";
      this.groupBox1.ResumeLayout(false);
      this.groupBox1.PerformLayout();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.GroupBox groupBox1;
    private System.Windows.Forms.TextBox moddedPathTB;
    private System.Windows.Forms.TextBox vanillaPathTB;
    private System.Windows.Forms.Label moddedPathL;
    private System.Windows.Forms.Label vanillaPathL;
    private System.Windows.Forms.Button moddedPathBtn;
    private System.Windows.Forms.Button vanillaPathBtn;
    private System.Windows.Forms.Button saveBtn;
  }
}