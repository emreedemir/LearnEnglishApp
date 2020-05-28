using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecylerViewParent : MonoBehaviour
{
    public List<RectTransform> elements;

    public float verticalSpace = 10f;

    public void SetElements(List<RectTransform> elements)
    {
        this.elements = elements;
    }

    private void RecyleElements()
    {

    }
}
