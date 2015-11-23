using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Serialization;
using System.Net;

namespace MyMusicStore.Models
{
    public class Search
    {
        string artist;
        public string Artist { get; set;}
        public Object getArtistInfo()
        {
            string appID = "GJZC9LKRBGRYD8B6P ";
            artist = "metallica";
            string url = "http://developer.echonest.com/api/v4/artist/search?api_key="+ appID + "&format=json&name=" + artist + "&results=1&bucket=genre&bucket=songs";
            //synchronous client;
            var client = new WebClient();
            var content = client.DownloadString(url);
            var serializer = new JavaScriptSerializer();
            var jsonContent = serializer.Deserialize<Object>(content);
            return jsonContent;
        }
    }
}