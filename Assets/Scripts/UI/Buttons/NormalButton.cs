using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using System;
using UnityEngine.UI;

public class NormalButton : MonoBehaviour,IPointerDownHandler,IPointerUpHandler
{
    public Color actualColor = Color.blue;
    public Color clickColor = Color.red;

    public Action OnNormalButtonClicked;  

    public void OnPointerDown(PointerEventData eventData)
    {
        GetComponent<Image>().color = clickColor;
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        GetComponent<Image>().color = actualColor;

        if (OnNormalButtonClicked != null)
        {
            OnNormalButtonClicked.Invoke();
        }
    }
}
