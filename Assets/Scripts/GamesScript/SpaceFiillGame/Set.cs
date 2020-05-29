using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Set
{
    public readonly List<IDictionary<string, string>> set;

    public int currentIndex { get; private set; }

    public Set(Pack pack)
    {
        currentIndex = 0;

        int sumUnit = pack.units.Count;

        sumUnit /= 5;

        set = new List<IDictionary<string, string>>(sumUnit);

        SplitPackToList(pack, sumUnit);

    }

    public void SplitPackToList(Pack pack, int splitValue)
    {
        int index = 0;

        set.ForEach(delegate (IDictionary<string, string> pairDic)
        {
            pairDic = new Dictionary<string, string>();

            for (int i = index; i < splitValue; i++)
            {
                pairDic.Add(pack.units[i].word, pack.units[i].description);
            }

            index += splitValue;

            splitValue += splitValue;

        });
    }

    public void IncreaseIndex() => currentIndex++;

    public IDictionary<string, string> GetIndexOfDictionary(int index)
    {
        return set[index];
    }

    public bool IsNext()
    {
        return set.Count < currentIndex;
    }

    public bool IsCorrect(string word, string description)
    {
        return set[currentIndex][word] == description;
    }

    public static List<List<T>> Split<T>(List<T> collection, int size)
    {
        var chunks = new List<List<T>>();
        var chunkCount = collection.Count() / size;

        if (collection.Count % size > 0)
            chunkCount++;

        for (var i = 0; i < chunkCount; i++)
            chunks.Add(collection.Skip(i * size).Take(size).ToList());

        return chunks;
    }
}