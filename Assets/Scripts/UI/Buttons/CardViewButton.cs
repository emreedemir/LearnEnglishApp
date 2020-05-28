using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class CardViewButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    public Pack wordPack { get; private set; }

    public Action<Pack> OnWordPackCardViewClicked;

    public Text packName;

    public Text description;

    public void SetCardViewButton(Pack pack)
    {
        this.wordPack = pack;

        SetView();
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.red;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        GetComponent<Image>().color = Color.blue;

        if (OnWordPackCardViewClicked != null)
        {
            OnWordPackCardViewClicked.Invoke(wordPack);
        }
    }

    public void SetAsOpen()
    {

    }

    public void SetAsClose()
    {

    }

    private void SetView()
    {
        packName.text = wordPack.packName;

        description.text = wordPack.packDescription;
    }
}
