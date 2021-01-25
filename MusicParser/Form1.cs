using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MusicParser
{
  public partial class Form1 : Form
  {
    public Form1()
    {
      InitializeComponent();
    }

    private void bt_username_Click(object sender, EventArgs e)
    {
      //get username from textbox
      YandexEngine yandexEngine = new YandexEngine();
      lbl_status.Text = "Engine created";
      //yandexEngine = YandexEngine.GetUser(tb_username.Text);
      progressBar.Value = 0;
      yandexEngine.GetUser(tb_username.Text);
      yandexEngine.GetSongList();
      lbl_status.Text = "Processing started";
      yandex_songList.Columns.Add("ID",60);
      yandex_songList.Columns.Add("Songname",yandex_songList.Width - 60);
      yandexEngine.WriteSongList(progressBar,yandex_songList);
    }

    private void from_boxSelector_SelectedIndexChanged(object sender, EventArgs e)
    {
      switch (from_boxSelector.SelectedItem.ToString())
      {
        case "Yandex.Music":
          Debug.Write("Yandex");
          break;
        case "Spotify":
          Debug.Write("Spotify");
          break;
        case "Apple Music":
          Debug.Write("Apple");
          break;
        case "VK Music":
          Debug.Write("VK");
          break;
        default:
          Debug.Write("Not selected");
          break;
      }
    }
    
  }
}
