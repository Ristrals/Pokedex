using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Pokedex
{
    
    public enum httpVerb
    {
        GET, POST, PUT
    }

    //This class gathers data from online APIs
    internal class RestClient
    {
        public string endPoint { get; set; }
        public httpVerb httpMethod { get; set; }

        public RestClient()  //constructor
        { 
            endPoint = string.Empty;
            httpMethod = httpVerb.GET;
        }

        public string MakeRequest()
        {
            string strResponseValue = string.Empty;
            
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(endPoint);

            request.Method = httpMethod.ToString();

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (!response.StatusCode.Equals(HttpStatusCode.OK)) // Checking response status
                {
                    throw new ApplicationException($"error code: {response.StatusCode.ToString()} " );
                }

                using (Stream responseStream = response.GetResponseStream()) // Process the response stream (XML, JSON, HTML, etc...)
                {
                    if (!responseStream.Equals(null))
                    {
                        using (StreamReader reader = new StreamReader(responseStream))
                        {
                            strResponseValue = reader.ReadToEnd();
                        }
                    }
                }

            }

            return strResponseValue;
        }
    }
}
