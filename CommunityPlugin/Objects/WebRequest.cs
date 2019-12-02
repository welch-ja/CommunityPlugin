using System;
using System.IO;
using System.Net;

namespace CommunityPlugin.Objects
{
    public static class WebRequest
    {
        public static string Request(string uri)
        {
            HttpWebRequest request = (HttpWebRequest)System.Net.WebRequest.Create(uri);
            request.AutomaticDecompression = DecompressionMethods.GZip | DecompressionMethods.Deflate;

            request.Method = "GET";

            try
            {
                HttpWebResponse response = (HttpWebResponse)request.GetResponse();
                if (response.StatusCode == HttpStatusCode.NotFound)
                    return string.Empty;

                using (Stream stream = response.GetResponseStream())
                {
                    using (StreamReader sr = new StreamReader(stream))
                    {
                        return sr.ReadToEnd();
                    }
                }
            }
            catch(Exception ex)
            {
                Logger.HandleError(ex, nameof(WebRequest));
                return string.Empty;
            }
        }
    }
}
