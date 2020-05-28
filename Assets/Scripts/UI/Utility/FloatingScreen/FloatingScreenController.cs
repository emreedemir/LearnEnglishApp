using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FloatingScreenController : MonoBehaviour
{
    public RectTransform floatedPositionGoAndCome;

    public RectTransform floatedPositionCenter;

    public RectTransform floatedPositionSubGoAndCome;

    public void FloatPanels(Transform floatingScreenGo, Transform floatingScreenCome,FloatType floatType)
    {
        floatingScreenCome.transform.position = floatedPositionSubGoAndCome.position;
        StartCoroutine(FloatCoroutine(floatingScreenGo, floatingScreenCome,floatType));
    }

    IEnumerator FloatCoroutine(Transform floatingScreenGo, Transform floatingScreenCome,FloatType type)
    {
        if (type == FloatType.sub)
        {
            iTween.MoveTo(floatingScreenGo.gameObject, floatedPositionGoAndCome.position, 1f);

            iTween.MoveTo(floatingScreenCome.gameObject, floatedPositionCenter.position, 1f);

            yield return new WaitForSeconds(1);
        }
        else
        {
            iTween.MoveTo(floatingScreenGo.gameObject, floatedPositionGoAndCome.position, 1f);

            iTween.MoveTo(floatingScreenCome.gameObject, floatedPositionCenter.position, 1f);

            yield return new WaitForSeconds(1);

        }       
    }
}
public enum FloatType
{
    sub,
    parent
}