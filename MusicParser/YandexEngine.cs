using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Windows.Forms;

namespace MusicParser
{
    public class YandexEngine
    {
        private string url = "https://music.yandex.ru/users/"; //template for creating a link

        private string
            songUrl = "https://music.yandex.ru/track/"; //temp: https://music.yandex.ru/track/'trackID'

        private string urlUser { get; set; } //user's name from site
        private string songlist { get; set; } //user's songlist
        private int numberOfSongs { get; set; } //number of user's songs
        private Dictionary<int, string> database = new Dictionary<int, string>();
        ProgressBar bar;
        
        //static string path = @"C:\Users\Artem\RiderProjects\MusicParser\MusicParser\bank.txt";
        //StreamWriter dockOut = new StreamWriter(path,false);
        private ListView songListView;

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
            int start, end; //positions for string cutting
            int counter = 1;
            string temp;

            Stream data;
            data = client.OpenRead(url); //открываем файл по ссылке
            StreamReader reader = new StreamReader(data);
            songlist = reader.ReadToEnd(); //считываем весь файл
            data.Close();
            reader.Close();

            //getting list of songs
            start = songlist.IndexOf("trackIds");
            songlist = songlist.Substring(start + 10);
            end = songlist.IndexOf("]");
            songlist = songlist.Substring(0, end);

            temp = songlist;
            while (true)
            {
                start = temp.IndexOf(",");
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

        private string GetSong(int i)
        {
            string id;
            
            //getting song's id
            songlist = songlist.Substring(songlist.IndexOf("\"") + 1);
            id = songlist.Substring(0, songlist.IndexOf("\""));
            if (songlist.IndexOf(",") != -1) songlist = songlist.Substring(songlist.IndexOf(","));
            
            database.Add(i, (id));

            return (id);
        }

        private void GetSongName(int dictrIndex) //получает индекс песни в словаре чтобы потом заменить словарную запись
        {
            WebClient webClient = new WebClient();
            string songData;
            string currentSongUrl;
            string filler = "Other";
            string[] transfer = new string[2];

            Stream data;
            
            currentSongUrl = songUrl + database[dictrIndex];

            data = webClient.OpenRead(currentSongUrl);
            StreamReader streamReader = new StreamReader(data);
            do
            {
                songData = streamReader.ReadLine();
            } while (songData.Contains("</title>") == false);

            data.Close();
            streamReader.Close();

            //поиск названия песни и ее исполнителя
            songData = songData.Substring(songData.IndexOf("<title>") + 7);
            if (songData.IndexOf("Слушать") != -1) songData = songData.Substring(0, songData.IndexOf("Слушать") - 2);
            else songData.Substring(songData.IndexOf("</title>"));
            
            
            //проверка на апостроф
            while (songData.IndexOf("&#39;") != -1)
            {
                songData = songData.Replace("&#39;", "\'");
            }
            while (songData.IndexOf("&#38;") != -1)
            {
                songData = songData.Replace("&#38;", "&");
            }
            
            transfer = songData.Split('—');
            transfer[0] = transfer[0].Trim(' ');
            
            if (transfer.Length > 1)
            {
                transfer[1] = transfer[1].Trim(' ');
                database[dictrIndex] = (transfer[0] + "-" + transfer[1]);
            }
            else
            {
                database[dictrIndex] = (transfer[0] + "-" + filler);
            }
        }

        public void WriteSongList(ProgressBar progressBar,ListView ListView)
        {
            bar = progressBar;
            songListView = ListView;

            //dockOut.Flush();    
            
            BackgroundWorker worker = new BackgroundWorker();
            worker.WorkerReportsProgress = true;
            worker.DoWork += workerDoWork;
            worker.ProgressChanged += workerProgressChanged;
            worker.RunWorkerCompleted += workerWorkCompleted;
            worker.RunWorkerAsync();
        }

        void workerDoWork(object sender, DoWorkEventArgs e)
        {
            int progress = 0;

            for (int i = 0; i < numberOfSongs; i++)
            {
                try
                {
                    GetSong(i);
                    GetSongName(i);
                    progress = Convert.ToInt32(((double) i / numberOfSongs) * 100);
                    (sender as BackgroundWorker).ReportProgress(progress,i);
                }
                catch (Exception exception)
                {
                    Debug.WriteLine($"error = {exception.Message}");
                    Debug.WriteLine($"database info: {database[i]};\ni = {i}");
                }
            }
        }

        void workerProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            bar.Value = e.ProgressPercentage;

            ListViewItem temp = new ListViewItem(new[]
                {Convert.ToString(e.UserState), Convert.ToString(database[(int) e.UserState])});
            
            //songListView.Items.Add(Convert.ToString(e.UserState), Convert.ToString(database[(int) e.UserState]),0);
            songListView.Items.Add(temp);
            //dockOut.WriteLine(database[(int)e.UserState]);
        }

        void workerWorkCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            MessageBox.Show("All done", "Message", MessageBoxButtons.OK);
        }
    }
}