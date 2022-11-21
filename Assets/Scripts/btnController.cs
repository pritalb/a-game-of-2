using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class btnController : MonoBehaviour
{
    private GameController gameController;
    public int levelNumber;

    // Start is called before the first frame update
    private void Awake()
    {
        gameController = GameObject.FindObjectOfType<GameController>();
        Button btn = gameObject.GetComponent<Button>();
        btn.onClick.AddListener(() => gameController.loadLevel(levelNumber));
    }
}
