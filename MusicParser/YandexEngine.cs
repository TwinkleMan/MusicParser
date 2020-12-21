using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MusicParser
{
    public class YandexEngine
    {
        private string url = "https://music.yandex.ru/users/";  //template for creating a link
        private string urlUser { get; set; }    //user's name from site
        private string songlist { get; set; }   //user's songlist

        public void GetUser(string Username) 
        { 
            string username = Username + "/tracks"; 
            urlUser = username; 
            url += urlUser;
            //Console.WriteLine(urlUser);
            Debug.WriteLine("urlUser =" + urlUser + "\n" + "url = " + url);
        }

        public void GetSongList()
        {
            WebClient client = new WebClient(); //creating a web client

            /*Stream data;
            data = client.OpenRead(url);
            StreamReader reader = new StreamReader(data);
            songlist = reader.ReadToEnd();
            data.Close();
            reader.Close();*/ //old page download, saving html as a string
        }

        private string GetSong()
        {
            string name,artist;

            int start,end;
            
            //get song name
            start = songlist.IndexOf("div class=\"d-track__name\" title=");
            name = songlist.Substring(start + 33);
            end = name.IndexOf("\"");
            name = name.Substring(0, end);
            
            //trimming the input data
            start = songlist.IndexOf("span class=\"d-track__artists\"");
            songlist = songlist.Substring(start + 29);
            
            //get song artist
            start = songlist.IndexOf("title=\"");
            artist = songlist.Substring(start + 7);
            songlist = songlist.Substring(start + 33);  //modifying the input data
            end = artist.IndexOf("\"");
            artist = artist.Substring(0, end);

            name = name + " " + artist;
            
            return name;
        }

        public void WriteSongList()
        {
            //придумать, когда останавливать поиск треков
            string path = @"C:\Users\Artem\RiderProjects\MusicParser\MusicParser\bank.txt";
            
            StreamWriter dockOut = new StreamWriter(path,true);
            for (int i = 0; i < 900; i++)
            {
                try
                {
                    dockOut.WriteLine(GetSong());
                    if (i == 133) Debug.WriteLine("yay");
                }
                catch
                {
                    dockOut.WriteLine("Error!!!");
                    Debug.WriteLine("error!!");
                    MessageBox.Show("ERROR!", "Message", MessageBoxButtons.OK);
                }
            }

            MessageBox.Show("All done", "Message", MessageBoxButtons.OK);
            
            Debug.WriteLine(GetSong());
        }
        
    }
}