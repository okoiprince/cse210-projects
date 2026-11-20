using System;

public class ScriptureLibrary
{
    private List<Scripture> _scripture;
    private Random random = new Random();

    public ScriptureLibrary()
    {
        _scripture = new List<Scripture>();
    }

    public void AddScripture(Scripture newScripture)
    {
        _scripture.Add(newScripture);
    }

    public Scripture GetRandomScripture()
    {

        if (_scripture.Count == 0)
        {
            return null;
        }

        int index = random.Next(_scripture.Count);

        return _scripture[index];
    }
}