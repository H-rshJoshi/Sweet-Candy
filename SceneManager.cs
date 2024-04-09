using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class restartgame : MonoBehaviour
{
    //restartButtons->>
    public void restart_level1()
    {
        SceneManager.LoadScene(1);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void restart_level2()
    {
        SceneManager.LoadScene(2);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void restart_level3()
    {
        SceneManager.LoadScene(3);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void restart_level4()
    {
        SceneManager.LoadScene(4);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void restart_level5()
    {
        SceneManager.LoadScene(5);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }

    //levels->> **NO NEED CAN BE DONE USING RESTART LEVEL TOO**
    public void Level1()
    {
        SceneManager.LoadScene(1);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void Level2()
    {
        SceneManager.LoadScene(2);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void Level3()
    {
        SceneManager.LoadScene(3);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void Level4()
    {
        SceneManager.LoadScene(4);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void Level5()
    {
        SceneManager.LoadScene(5);
        ScoreSystem.score = 0;
        Basket_movement.life = 3;
        Basket_movement.candy_touches_ground = 0;
    }
    public void Quitbutton()
    {
        //to exit agme
        Application.Quit();
    }
    public void ExitToMainMenu()
    {
        SceneManager.LoadScene(0);
    }
    public void AllLevels()
    {
        SceneManager.LoadScene(6);
    }
}
