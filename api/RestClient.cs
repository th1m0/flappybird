using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Flappy_Bird.api
{
    /// <summary>
    /// API Rest client will handle all the api calls.
    /// </summary>
    class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }
        public string host { get; set; }
        public string[][] headers { get; set; }

        public RestClient(httpVerb verb)
        {
            endPoint = "";
            httpMethod = verb;
            headers = new string[][] { };
        }

        public string makeRequest()
        {
            string strResponseValue = string.Empty;
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);
            request.Host = host;
            request.Method = httpMethod.ToString();
            if (headers.Length > 0)
            {
                for (int i = 0; i < headers.Length; i++)
                {
                    request.Headers.Add(headers[i][0], headers[i][1]);
                }
            }
            HttpWebResponse response = null;
            try
            {
                response = (HttpWebResponse)request.GetResponse();
                using (Stream responseStream = response.GetResponseStream())
                {
                    if (responseStream != null)
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                strResponseValue = "{\"errorMessage\": \":[" + ex.Message.ToString() + "\"], \"errors\":{}}";
            }
            finally
            {
                if (response != null)
                {
                    ((IDisposable)response).Dispose();
                }
            }
            return strResponseValue;
        }
    }


    public enum httpVerb
    {
        GET,
        POST,
        PUT,
        DELETE
    }
}
