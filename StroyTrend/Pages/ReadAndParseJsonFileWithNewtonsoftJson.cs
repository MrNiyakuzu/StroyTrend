//using Newtonsoft.Json;
using Newtonsoft.Json;
using System;
using System.Text.Json;
public class ReadAndParseJsonFileWithNewtonsoftJson<T>
{
    private readonly string _sampleJsonFilePath;
    public ReadAndParseJsonFileWithNewtonsoftJson(string sampleJsonFilePath)
    {
        _sampleJsonFilePath = sampleJsonFilePath;
    }
    public T UseUserDefinedObjectWithNewtonsoftJson()
    {
        //using (FileStream fs = new FileStream(_sampleJsonFilePath, FileMode.OpenOrCreate))
        //{
        //    T? obj = JsonSerializer.Deserialize<T>(fs);
        //    return obj;
        //}

        //Console.WriteLine($"Name: {person?.Name}  Age: {person?.Age}");

        using StreamReader reader = new(_sampleJsonFilePath);
        var json = reader.ReadToEnd();
        T obj = JsonConvert.DeserializeObject<T>(json);

        return obj;


    }
}