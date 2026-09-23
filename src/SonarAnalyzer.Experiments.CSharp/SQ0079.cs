using System;
using System.Security.Cryptography;

namespace SQ0079;

public static class Guids
{
	#pragma warning disable S4790
	public static Guid MD5Hash(byte[] data)
	{
		var hash = MD5.HashData(data); // Suppressed S4790
		return new Guid(hash);
	}
}
