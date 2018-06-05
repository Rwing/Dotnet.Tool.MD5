using System;
using System.Security.Cryptography;
using System.Text;

namespace Dotnet.Tool.MD5
{
	public static class Program
	{
		public static void Main(string[] args)
		{
			using (System.Security.Cryptography.MD5 md5Hash = System.Security.Cryptography.MD5.Create())
			{
				var (input, option) = ParseArgs(args);
				var bytes = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
				var hash = BitConverter.ToString(bytes).Replace("-", "").ToLower();
				Console.WriteLine(hash);
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
