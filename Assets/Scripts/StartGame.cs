using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{

    public Button startGame;
    public Button setting;
    public Button exit;
    public string nextScene;

    void Start()
    {
        Game_Manage.score = 0;
    }
    

    //Game start
    public void gameBegin()
    {
        SceneManager.LoadScene(nextScene);
        Player.balance = 50;
    }

    //Setting
    public void goSetting()
    {

    }

    //Exit
    public void exitGame()
    {
        Application.Quit();
    }

}
