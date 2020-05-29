using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System.Linq;

public class SpaceFillGame : BaseGame
{
    public Text scoreText;

    public Pack currentPack;

    public Set wordSets;

    public GameObject fillButtonParents;

    public GameObject filledButtonParents;

    IDictionary<SpaceFillButton, SpaceFilledButton> spaceFillPair;

    public int currentWordSetIndex = 0;

    private void Start()
    {
        spaceFillPair = new Dictionary<SpaceFillButton, SpaceFilledButton>();

        SpaceFilledButton[] filled = filledButtonParents.GetComponentsInChildren<SpaceFilledButton>();

        List<SpaceFillButton> fill = fillButtonParents.gameObject.GetComponentsInChildren<SpaceFillButton>().ToList();

        Debug.Log(fill.Count+" " +filled.Length);

        using (var fillButtons = fill.GetEnumerator())
        using (var filledButtons = filled.ToList().GetEnumerator())
        {
            while(filledButtons.MoveNext() &&fillButtons.MoveNext())
            {
                spaceFillPair.Add(fillButtons.Current, filledButtons.Current);
            }
        }
    }

    public void SetGameWordPack(Pack pack)
    {
        this.currentPack = pack;
    }

    public void DisamblePack()
    {
        wordSets = new Set(currentPack);
    }

    public void StartPage()
    {
        IDictionary<string, string> currentDic = wordSets.GetIndexOfDictionary(wordSets.currentIndex);

        SetCurrentPage(spaceFillPair,currentDic);
    }

    public void CompletedPage()
    {
        if (wordSets.IsNext())
        {
            StartPage();
        }
        else
        {
            FinishGame();
        }
    }

    public void FinishGame()
    {

    }

    public void SetCurrentPage(IDictionary<SpaceFillButton, SpaceFilledButton> spaceButtons, IDictionary<string,string> setOfPage)
    {
        using (var buttonPairs = spaceButtons.GetEnumerator())
        using (var wordPair = setOfPage.GetEnumerator())
        {
            if (buttonPairs.MoveNext())
            {
                buttonPairs.Current.Key.SetFillButton(wordPair.Current.Key);
                buttonPairs.Current.Value.SetFilledButton(wordPair.Current.Value);
            }
        } 
    }

    public void WordDroppedOnDescription(SpaceFillButton fill, SpaceFilledButton filled)
    {
        if (wordSets.IsCorrect(fill.wordText.text, filled.descriptionText.text))
        {
            MarkButtonPairAsCorrect(fill, filled);
        }
        else
        {
            MarkButtonParAsFalse(fill, filled);
        }
    }

    public void MarkButtonPairAsCorrect(SpaceFillButton fill, SpaceFilledButton filled)
    {
        fill.IsFill = true;
        filled.IsFilled = true;

        fill.MakeCorrectAnimation();
        filled.MakeCorrectAnimation();

        IncreaseScore();
    }

    public void MarkButtonParAsFalse(SpaceFillButton fill, SpaceFilledButton filled)
    {
        fill.MakeFalseAnimation();

        filled.MakeFalseAnimation();

        DecreaseScore();
    }

    public void IncreaseScore()
    {

    }

    public void DecreaseScore()
    {

    }
}

