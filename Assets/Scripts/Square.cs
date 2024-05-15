using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class SquareBox : MonoBehaviour
{
    private int enemyCollisionCount = 0;
    

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Enemy")
        {
            Destroy(other.gameObject);
            enemyCollisionCount++;

            if (enemyCollisionCount >= 3)
            {
                // Stop the game (pause time, show game-over screen, etc.)
                Time.timeScale = 0f; // Pauses the game
                Debug.Log("Game Over!");
                Manager.instance.gameover.SetActive(true);
                
            }
        }
    }
}
