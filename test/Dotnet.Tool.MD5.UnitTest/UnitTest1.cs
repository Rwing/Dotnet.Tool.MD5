using System;
using System.Text;
using Xunit;
using Dotnet.Tool.MD5;

namespace Dotnet.Tool.MD5.UnitTest
{
	public class UnitTest1
	{
		[Fact]
		public void ParseArgsTest1()
		{
			var args = new[] { "a", "b" };
			var (p1, p2) = Program.ParseArgs(args);
			Assert.Equal(p1, args[0]);
			Assert.Equal(p2, args[1]);

			args = new[] { "a" };
			(p1, p2) = Program.ParseArgs(args);
			Assert.Equal(p1, args[0]);
			Assert.Null(p2);
		}
		
		[Fact]
		public void HashAlgorithmFactoryTest1()
		{
			var algorithm = HashAlgorithmFactory.Create("md5");
			Assert.Equal(typeof(System.Security.Cryptography.MD5CryptoServiceProvider), algorithm.GetType());
			algorithm = HashAlgorithmFactory.Create("MD5");
			Assert.Equal(typeof(System.Security.Cryptography.MD5CryptoServiceProvider), algorithm.GetType());

			algorithm = HashAlgorithmFactory.Create("foo");
			Assert.Null(algorithm);

			Assert.Throws<ArgumentException>(() => { HashAlgorithmFactory.Create(""); });
		}

		[Fact]
		public void GenerateHashTest1()
		{
			var result = Program.GenerateHash("foo", null);
			Assert.Equal("acbd18db4cc2f85cedef654fccc4a4d8", result);
			result = Program.GenerateHash("foo", "");
			Assert.Equal("acbd18db4cc2f85cedef654fccc4a4d8", result);
			result = Program.GenerateHash("foo", "L");
			Assert.Equal("acbd18db4cc2f85cedef654fccc4a4d8", result);
			result = Program.GenerateHash("foo", "bar");
			Assert.Equal("acbd18db4cc2f85cedef654fccc4a4d8", result);

			result = Program.GenerateHash("foo", "U");
			Assert.Equal("ACBD18DB4CC2F85CEDEF654FCCC4A4D8", result);
			result = Program.GenerateHash("foo", "u");
			Assert.Equal("ACBD18DB4CC2F85CEDEF654FCCC4A4D8", result);
		}
	}
}
