using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class SpaceFillButton : MonoBehaviour,IBeginDragHandler,IDragHandler,IEndDragHandler
{
    public Text wordText;

    Vector3 realTransform;

    public bool IsFill;

    void Start()
    {
        realTransform = GetComponent<RectTransform>().position;
    }
    public void SetFillButton(string word)
    {
        wordText.text = word;
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }
   
    public void OnDrag(PointerEventData eventData)
    {
        transform.position = eventData.position;   
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        StartCoroutine(StartPositionCoroutine());
    }

    IEnumerator StartPositionCoroutine()
    {
        iTween.MoveTo(this.gameObject,realTransform,1);
        yield return new WaitForSeconds(0.4f);
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }

    public void MakeCorrectAnimation()
    {
        throw new NotImplementedException();
    }

    public void MakeFalseAnimation()
    {
        throw new NotImplementedException();
    }
}
