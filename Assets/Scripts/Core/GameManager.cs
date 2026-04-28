using UnityEngine;


public class GameManager : MonoBehaviour
{
    public static GameManager Instance;

    public GameState currentState;

  

    void Awake()
    {
        Instance = this;
    }

    void Start()
    {
        currentState = GameState.Playing;
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (currentState == GameState.Playing)
                PauseGame();
            else if (currentState == GameState.Paused)
                PlayGame();
        }
        
    }
    
     public void PlayGame()
    {
        Debug.Log("game resumed");
        Time.timeScale = 1f;
        currentState = GameState.Playing;
    }
   
    public void PauseGame()
    {
        Debug.Log("game paused");
        Time.timeScale = 0f;
        currentState = GameState.Paused;
    }

    public void GameOver()
    {
        Debug.Log("Game Over");
        Time.timeScale = 0f;
        currentState = GameState.GameOver;

    }



    

    
}