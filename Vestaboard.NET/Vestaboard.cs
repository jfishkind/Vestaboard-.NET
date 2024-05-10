using System;
using System.Net.Http;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace VestaboardPackage;

public class Vestaboard
{
    private const string RequestUri = "https://rw.vestaboard.com/";
    private const string HeaderName = "X-Vestaboard-Read-Write-Key";
    private string Key { get; }
    private HttpClient Client { get; }

    public Vestaboard(IConfigurationRoot config)
    {
        try
        {
            Key = config["READ_WRITE_KEY"]!;
        }
        catch(Exception)
        {
            throw new NullReferenceException("Could not get the Read/Write Key");
        }
        
        Client = new HttpClient();
    }

    public async Task<HttpResponseMessage> GetCurrentView()
    {
        return await SendRequest(HttpMethod.Get, "");
    }

    public async Task<HttpResponseMessage> SendSimpleMessage(string message)
    {
        return await SendRequest(HttpMethod.Post, message);
    }

    public async Task<string> SendComplexMessage(int[][] message)
    {
        return "";
    }

    private async Task<HttpResponseMessage> SendRequest(HttpMethod method, string message)
    {
        var request = new HttpRequestMessage(method, RequestUri);

        request.Headers.Add(HeaderName, Key);

        request.Content = new StringContent(message);
        request.Content.Headers.ContentType = new MediaTypeHeaderValue("application/json");

        var response = await Client.SendAsync(request);

        return response;
    }

    private static string GetJsonString(string message)
    {
        var jsonObject = new
        {
            text = message
        };
        
        return JsonConvert.SerializeObject(jsonObject);
    }
}