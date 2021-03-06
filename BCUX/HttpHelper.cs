﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    static class HttpHelper
    { 
        public static async Task<string> Post(string myParam)
        {
            string ApiKey = "";
            string ApiSecret = "";
            myParam = "command="+ myParam+"&nonce=" + DateTime.Now.Ticks;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("https://poloniex.com/tradingApi");
                StringContent myContent = new StringContent(myParam);
                myContent.Headers.ContentType = new MediaTypeHeaderValue("application/x-www-form-urlencoded");
                client.DefaultRequestHeaders.Add("Key", ApiKey);
                client.DefaultRequestHeaders.Add("Sign", genHMAC(myParam, ApiSecret));
                var result = await client.PostAsync("https://poloniex.com/tradingApi", myContent);
                return await result.Content.ReadAsStringAsync();
            }
        }
        private static string genHMAC(string message, string ApiSecret)
        {
            var hmac = new HMACSHA512(Encoding.ASCII.GetBytes(ApiSecret));
            var messagebyte = Encoding.ASCII.GetBytes(message);
            var hashmessage = hmac.ComputeHash(messagebyte);
            var sign = BitConverter.ToString(hashmessage).Replace("-", "").ToLower();
            return sign;
        } 
        public static string Get(string MyParam)
        {
            string WEBSERVICE_URL = "https://poloniex.com/public?command=" + MyParam;
            var webRequest = System.Net.WebRequest.Create(WEBSERVICE_URL);
            webRequest.Method = "GET";
            webRequest.ContentType = "application/x-www-form-urlencoded";
            using (System.IO.Stream s = webRequest.GetResponse().GetResponseStream())
            using (System.IO.StreamReader sr = new System.IO.StreamReader(s))
            {
                string jsonResponse = sr.ReadToEnd();
                return jsonResponse;
            }
        }
    }
}
