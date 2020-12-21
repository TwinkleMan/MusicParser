namespace MusicParser
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
      this.tb_username = new System.Windows.Forms.TextBox();
      this.bt_username = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // tb_username
      // 
      this.tb_username.Location = new System.Drawing.Point(206, 169);
      this.tb_username.Name = "tb_username";
      this.tb_username.Size = new System.Drawing.Size(332, 22);
      this.tb_username.TabIndex = 0;
      // 
      // bt_username
      // 
      this.bt_username.Location = new System.Drawing.Point(309, 210);
      this.bt_username.Name = "bt_username";
      this.bt_username.Size = new System.Drawing.Size(135, 29);
      this.bt_username.TabIndex = 1;
      this.bt_username.Text = "submit";
      this.bt_username.UseVisualStyleBackColor = true;
      this.bt_username.Click += new System.EventHandler(this.bt_username_Click);
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(800, 450);
      this.Controls.Add(this.bt_username);
      this.Controls.Add(this.tb_username);
      this.Name = "Form1";
      this.Text = "Form1";
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    private System.Windows.Forms.Button bt_username;
    private System.Windows.Forms.TextBox tb_username;

    #endregion
  }
}

