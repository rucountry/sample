using Grpc.Net.Client;
using System;
using SimpleGrpcService;
using System.Threading.Tasks;

namespace GrpcClient {
	class Program {
		static async Task Main(string[] args) {
			// создаем канал для обмена сообщениями с сервером
			// параметр - адрес сервера gRPC
			using var channel = GrpcChannel.ForAddress("https://localhost:5001");
			var client = new Greeter.GreeterClient(channel);
			Console.WriteLine("Введите имя: ");
			string name = Console.ReadLine();
			// обмениваемся сообщениями с сервером
			var reply = await client.SayHelloAsync(new HelloRequest {Name = name});
			Console.WriteLine("Ответ сервера: " + reply.Message);
			Console.ReadKey();
		}
	}
}
