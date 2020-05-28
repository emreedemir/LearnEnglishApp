using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    public MemorizeMenu memorizeMenu;

    public ReadMenu readMenu;

    public MyWordsMenu myWordsMenu;

    public GamesMenu gamesMenu;

    public NormalButton memorizeButton;

    public NormalButton readButton;

    public NormalButton myWordsButton;

    public NormalButton gamesButton;

    public FloatingScreenController floatingScreenController { get; private set; }

    private void Start()
    {
        floatingScreenController = FindObjectOfType<FloatingScreenController>();
        RenderButtons();
    }

    void RenderButtons()
    {
        memorizeButton.OnNormalButtonClicked += OpenMemorizeMenu;
        readButton.OnNormalButtonClicked += OpenReadMenu;
        myWordsButton.OnNormalButtonClicked += OpenMyWordsMenu;
        gamesButton.OnNormalButtonClicked += OpenGamesMenu;
    }

    public void OpenMemorizeMenu()
    {
        floatingScreenController.FloatPanels(this.transform, memorizeMenu.transform, FloatType.sub);
    }

    public void OpenReadMenu()
    {
        floatingScreenController.FloatPanels(this.transform, readMenu.transform, FloatType.sub);
    }

    public void OpenGamesMenu()
    {
        floatingScreenController.FloatPanels(this.transform, gamesMenu.transform, FloatType.sub);
    }

    public void OpenMyWordsMenu()
    {
        floatingScreenController.FloatPanels(this.transform, myWordsMenu.transform, FloatType.sub);
    }
}
