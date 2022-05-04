using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using Newtonsoft.Json;
using System.Data.SqlClient;

namespace TED
{
    static class Program
    {

        private static string JSON { get; set; }
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main()
    {
        Application.EnableVisualStyles();
        Application.SetCompatibleTextRenderingDefault(false);
        Application.Run(new Form1());

        #region JSON beolvasása Text-ként
        try
        {   // Open the text file using a stream reader.
            using (StreamReader sr = new StreamReader("data_s.json"))
            {
                // Read the stream to a string, and write the string to the console.
                JSON = sr.ReadToEnd();
            }
        }
        catch (IOException e)
        {
            Console.WriteLine(e.Message);
        }
        #endregion

        #region JSON feldolgozása
        //Newtonsoft telepítése NuGet Package-ként (tools -> NuGet pack. man. -> Manage NuGet Pack. for Sol.)
        //jól dokumentált
        Rootobject TedJson = JsonConvert.DeserializeObject<Rootobject>(JSON);

        List<TedData> weatherForecast = new List<TedData>();

        foreach (List item in TedJson.list)
        {
            weatherForecast.Add(
                new TedData(item.main.title,
                        item.main.author, item.main.date, (int)item.main.views, (int)item.main.likes, item.main.link));
        }

        #endregion
    }




    //valamiért nem működött a kapcsolat a MySQL-el, egyébként jó lenne

    /*
    foreach (DataRow row in adatok_demo2.Rows)
    {
        string title = row["title"].ToString();
        string author = row["author"].ToString();
        string date = row["date"].ToString();
        int views = (int)row["views"];
        int likes = (int)row["likes"];
        string link = row["link"].ToString();
    }
    */








}
}
