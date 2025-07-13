using System.Collections;
using System.Collections.Generic;

using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro; 


public class NewBehaviourScript : MonoBehaviour


{
    public TextMeshProUGUI SCORE;
    public TextMeshProUGUI lives;
    public int level = 0;
    public int score = 0;
    public int lifes = 3;
    public int count = 20;
    public int wins = 0;
    public int randomNumber = 0;
    

    private void Awake()
    {
        DontDestroyOnLoad(this.gameObject);


    }
    private void Start()
    {
        // get number between 1 and 2
        randomNumber = Random.Range(1, 3);
        SCORE.text = " ";
        lives.text = "";

        Newgame();
    }
    public void Newgame()
    {
        this.lifes = 3;
        this.score = 0;
        this.count = 20;
        this.wins = 0;

        loadlevel(randomNumber);

    }

    private void loadlevel( int level)
    {
        this.level = level;
        SceneManager.LoadScene("Level" + level.ToString());
    }

    public void addpoints(int points)
    {
        this.score += points;
        SCORE.text = "Score: " + this.score.ToString();

    }
    public void doublepoints()
    {
        this.score *= 2;
        SCORE.text = "Score: " + this.score.ToString();
    }
    public void extraLife()
    {
        this.lifes++;
        // Update the UI or any other necessary components to reflect the new life count
        lives.text = "Lives: " + this.lifes.ToString();

    }
    public void loseLife()
    {
        this.lifes--;
        // Update the UI or any other necessary components to reflect the new life count
        lives.text = "Lives: " + this.lifes.ToString();
        if (this.lifes <= 0)
        {
            // Handle game over logic here, such as showing a game over screen or restarting the game
           // load game over scene
           lives.text = "";
            SceneManager.LoadScene("gameover");
        }
    }

    public void bricksleft()
    {
        count--;
        if (count <= 0)
        {
            wins++;
            // Load the next level

            if (randomNumber == 1 && wins != 2)
            {
                count = 20; // Reset count for the next level
                loadlevel(2);
            }
            else if (randomNumber == 2 && wins != 2)
            {
                count = 20; // Reset count for the next level
                loadlevel(1);
            }
            else if (wins == 2)
            {
                // Load the win scene

                SCORE.text = "you win! you scored: " + this.score.ToString();
                SceneManager.LoadScene("Gameover");
            }

        }
    }



}
