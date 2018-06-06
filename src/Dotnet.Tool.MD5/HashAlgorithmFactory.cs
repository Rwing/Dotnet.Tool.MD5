using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Security.Cryptography;
using System.Text;

namespace Dotnet.Tool.MD5
{
	public static class HashAlgorithmFactory
	{
		public static HashAlgorithm Create(string name)
		{
			if (string.IsNullOrEmpty(name))
				throw new ArgumentException($"{nameof(name)} can not be null or empty", nameof(name));
			return HashAlgorithm.Create(name);
		}
	}
}