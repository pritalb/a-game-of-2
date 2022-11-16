using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class goalController : MonoBehaviour
{
    public BoxCollider2D target;
    public GameController gameController;
    public int goalNumber;

    private void Awake() {
        gameController = FindObjectOfType<GameController>();
    }

    private void OnTriggerEnter2D(Collider2D trigger)
    {
        if (trigger == target)
        {
            if (goalNumber == 1) {
                gameController.set_goal_1_to_true();
            } else {
                gameController.set_goal_2_to_true();
            }

            gameController.winGame();
        }
    }

    private void OnTriggerExit2D(Collider2D trigger)
    {
        if (goalNumber == 1)
        {
            gameController.set_goal_1_to_false();
        }
        else
        {
            gameController.set_goal_2_to_false();
        }
    }
}
