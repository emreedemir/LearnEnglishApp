using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public List<BaseGame> games;

    public BaseGame currentGame;

    private void Start()
    {
        
    }

    public void InitiliazeGame(BaseGame baseGame)
    {
        currentGame = baseGame;
    }

}
