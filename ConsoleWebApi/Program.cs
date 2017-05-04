using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleWebApi
{
	class Program
	{
		private const string APP_PATH = "http://localhost:12150";
		private static string token;

		static void Main(string[] args)
		{
			Console.WriteLine("Введите логин:");
			string userName = Console.ReadLine();

			Console.WriteLine("Введите пароль:");
			string password = Console.ReadLine();

			var registerResult = Register(userName, password);

			Console.WriteLine("Статусный код регистрации: {0}", registerResult);
			Dictionary<string, string> tokenDictionary = GetTokenDictionary(userName, password);
			token = tokenDictionary["access_token"];

			Console.WriteLine();
			Console.WriteLine("Access Token:");
			Console.WriteLine(token);

			Console.WriteLine();
			string userInfo = GetUserInfo(token);
			Console.WriteLine("Пользователь:");
			Console.WriteLine(userInfo);

			Console.WriteLine();
			string values = GetValues(token);
			Console.WriteLine("Values:");
			Console.WriteLine(values);

			Console.Read();
		}
		static string Register(string email, string password)
		{
			var registerModel = new
			{
				Email = email,
				Password = password,
				ConfirmPassword = password
			};
			using (var client = new HttpClient())
			{
				var response = client.PostAsJsonAsync(APP_PATH + "/api/Account/Register", registerModel).Result;
				return response.StatusCode.ToString();
			}
		}
		static Dictionary<string, string> GetTokenDictionary(string userName, string password)
		{
			var pairs = new List<KeyValuePair<string, string>>
				{
					new KeyValuePair<string, string>( "grant_type", "password" ),
					new KeyValuePair<string, string>( "username", userName ),
					new KeyValuePair<string, string> ( "Password", password )
				};
			var content = new FormUrlEncodedContent(pairs);

			using (var client = new HttpClient())
			{
				var response = client.PostAsync(APP_PATH + "/Token", content).Result;
				var result = response.Content.ReadAsStringAsync().Result;
				// Десериализация полученного JSON-объекта
				Dictionary<string, string> tokenDictionary = JsonConvert.DeserializeObject<Dictionary<string, string>>(result);
				return tokenDictionary;
			}
		}
		static HttpClient CreateClient(string accessToken = "")
		{
			var client = new HttpClient();
			if (!string.IsNullOrWhiteSpace(accessToken))
			{
				client.DefaultRequestHeaders.Authorization = new System.Net.Http.Headers.AuthenticationHeaderValue("Bearer", accessToken);
			}
			return client;
		}
		static string GetUserInfo(string token)
		{
			using (var client = CreateClient(token))
			{
				var response = client.GetAsync(APP_PATH + "/api/Account/UserInfo").Result;
				return response.Content.ReadAsStringAsync().Result;
			}
		}
		static string GetValues(string token)
		{
			using (var client = CreateClient(token))
			{
				var response = client.GetAsync(APP_PATH + "/api/values").Result;
				return response.Content.ReadAsStringAsync().Result;
			}
		}
	}
}
