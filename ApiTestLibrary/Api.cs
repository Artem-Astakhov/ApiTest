using Newtonsoft.Json;
using System.IO;
using System.Net;


namespace ApiTestLibrary
{
    public class Api
    {
        public RootObject root = new RootObject();
        
        public void GetValue()
        {
            var httpWebRequest = (HttpWebRequest)WebRequest.Create("http://tester.consimple.pro");

            httpWebRequest.ContentType = "text/json";
            httpWebRequest.Method = "Get";
            var httpResponse = (HttpWebResponse)httpWebRequest.GetResponse();

            using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
            {
                var result = streamReader.ReadToEnd();

                root = JsonConvert.DeserializeObject<RootObject>(result);

            }
        }
    }

}
