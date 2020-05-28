using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class SwipeScreen : MonoBehaviour,IBeginDragHandler,IEndDragHandler,IDragHandler
{
    public float touchTime = 0;

    public Vector2 deltaPosition = new Vector2(0,0);

    public void OnBeginDrag(PointerEventData eventData)
    {
        deltaPosition = new Vector2(0, 0);
    }

    public void OnDrag(PointerEventData eventData)
    {
        deltaPosition += eventData.delta;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (deltaPosition.x < 100)
        {
            Debug.Log("Sayfayı sağa çevir");
        }
        else if (deltaPosition.x > -100)
        {
            Debug.Log("Sayfayı sola çevir");
        }
    }
}
