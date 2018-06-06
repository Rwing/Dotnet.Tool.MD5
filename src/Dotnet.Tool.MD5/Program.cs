using System;
using System.Security.Cryptography;
using System.Text;

namespace Dotnet.Tool.MD5
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			var (input, option) = ParseArgs(args);
			var result = GenerateHash(input, option);
			Console.WriteLine(result);
		}

		public static string GenerateHash(string input, string option, string algorithmName = "md5")
		{
			//TODO: support more algorithm
			using (var algorith = HashAlgorithmFactory.Create(algorithmName))
			{
				var bytes = algorith.ComputeHash(Encoding.UTF8.GetBytes(input));
				var hash = BitConverter.ToString(bytes).Replace("-", "");
				var shouldUpper = !string.IsNullOrWhiteSpace(option) &&
				                  option.Equals("U", StringComparison.InvariantCultureIgnoreCase);
				return shouldUpper ? hash.ToUpper() : hash.ToLower();
			}
		}

		public static (string, string) ParseArgs(string[] args)
		{
			var input = args.Length > 0 ? args[0] : new DateTimeOffset(DateTime.UtcNow).ToUnixTimeSeconds().ToString();
			var option = args.Length > 1 ? args[1] : null;
			return (input, option);
		}
	}
}
