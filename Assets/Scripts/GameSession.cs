using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using TMPro;

public class GameSession : MonoBehaviour
{
    //[SerializeField] TextMeshProUGUI scoreText;
    [SerializeField] int pointsPerEnemyDestroyed = 1;
    [SerializeField] int score = 0;
    [SerializeField] [Range(0f, 10f)] float gameSpeed = 1f;

    private void Awake()
    {
        SetUpSingleton();
    }

    private void SetUpSingleton()
    {
        int numberGameSessions = FindObjectsOfType<GameSession>().Length;
        if (numberGameSessions > 1)
        {
            Destroy(gameObject);
        }
        else
        {
            DontDestroyOnLoad(gameObject);
        }
    }


  
    void Update()
    {
        Time.timeScale = gameSpeed;
    }


    public int GetScore()
    {
        return score;
    }

    public void AddToScore(int scoreToAdd)
    {
        score += scoreToAdd;
        //scoreText.text = score.ToString();

    }

    public void ResetGame()
    {
        Destroy(gameObject);
    }

   

}
