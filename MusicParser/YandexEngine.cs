using System;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;
//.jsx modules, trying to get proper list of songs
using System.Web;
using System.Linq;
using JavaScriptEngineSwitcher.Core.Resources;
using React;

namespace MusicParser
{
    public class YandexEngine
    {
        private string url = "https://music.yandex.ru/users/";  //template for creating a link
        private string songUrl = "https://music.yandex.ru/album/";   //temp: https://music.yandex.ru/album/'albumID'/track/'trackID'
        private string urlUser { get; set; }    //user's name from site
        private string songlist { get; set; }   //user's songlist
        private int numberOfSongs { get; set; }     //number of user's songs

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
            int start,end;  //positions for string cutting
            int counter = 0;
            string temp;

            Stream data;
            data = client.OpenRead(url);    //открываем файл по ссылке
            StreamReader reader = new StreamReader(data);
            songlist = reader.ReadToEnd();  //считываем весь файл
            data.Close();
            reader.Close();
            
            //getting list of songs
            start = songlist.IndexOf("contestTracksIds");
            songlist = songlist.Substring(start + 18);
            end = songlist.IndexOf("]");
            songlist = songlist.Substring(0, end);

            temp = songlist;
            while (true)
            {
                start = temp.IndexOf("id");
                if (start != -1)
                {
                    counter++;
                    temp = temp.Substring(start + 4);
                }
                else
                {
                    break;
                }
            }

            numberOfSongs = counter;
        }

        private string GetSong()
        {
            string id,album;

            /*
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
            */

            //getting song's id
            songlist = songlist.Substring(songlist.IndexOf("id") + 5);
            id = songlist.Substring(0, songlist.IndexOf("\""));
            
            //getting song's album
            int end = songlist.IndexOf("albumId");
            Debug.WriteLine("Current index of albumID = " + end); //DEBUG
            Debug.WriteLine("Current songlist length = " + songlist.Length);
            songlist = songlist.Substring(end + 10);
            album = songlist.Substring(0, songlist.IndexOf("\""));

            return (id + " - " + album);
        }

        public void WriteSongList()
        {
            string path = @"C:\Users\Artem\RiderProjects\MusicParser\MusicParser\bank.txt";
            
            StreamWriter dockOut = new StreamWriter(path,false);
            for (int i = 0; i < numberOfSongs; i++)
            {
                try
                {
                    Debug.WriteLine("Current i = " + i);
                    GetSong();
                    if (i == 799) dockOut.WriteLine(GetSong());
                }
                catch (Exception exception)
                {
                    dockOut.WriteLine("Error!!!");
                    dockOut.WriteLine(exception.Message);
                    Debug.WriteLine($"error = {exception.Message}");
                    Debug.WriteLine($"Трассировка стека: {exception.StackTrace}");
                    MessageBox.Show("ERROR!", "Message", MessageBoxButtons.OK);
                }
            }
            
            MessageBox.Show("All done", "Message", MessageBoxButtons.OK);
        }
        
    }
}