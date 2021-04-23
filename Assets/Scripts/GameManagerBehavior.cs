using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public delegate void GameEvent();

public class GameManagerBehavior : MonoBehaviour
{
    //Bool to tell wether the game should end or not
    private static bool _gameOver = false;
    public static GameEvent OnGameOver;

    //Reference to the player's health
    public HealthBehavior _playerHealth;
    //Reference to the gameover overlay
    public GameObject _gameOverScreen;

    public static bool GameOver
    {
        get
        {
            return _gameOver;
        }
    }

    public void RestartGame()
    {
        //Returns to how the scene was at start
        SceneManager.LoadScene(0);
    }

    public void EndGame()
    {
        //Closes the application
        Application.Quit();
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //Sets game over to be the player's health less than or equal to 0
        _gameOver = _playerHealth.Health <= 0;
        //Sets the gameOver overlay to be visible
        _gameOverScreen.SetActive(_gameOver);
    }
}
