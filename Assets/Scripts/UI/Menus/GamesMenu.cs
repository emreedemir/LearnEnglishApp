using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GamesMenu : MonoBehaviour
{
    public List<BaseGame> allGames;

    public GameCardView gameCardView;

    public Transform listViewParent;

    public GameController gameController;

    public FloatingScreenController floatingScreenController;

    private void Start()
    {
        gameController = FindObjectOfType<GameController>();
        floatingScreenController = FindObjectOfType<FloatingScreenController>();
        RenderGameCardViews();
    }

    public void RenderGameCardViews()
    {
        allGames.ForEach(delegate (BaseGame baseGame)
        {

            Debug.Log("Cad view olulşturuldu");
            GameCardView newGameCardView = Instantiate(gameCardView);

            newGameCardView.SetGameCardView(baseGame);

            newGameCardView.transform.SetParent(listViewParent);

            newGameCardView.OnCardViewClicked += OnGameCardViewClicked;
        });
    }

    public void OnGameCardViewClicked(BaseGame baseGame)
    {
        gameController.InitiliazeGame(baseGame);

        if (floatingScreenController != null)
            floatingScreenController.FloatPanels(this.transform, baseGame.transform, FloatType.sub);
        else
            Debug.Log("Floating SCreen cant be found");
    }
}
