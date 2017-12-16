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
    public static int player2Score;

	// Use this for initialization
	void Start () {
        instance = this;
    }
	
	// Update is called once per frame
	void Update () {
		
	}

    public void Player1AddScore()
    {
        player1Score += 1;
        player1_text.text = player1Score.ToString();

        if (player1Score >= maxScore)
        {
            if (player1Score > player2Score)
            {
                SceneManager.LoadScene(0);
            }
        }

        if (player1Score >= maxScore)
        {
            if (player1Score == player2Score)
            {
                SceneManager.LoadScene(0);
            }
        }

    }

    public void Player2AddScore()
    {
        player2Score += 1;
        player2_text.text = player2Score.ToString();

        if (player2Score >= maxScore)
        {
            if (player2Score > player1Score)
            {
                SceneManager.LoadScene(0);
            }
        }

        if (player1Score >= maxScore)
        {
            if (player1Score == player2Score)
            {
                SceneManager.LoadScene(0);
            }
        }
    }
}
