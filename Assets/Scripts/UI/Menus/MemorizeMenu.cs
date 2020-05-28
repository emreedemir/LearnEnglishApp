using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemorizeMenu : MonoBehaviour
{
    public CardViewButton memorizeCardViewButtonPrefab;

    public Transform listViewParent;

    private void Start()
    {
        List<Pack> allPacks = FindObjectOfType<ResourcesController>().GetAllWordMemorizePack();

        allPacks.ForEach(delegate(Pack pack)
        {
            CardViewButton newCardViewButton = Instantiate(memorizeCardViewButtonPrefab);

            newCardViewButton.SetCardViewButton(pack);

            newCardViewButton.transform.SetParent(listViewParent,false);

            newCardViewButton.OnWordPackCardViewClicked += OnCardViewPackClicked;

        });
    }

    public void OnCardViewPackClicked(Pack pack)
    {
        Debug.Log("Yönlendir buradan kelime ezberleme ekranına");
    }
}
