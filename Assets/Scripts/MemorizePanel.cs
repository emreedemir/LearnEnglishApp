using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemorizePanel : MonoBehaviour
{
    public NormalButton backButton;

    public NormalButton saveButton;

    public NormalButton nextButton;

    public Pack currentWordPack;

    public List<MemorizeCardViewButton> cardViewButtons;

    List<Unit> allUnits;

    int index = 0;

    public RectTransform come;

    public RectTransform current;

    public RectTransform go;

    public void Initiliaze(Pack pack)
    {
        currentWordPack = pack;

        backButton.OnNormalButtonClicked += OnBackButttonPressed;
        saveButton.OnNormalButtonClicked += OnSaveButtonPressed;
        nextButton.OnNormalButtonClicked += OnNextButtonPressed;

        allUnits = pack.units;
    }

    void StartToMemorize()
    {
        MemorizeCardViewButton memorizeCardViewButton = cardViewButtons[0];

        memorizeCardViewButton.Set(allUnits[index].word,allUnits[index].description);

       
    }

    public void OnBackButttonPressed()
    {

    }

    public void OnSaveButtonPressed()
    {

    }

    public void SwipeCardNext(MemorizeCardViewButton memorizeCardViewButtonCome,MemorizeCardViewButton memorizeCardViewButtonGo)
    {
        memorizeCardViewButtonCome.transform.position = come.position;

        StartCoroutine(SwipeCoroutine(memorizeCardViewButtonGo.transform,memorizeCardViewButtonCome.transform,SwipeType.Left));

    }

    private IEnumerator SwipeCoroutine(Transform goTransform,Transform comeTransform,SwipeType swipeType)
    {
        if (SwipeType.Left == swipeType)
        {
            iTween.MoveTo(goTransform.gameObject, go.position, 1);
            iTween.MoveTo(comeTransform.gameObject, come.position, 1);

            yield return new WaitUntil(()=>goTransform.position ==go.position);
        }
        else if (SwipeType.Right == swipeType)
        {
            iTween.MoveTo(goTransform.gameObject, come.position, 1);
            iTween.MoveTo(comeTransform.gameObject, go.position, 1);

            yield return new WaitUntil(() => goTransform.position == come.position);
        }

        yield return new WaitForSeconds(1f);
    }

    public void SwipeCardBack()
    {

    }

    public void OnNextButtonPressed()
    {

    }
}

public enum SwipeType
{
    None=0,
    Left=1,
    Right=2
}