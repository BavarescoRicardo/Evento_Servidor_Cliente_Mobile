using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Net;

namespace EventoMobile.Rest_Servidor_Client
{
    class ClienteRest
    {
        public string endPoint { get; set; }

        public ClienteRest()
        {
            endPoint = string.Empty;
        }

        public string obterDados(string url)
        {
            string resposta = string.Empty;
            try
            {
                HttpWebRequest webRequest = HttpWebRequest.Create(url) as HttpWebRequest;
                webRequest.Method = WebRequestMethods.Http.Get;
                //webRequest.Credentials = new NetworkCredential("", "");
                webRequest.ContentType = "application/json";
                using (HttpWebResponse response = webRequest.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        // Do stuff with response.GetResponseStream();
                        Stream stream = response.GetResponseStream();
                        using (StreamReader reader = new StreamReader(stream))
                        {
                            resposta = reader.ReadToEnd();
                        }
                        return resposta;

                    }
                }
            }
            catch (Exception ex)
            {
                throw new ApplicationException("Erros foram cometidos");
                // if the server returns a 500 error than the webRequest.GetResponse() method
                // throws an exception and all I get is "The remote server returned an error: (500)."
            }
            return resposta;
        }
    }
}
