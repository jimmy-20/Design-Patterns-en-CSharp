public class FileManager
{
    private static FileManager fm;
    private static string _path;

    private FileManager() { }

    public static FileManager getInstanceFile(string path)
    {
        if (fm == null)
        {
            fm = new();
            _path = path;
        }

        return fm;
    }

    public void Write(string text)
    {
        using (StreamWriter w = new StreamWriter(_path, true))
        {
            w.WriteLine(text);
        }
    }

    public string Read()
    {
        string content;

        using (StreamReader r = new StreamReader(_path))
        {
            content = r.ReadToEnd();
        }

        return content;
    }

    public bool Delete()
    {
        File.Delete(_path);
        return true;
    }

    public void Update(string id, string text)
    {
        List<string> content = File.ReadAllLines(_path).ToList();

        for (int i = 0; i < content.Count; i++)
        {
            if (content[i].StartsWith(id))
            {
                content[i] = text;
            }
        }

        File.WriteAllLines(_path,content);
    }
}