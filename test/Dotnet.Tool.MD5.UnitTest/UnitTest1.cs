using System;
using Xunit;
using Dotnet.Tool.MD5;

namespace Dotnet.Tool.MD5.UnitTest
{
	public class UnitTest1
	{
		[Fact]
		public void Test1()
		{
			var args = new[] { "a", "b" };
			var (p1, p2) = Program.ParseArgs(args);
			Assert.Equal(p1, args[0]);
			Assert.Equal(p2, args[1]);
		}
	}
}
