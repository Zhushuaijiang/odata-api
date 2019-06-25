using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Task.Run(() => MainAsync());
            Console.ReadLine();
        }

        static async Task MainAsync()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://127.0.0.1:53858");

                //Post  方法
                var content = new FormUrlEncodedContent(new[]
                {
                new KeyValuePair<string, string>("USERNO", "admin"),
                new KeyValuePair<string, string>("PASSWORD", "yoisoft"),
               });
                var result1 = await client.PostAsync("/api/Api_User/CheckLogin", content);

                string resultContent1 = await result1.Content.ReadAsStringAsync();
                Console.WriteLine(resultContent1);


                //Get  方法

                var result2 = await client.GetAsync("/api/Api_User/RecordQuery?key=bssa");
                //返回字符串
                string resultContent2 = await result2.Content.ReadAsStringAsync();
                //返回对象
                //var client = new HttpClient();
                //var response = await client.GetAsync("/api/Api_User/RecordQuery?key=bssa");
                //var products = response.Content.ReadAsAsync<IEnumerable<DeathRecordEntity>>();
                Console.WriteLine(resultContent2);

            }


        }

      
    }
}
