using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ScoreBoard : MonoBehaviour {

    public static ScoreBoard instance;

    public Text player1_text;
    public Text player2_text;
    public int maxScore = 3;

    public int player1Score;
    public int player2Score;

    // Use this for initialization
    void Start () {
        instance = this;

        player1Score = 0;
        player2Score = 0;

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Player1AddScore()
    {
        player1Score += 1;
        player1_text.text = player1Score.ToString();

        if(player1Score > maxScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }

    public void Player2AddScore()
    {
        player2Score += 1;
        player2_text.text = player2Score.ToString();

        if (player2Score > maxScore)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
}
