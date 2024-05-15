using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;  // Required for UI
using TMPro;


public class Manager : MonoBehaviour
{
    public static Manager instance;// one script variable define in other variable
    public int Score;
    public int HighScore; // Add a variable to store the high score
    public TextMeshProUGUI scoreText;  // UI Text component for score
    public TextMeshProUGUI highScoreText;  // UI Text component for high score
    public GameObject player;
    public GameObject gameover;
    void Start()
    {
        gameover.SetActive(false);
        Score = 0; // Reset the current score to 0 at the start of the game
        Load();
        scoreText.text = "Score: " + Score;
        highScoreText.text = "High Score: " + HighScore;
    }
    private void Awake()
    {
          if(instance == null)
        { instance = this; }
    }
    // Update is called once per frame
    void Update()
    {
        if (Score > HighScore) // Check if the current score is higher than the high score
        {
            HighScore = Score; // If so, update the high score
            Save(); // And save the new high score
        }
        scoreText.text = "Score: " + Score;
        highScoreText.text = "High Score: " + HighScore;
    }

    public void Save()
    {
        PlayerPrefs.SetInt("HighScore", HighScore); // Save the high score, not the current score
    }

    public void Load()
    {
        HighScore = PlayerPrefs.GetInt("HighScore", 0); // Load the high score, not the current score
    }
    public void showGameover()
    {
        gameover.SetActive(true);
    }
}
