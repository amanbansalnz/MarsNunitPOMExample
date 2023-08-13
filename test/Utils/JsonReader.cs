
using System;
using Newtonsoft.Json;

namespace test.Utils
{
	public class JsonReader
	{
		
            public static Object loadData(String path)
            {
                using StreamReader reader = new StreamReader(path);
                var jsonContent = reader.ReadToEnd();
                return JsonConvert.DeserializeObject<Object>(jsonContent);
            }

   
	}
}

