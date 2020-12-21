using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
      //yandexEngine = YandexEngine.GetUser(tb_username.Text);
      yandexEngine.GetUser(tb_username.Text);
      yandexEngine.GetSongList();
      yandexEngine.WriteSongList();
    }
  }
}
