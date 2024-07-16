using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

[Serializable]
public class Fi20
{
    private string firstName;
    private string lastName;
    public string FirstName 
    { 
        get { return firstName; } 
        set { firstName = value; } 
    }

    public string LastName 
    { 
        get { return lastName; } 
        set { lastName = value; } 
    }
}

class DataSerializer
{
    public void BinarySerialize(object data, string filepath)
    {
        FileStream fileStream;
        BinaryFormatter bf = new BinaryFormatter();
        if (File.Exists(filepath)) File.Delete(filepath);
        fileStream = File.Create(filepath);
        bf.Serialize(fileStream, data);
        fileStream.Close();
    }

    public object BinaryDeserialize(string filepath)
    {
        object obj = null;
        FileStream fileStream;
        BinaryFormatter bf = new BinaryFormatter();
        if (File.Exists(filepath))
        {
            fileStream = File.OpenRead(filepath);
            obj = bf.Deserialize(fileStream);
            fileStream.Close();
        }
        return obj;
    }
}

class C1
{
    static void Main(string[] args)
    {
        F89 f = new F89();
        f.FirstName = "John";
        f.LastName = "Banas";
        string filePath = "data.save";
        DataSerializer ds = new DataSerializer();
        ds.BinarySerialize(f, filePath);
        F89 f89 = (F89)ds.BinaryDeserialize(filePath);

        Console.WriteLine("First Name: " + f89.FirstName);
        Console.WriteLine("Last Name: " + f89.LastName);
    }
}