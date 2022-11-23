using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;

public class GameController : MonoBehaviour
{
    public int next_level;
    public TMP_Text win_text;

    private bool goal_1_reached = false;
    private bool goal_2_reached = false;

    public void set_goal_1_to_true() {
        goal_1_reached = true;
    }

    public void set_goal_1_to_false()
    {
        goal_1_reached = false;
    }

    public void set_goal_2_to_true()
    {
        goal_2_reached = true;
    }

    public void set_goal_2_to_false()
    {
        goal_2_reached = false;
    }

    public bool get_goal_1_reached() {
        return goal_1_reached;
    }

    public bool get_goal_2_reached()
    {
        return goal_1_reached;
    }

    public void loadLevel(int levelNumber)
    {
        SceneManager.LoadScene(levelNumber);
    }

    IEnumerator loadLevelAfterDelay(int delay)
    {
        //Debug.Log("coroutine start");
        yield return new WaitForSeconds(delay);
        loadLevel(next_level);
        //Debug.Log("coroutine ended");
    }
    public void winGame()
    {
        if (goal_1_reached && goal_2_reached)
        {
            Debug.Log("win");
            win_text.gameObject.SetActive(true);
            StartCoroutine(loadLevelAfterDelay(2));
        }
    }
}
