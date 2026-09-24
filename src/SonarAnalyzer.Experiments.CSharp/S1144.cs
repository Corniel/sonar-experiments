using System.Collections.Generic;
using System.IO;

namespace S1144;

public class ResourceCollection
{
	private readonly Dictionary<string, Dictionary<string, string?>> resources = [];

	public Dictionary<string, string?> this[string key]
	{
		get
		{
			if (!resources.TryGetValue(key, out var resoures))
			{
				resoures = [];
				resources[key] = resoures;
			}
			return resoures;
		}
		private set => resources[key] = value; // FP, used by line 31.
	}

	public static ResourceCollection Load(DirectoryInfo dir)
	{
		var collection = new ResourceCollection();

		foreach (var file in dir.GetFiles($"*.resx"))
		{
			collection[Path.GetFileNameWithoutExtension(file.Name)] = [];
		}
		return collection;
	}
}