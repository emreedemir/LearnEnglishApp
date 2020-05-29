using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System;
using UnityEngine.EventSystems;
//Jenerik class a çevir cardView ları
public class GameCardView : MonoBehaviour,IPointerClickHandler
{
    public Text gameNameTextView;

    public Text gameDescriptionTextView;

    public Action<BaseGame> OnCardViewClicked;

    private BaseGame game;

    public void SetGameCardView(BaseGame baseGame)
    {
        game = baseGame;

        gameNameTextView.text = baseGame.gameName;

        gameDescriptionTextView.text = baseGame.gameDescription;
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (OnCardViewClicked != null)
        {
            OnCardViewClicked.Invoke(game);
        }
    }
}
