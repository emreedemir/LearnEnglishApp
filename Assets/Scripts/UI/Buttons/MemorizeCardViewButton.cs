using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MemorizeCardViewButton : MonoBehaviour
{
    public Text wordText;
    public Text descriptionText;

    public void Set(string word,string description)
    {
        wordText.text = word;
        descriptionText.text = description;
    }
}
