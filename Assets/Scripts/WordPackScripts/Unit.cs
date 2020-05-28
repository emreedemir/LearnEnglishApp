using System;

[Serializable]
public class Unit
{
    public string word;
    public string description;

    public Unit(string word, string description)
    {
        this.word = word;
        this.description = description;
    }
}
