using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class HUD : MonoBehaviour
{   
    public string level;
    public string level_;
    public Text score;
    public Text finish;

    public Button Next;
    public Button Restart;
    public Button menu;

    public GameObject res;
    public GameObject playAgain;
    public GameObject backMenu;

    public GameObject player;

    private Scene currentScene;

    // Update is called once per frame
    void Update()
    {
        score.text = "Score:" + Game_Manage.score;
    }

    public void GameOver()
    {
        Player pl = player.GetComponent<Player>();
        pl.rb.constraints = RigidbodyConstraints2D.FreezePosition;

        Animator game_over = GetComponent<Animator>();
        game_over.SetTrigger("Game Over");

        backMenu.SetActive(true);
        res.SetActive(true);
    }

    public void RestartGame()
    {
        SceneManager.LoadScene(level_);
        Player.balance = 50;
        Game_Manage.score = 0;
    }

    public void GameWin()
    {

        Animator game_win = GetComponent<Animator>();
        game_win.SetTrigger("Game Win");

        if (getCurrentSceneName() == "Level_1")
        {
            finish.text = "Next Round";
        }
        else 
        {
            finish.text = "You Win!";
        }

        playAgain.SetActive(true);
        backMenu.SetActive(true);
    }

    public void Next_Level()
    {

        if (getCurrentSceneName().Equals("Level_2"))
        {
            Game_Manage.score = 0;
        }

        SceneManager.LoadScene(level);
    }

    public void backToMenu()
    {
        SceneManager.LoadScene("Menu");
    }

    string getCurrentSceneName()
    {
        // Create a temporary reference to the current scene.
        currentScene = SceneManager.GetActiveScene();

        // Retrieve the name of this scene.
        string sceneName = currentScene.name;

        return sceneName;
    }
}
