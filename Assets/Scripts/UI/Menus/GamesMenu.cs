using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesMenu : MonoBehaviour
{
    public List<BaseGame> allGames;

    public GameCardView gameCardView;

    public Transform listViewParent;

    private void Start()
    {
        RenderGameCardViews();
    }

    public void RenderGameCardViews()
    {
        allGames.ForEach(delegate (BaseGame baseGame)
        {


            Debug.Log("Cad view olulşturuldu");
            GameCardView newGameCardView = Instantiate(gameCardView);

            newGameCardView.transform.SetParent(listViewParent);
        });
    }

    public void OnGameCardViewClicked(BaseGame baseGame)
    {
        Debug.Log("CardView clicked");
    }
}
