using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Helpers;

namespace WebApp.ApplicationPresentation.Service
{
    public class ServiceApi<T>
    {
        HttpClient Client = new HttpClient();
        string Url = "http://localhost:45061";

        protected IEnumerable<T> GetAll(string UrlParametro)
        {
            HttpResponseMessage resultado = Client.GetAsync(Url + UrlParametro).GetAwaiter().GetResult();
            return resultado.Content.ReadAsAsync<IEnumerable<T>>().GetAwaiter().GetResult();
        }
        protected T GetById(string UrlParametro, int id)
        {
            HttpResponseMessage resultado = Client.GetAsync(Url + UrlParametro + id).GetAwaiter().GetResult();

            return resultado.Content.ReadAsAsync<T>().GetAwaiter().GetResult();
        }
        protected bool Post(string url, T obj)
        {
            var resultado = Client.PostAsJsonAsync(Url + url, obj).GetAwaiter().GetResult();
            return resultado.IsSuccessStatusCode;
        }
        protected bool Put(string url, T obj)
        {
            var resultado = Client.PutAsJsonAsync(Url + url, obj).GetAwaiter().GetResult();
            return resultado.IsSuccessStatusCode;
        }

        protected bool Delete(string url)
        {
            var resultado = Client.DeleteAsync(Url + url).GetAwaiter().GetResult();
            return resultado.IsSuccessStatusCode;
        }
    }
}
