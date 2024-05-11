using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace FirstCode
{
    internal class CallAPITest
    {
        static void Main()
        {            
            PostData postData = new PostData();
            postData.Name = "John Doe";
            postData.Age = 30;
            postData.Address = "123 Main St";

            string json = JsonSerializer.Serialize(postData); //serializing the obj into json
            StringContent content = new StringContent(json, Encoding.UTF8, "application/json"); //keeping the json into string format

            HttpClient client = new HttpClient();
            client.BaseAddress = new Uri("https://jsonplaceholder.typicode.com/"); //this is url of api testing 

            HttpResponseMessage response = client.PostAsync("posts", content).Result;
            //HttpResponseMessage response = client.GetAsync("todos").Result;

            if (response.IsSuccessStatusCode)
            {
                string responseContent = response.Content.ReadAsStringAsync().Result;

                var options = new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true
                };
                //Console.WriteLine(responseContent);
                var postResponse = JsonSerializer.Deserialize<PostResponse>(responseContent, options);
                Console.WriteLine("Post successful! ID: " + postResponse.Id);

            }
            else
            {
                Console.WriteLine("Error: " + response.StatusCode);
            }

        }
    }
    public class PostData
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Address { get; set; }
    }

    public class PostResponse
    {
        public int Id { get; set; }
    }
} 

