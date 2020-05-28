using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class ResourcesController : MonoBehaviour
{
    public List<Pack> GetAllWordMemorizePack()
    {
        return GetWordMemorizeJsonPackToPackList(Resources.LoadAll<TextAsset>("WordPacks").ToList());
    }

    private List<Pack> GetWordMemorizeJsonPackToPackList(List<TextAsset> memorizeJsonPacks)
    {
        List<Pack> pack = new List<Pack>();

        Debug.Log(memorizeJsonPacks.Count);

        memorizeJsonPacks.ForEach(delegate (TextAsset textAsset)
        {
            Pack newWordPack = JsonUtility.FromJson<Pack>(textAsset.text);
            pack.Add(newWordPack);
        });

        return pack;
    }

}
