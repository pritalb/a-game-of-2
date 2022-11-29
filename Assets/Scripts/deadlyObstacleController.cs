using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class deadlyObstacleController : MonoBehaviour
{
    public GameController gameController;

    private void Awake()
    {
        gameController = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        gameController.loseGame();
    }
}
