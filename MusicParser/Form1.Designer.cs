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
      this.bt_submit = new System.Windows.Forms.Button();
      this.progressBar = new System.Windows.Forms.ProgressBar();
      this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
      this.panel_FromYandex = new System.Windows.Forms.Panel();
      this.yandex_songList = new System.Windows.Forms.ListView();
      this.lbl_enterLogin1 = new System.Windows.Forms.Label();
      this.lbl_yandex1 = new System.Windows.Forms.Label();
      this.panel_ToYandex = new System.Windows.Forms.Panel();
      this.lbl_enterLogin2 = new System.Windows.Forms.Label();
      this.lbl_yandex2 = new System.Windows.Forms.Label();
      this.from_boxSelector = new System.Windows.Forms.ComboBox();
      this.lbl_from = new System.Windows.Forms.Label();
      this.lbl_to = new System.Windows.Forms.Label();
      this.to_boxSelector = new System.Windows.Forms.ComboBox();
      this.lbl_statusText = new System.Windows.Forms.Label();
      this.lbl_status = new System.Windows.Forms.Label();
      this.panel_FromYandex.SuspendLayout();
      this.panel_ToYandex.SuspendLayout();
      this.SuspendLayout();
      // 
      // tb_username
      // 
      this.tb_username.Location = new System.Drawing.Point(118, 95);
      this.tb_username.Name = "tb_username";
      this.tb_username.Size = new System.Drawing.Size(332, 22);
      this.tb_username.TabIndex = 0;
      this.tb_username.UseWaitCursor = true;
      // 
      // bt_submit
      // 
      this.bt_submit.Location = new System.Drawing.Point(532, 53);
      this.bt_submit.Name = "bt_submit";
      this.bt_submit.Size = new System.Drawing.Size(135, 29);
      this.bt_submit.TabIndex = 1;
      this.bt_submit.Text = "submit";
      this.bt_submit.UseVisualStyleBackColor = true;
      this.bt_submit.UseWaitCursor = true;
      this.bt_submit.Click += new System.EventHandler(this.bt_username_Click);
      // 
      // progressBar
      // 
      this.progressBar.Location = new System.Drawing.Point(436, 12);
      this.progressBar.Name = "progressBar";
      this.progressBar.Size = new System.Drawing.Size(331, 35);
      this.progressBar.TabIndex = 2;
      this.progressBar.UseWaitCursor = true;
      // 
      // panel_FromYandex
      // 
      this.panel_FromYandex.Controls.Add(this.yandex_songList);
      this.panel_FromYandex.Controls.Add(this.lbl_enterLogin1);
      this.panel_FromYandex.Controls.Add(this.lbl_yandex1);
      this.panel_FromYandex.Controls.Add(this.tb_username);
      this.panel_FromYandex.Location = new System.Drawing.Point(4, 120);
      this.panel_FromYandex.Name = "panel_FromYandex";
      this.panel_FromYandex.Size = new System.Drawing.Size(586, 576);
      this.panel_FromYandex.TabIndex = 3;
      this.panel_FromYandex.UseWaitCursor = true;
      // 
      // yandex_songList
      // 
      this.yandex_songList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.yandex_songList.Location = new System.Drawing.Point(9, 137);
      this.yandex_songList.Name = "yandex_songList";
      this.yandex_songList.Size = new System.Drawing.Size(561, 427);
      this.yandex_songList.TabIndex = 3;
      this.yandex_songList.UseCompatibleStateImageBehavior = false;
      this.yandex_songList.UseWaitCursor = true;
      this.yandex_songList.View = System.Windows.Forms.View.Details;
      // 
      // lbl_enterLogin1
      // 
      this.lbl_enterLogin1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.lbl_enterLogin1.Location = new System.Drawing.Point(118, 58);
      this.lbl_enterLogin1.Name = "lbl_enterLogin1";
      this.lbl_enterLogin1.Size = new System.Drawing.Size(213, 25);
      this.lbl_enterLogin1.TabIndex = 2;
      this.lbl_enterLogin1.Text = "Enter login";
      this.lbl_enterLogin1.UseWaitCursor = true;
      // 
      // lbl_yandex1
      // 
      this.lbl_yandex1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.lbl_yandex1.Location = new System.Drawing.Point(118, 10);
      this.lbl_yandex1.Name = "lbl_yandex1";
      this.lbl_yandex1.Size = new System.Drawing.Size(332, 48);
      this.lbl_yandex1.TabIndex = 1;
      this.lbl_yandex1.Text = "Yandex.music";
      this.lbl_yandex1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.lbl_yandex1.UseWaitCursor = true;
      // 
      // panel_ToYandex
      // 
      this.panel_ToYandex.Controls.Add(this.lbl_enterLogin2);
      this.panel_ToYandex.Controls.Add(this.lbl_yandex2);
      this.panel_ToYandex.Location = new System.Drawing.Point(612, 120);
      this.panel_ToYandex.Name = "panel_ToYandex";
      this.panel_ToYandex.Size = new System.Drawing.Size(586, 576);
      this.panel_ToYandex.TabIndex = 4;
      this.panel_ToYandex.UseWaitCursor = true;
      // 
      // lbl_enterLogin2
      // 
      this.lbl_enterLogin2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.lbl_enterLogin2.Location = new System.Drawing.Point(136, 58);
      this.lbl_enterLogin2.Name = "lbl_enterLogin2";
      this.lbl_enterLogin2.Size = new System.Drawing.Size(213, 25);
      this.lbl_enterLogin2.TabIndex = 2;
      this.lbl_enterLogin2.Text = "Enter login";
      this.lbl_enterLogin2.UseWaitCursor = true;
      // 
      // lbl_yandex2
      // 
      this.lbl_yandex2.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.lbl_yandex2.Location = new System.Drawing.Point(136, 10);
      this.lbl_yandex2.Name = "lbl_yandex2";
      this.lbl_yandex2.Size = new System.Drawing.Size(332, 48);
      this.lbl_yandex2.TabIndex = 1;
      this.lbl_yandex2.Text = "Yandex.music";
      this.lbl_yandex2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.lbl_yandex2.UseWaitCursor = true;
      // 
      // from_boxSelector
      // 
      this.from_boxSelector.FormattingEnabled = true;
      this.from_boxSelector.Items.AddRange(new object[] {"Yandex.Music", "Spotify", "Apple Music", "VK Music"});
      this.from_boxSelector.Location = new System.Drawing.Point(43, 53);
      this.from_boxSelector.Name = "from_boxSelector";
      this.from_boxSelector.Size = new System.Drawing.Size(394, 24);
      this.from_boxSelector.TabIndex = 5;
      this.from_boxSelector.UseWaitCursor = true;
      this.from_boxSelector.SelectedIndexChanged += new System.EventHandler(this.from_boxSelector_SelectedIndexChanged);
      // 
      // lbl_from
      // 
      this.lbl_from.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.lbl_from.Location = new System.Drawing.Point(70, 5);
      this.lbl_from.Name = "lbl_from";
      this.lbl_from.Size = new System.Drawing.Size(332, 45);
      this.lbl_from.TabIndex = 3;
      this.lbl_from.Text = "From:";
      this.lbl_from.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.lbl_from.UseWaitCursor = true;
      // 
      // lbl_to
      // 
      this.lbl_to.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.lbl_to.Location = new System.Drawing.Point(794, 5);
      this.lbl_to.Name = "lbl_to";
      this.lbl_to.Size = new System.Drawing.Size(332, 45);
      this.lbl_to.TabIndex = 6;
      this.lbl_to.Text = "To:";
      this.lbl_to.TextAlign = System.Drawing.ContentAlignment.TopCenter;
      this.lbl_to.UseWaitCursor = true;
      // 
      // to_boxSelector
      // 
      this.to_boxSelector.FormattingEnabled = true;
      this.to_boxSelector.Items.AddRange(new object[] {"Yandex.Music", "Spotify", "Apple Music", "VK Music"});
      this.to_boxSelector.Location = new System.Drawing.Point(766, 53);
      this.to_boxSelector.Name = "to_boxSelector";
      this.to_boxSelector.Size = new System.Drawing.Size(394, 24);
      this.to_boxSelector.TabIndex = 7;
      this.to_boxSelector.UseWaitCursor = true;
      // 
      // lbl_statusText
      // 
      this.lbl_statusText.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.lbl_statusText.Location = new System.Drawing.Point(515, 92);
      this.lbl_statusText.Name = "lbl_statusText";
      this.lbl_statusText.Size = new System.Drawing.Size(75, 25);
      this.lbl_statusText.TabIndex = 4;
      this.lbl_statusText.Text = "Status:";
      this.lbl_statusText.UseWaitCursor = true;
      // 
      // lbl_status
      // 
      this.lbl_status.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
      this.lbl_status.Location = new System.Drawing.Point(596, 92);
      this.lbl_status.Name = "lbl_status";
      this.lbl_status.Size = new System.Drawing.Size(564, 25);
      this.lbl_status.TabIndex = 8;
      this.lbl_status.UseWaitCursor = true;
      // 
      // Form1
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1199, 708);
      this.Controls.Add(this.lbl_status);
      this.Controls.Add(this.lbl_statusText);
      this.Controls.Add(this.to_boxSelector);
      this.Controls.Add(this.lbl_to);
      this.Controls.Add(this.lbl_from);
      this.Controls.Add(this.from_boxSelector);
      this.Controls.Add(this.panel_ToYandex);
      this.Controls.Add(this.panel_FromYandex);
      this.Controls.Add(this.progressBar);
      this.Controls.Add(this.bt_submit);
      this.Name = "Form1";
      this.Text = "Form1";
      this.UseWaitCursor = true;
      this.panel_FromYandex.ResumeLayout(false);
      this.panel_FromYandex.PerformLayout();
      this.panel_ToYandex.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private System.Windows.Forms.Label lbl_statusText;
    private System.Windows.Forms.Label lbl_status;

    private System.Windows.Forms.ListView yandex_songList;

    private System.Windows.Forms.ComboBox to_boxSelector;
    private System.Windows.Forms.Label lbl_to;

    private System.Windows.Forms.Label lbl_from;

    private System.Windows.Forms.ComboBox from_boxSelector;

    private System.Windows.Forms.Label lbl_enterLogin2;
    private System.Windows.Forms.Label lbl_yandex2;
    private System.Windows.Forms.Panel panel_ToYandex;

    private System.Windows.Forms.Label lbl_enterLogin1;

    private System.Windows.Forms.Label lbl_yandex1;
    private System.Windows.Forms.Panel panel_FromYandex;

    private System.ComponentModel.BackgroundWorker backgroundWorker1;

    private System.Windows.Forms.ProgressBar progressBar;

    private System.Windows.Forms.Button bt_submit;
    private System.Windows.Forms.TextBox tb_username;

    #endregion
  }
}

