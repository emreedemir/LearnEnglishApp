using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class SpaceFilledButton : MonoBehaviour,IDropHandler
{
    public Action<SpaceFillButton,SpaceFilledButton> OnWordDragged;

    public Text descriptionText;

    public void SetFilledButton(string description)
    {
        descriptionText.text = description;

    }

    public void OnDrop(PointerEventData eventData)
    {
        if (OnWordDragged != null)
        {
            OnWordDragged.Invoke(eventData.pointerDrag.gameObject.GetComponent<SpaceFillButton>(),this);
        } 
    }
}
