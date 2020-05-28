using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class SpaceFillGame : MonoBehaviour
{
    public Text scoreText;

    public Pack currentPack;

    public List<Set> wordSets;

    public Transform filledButtonParents;

    public Transform fillButtonParents;

    IDictionary<SpaceFillButton, SpaceFilledButton> spaceFillPair;

    public int currentWordSetIndex = 0;

    private void Awake()
    {
        /*
        spaceFillPair = new Dictionary<SpaceFillButton, SpaceFilledButton>(5);

        using (var fillButtons = filledButtonParents.GetComponentsInChildren<SpaceFillButton>().ToList().GetEnumerator())
        using (var filledButtons = fillButtonParents.GetComponentsInChildren<SpaceFilledButton>().ToList().GetEnumerator())
        {
            if (filledButtons.MoveNext())
            {
                spaceFillPair.Add(fillButtons.Current, filledButtons.Current);
            }
        }
        */
    }

    public void SetGameWordPack()
    {
        List<Unit> allUnits = currentPack.units;

        IEnumerable splittedList = SplitList<Unit>(allUnits);

        wordSets = new List<Set>();

        foreach (List<Unit> splitPart in splittedList)
        {
            Set newSet = new Set();

            splitPart.ForEach(delegate (Unit unit)
            {
                newSet.setDictionary.Add(unit.word, unit.description);
            });

            wordSets.Add(newSet);
        }

        foreach (SpaceFilledButton filledButton in spaceFillPair.Values)
        {
            filledButton.OnWordDragged += WordDroppedOnDescription;
        }
    }

    public void SetCurrentPage(IDictionary<SpaceFillButton, SpaceFilledButton> spaceButtons, Set sets)
    {
        using (var buttonPair = spaceButtons.GetEnumerator())
        using (var set = sets.setDictionary.GetEnumerator())
        {
            if (buttonPair.MoveNext())
            {
                buttonPair.Current.Key.SetFillButton(set.Current.Key);
                buttonPair.Current.Value.SetFilledButton(set.Current.Value);
            }
        }
    }

    public void WordDroppedOnDescription(SpaceFillButton fill,SpaceFilledButton filled)
    {

    }

    public static IEnumerable<List<T>> SplitList<T>(List<T> bigList, int nSize = 10)
    {
        for (int i = 0; i < bigList.Count; i += nSize)
        {
            yield return bigList.GetRange(i, Mathf.Min(nSize, bigList.Count - i));
        }
    }

    public void DisamblePack(List<Unit> units)
    {
        wordSets = new List<Set>(units.Count / 5);

        int index = 1;

        for (int i = 0; i < units.Count; i++)
        {
            Set newSet = new Set();
            if (index % 5 == 0)
            {

            }
        }
    }
}

public class Set
{
    public IDictionary<string, string> setDictionary;

    public Set()
    {
        setDictionary = new Dictionary<string, string>(5);
    }
}