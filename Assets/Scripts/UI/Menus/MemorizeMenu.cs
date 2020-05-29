using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MemorizeMenu : MonoBehaviour
{
    public CardViewButton memorizeCardViewButtonPrefab;

    public Transform listViewParent;

    public FloatingScreenController floatingScreenController;

    SpaceFillGame spaceFillGame;

    public NormalButton backMenuButton;

    private void Start()
    {
        List<Pack> allPacks = FindObjectOfType<ResourcesController>().GetAllWordMemorizePack();

        allPacks.ForEach(delegate(Pack pack)
        {
            CardViewButton newCardViewButton = Instantiate(memorizeCardViewButtonPrefab);

            newCardViewButton.SetCardViewButton(pack);

            newCardViewButton.transform.SetParent(listViewParent,false);

            newCardViewButton.OnWordPackCardViewClicked += OnCardViewPackClicked;

        });

      //  backMenuButton.OnNormalButtonClicked += BackToMainMenu;
    }

    private void BackToMainMenu()
    {


    }

    public void OnCardViewPackClicked(Pack pack)
    {
        spaceFillGame.gameObject.SetActive(true);
        floatingScreenController.FloatPanels(this.transform, spaceFillGame.transform,FloatType.sub);
    }
}
