using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Level3ScoreSystem : MonoBehaviour {

    public static Level3ScoreSystem instance;

    public Text player1_text;
    public Text player2_text;
    public int maxScore = 3;

    public static int player1Score;
    public static int player2Score;//static so the score will be saved trough out the all the scenes

	// Use this for initialization
	void Start () {
        instance = this;
        player1Score = ScoreBoard.player1Score;//to load the score from the previous script due to being another script
        player2Score = ScoreBoard.player2Score;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Player1AddScore()
    {

        player1Score += 1;//adds 1
        player1_text.text = player1Score.ToString(); // changes the player 1 score to the player 1 score (changes it to string)

        if (player1Score >= maxScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1); //when player1 reaches the max level load that scene


        }
    }

    public void Player2AddScore()
    {
        player2Score += 1;
        player2_text.text = player2Score.ToString();

        if (player2Score >= maxScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);//when player2 reaches the max level load that scene

        }
    }
}
