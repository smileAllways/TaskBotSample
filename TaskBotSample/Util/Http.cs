﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace TaskBotSample.Util
{
    public class Http
    {
        //public void CallApi(string url)
        //{
        //    string query = "네이버 Open API"; // 검색할 문자열
        //    string url = "https://openapi.naver.com/v1/search/blog?query=" + query; // JSON 결과
        //    // string url = "https://openapi.naver.com/v1/search/blog.xml?query=" + query;  // XML 결과
        //    HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
        //    request.Headers.Add("X-Naver-Client-Id", "YOUR-CLIENT-ID"); // 클라이언트 아이디
        //    request.Headers.Add("X-Naver-Client-Secret", "YOUR-CLIENT-SECRET");       // 클라이언트 시크릿
        //    HttpWebResponse response = (HttpWebResponse)request.GetResponse();
        //    string status = response.StatusCode.ToString();
        //    if (status == "OK")
        //    {
        //        Stream stream = response.GetResponseStream();
        //        StreamReader reader = new StreamReader(stream, Encoding.UTF8);
        //        string text = reader.ReadToEnd();
        //        Console.WriteLine(text);
        //    }
        //    else
        //    {
        //        Console.WriteLine("Error 발생=" + status);
        //    }
        //}

        //public async Task AsyncCallApi()
        //{
        //    await Task.Run(() => { CallApi(); });
        //}
    }
}
