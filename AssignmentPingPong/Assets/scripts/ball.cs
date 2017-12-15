using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public float move = 30; //made public for easier tweaking

	// Use this for initialization
	void Start () {
        GetComponent<Rigidbody2D>().velocity = Vector2.right * move; 
	}
    float Hit(Vector2 ballPos, Vector2 paddlePos,
                float paddleHeight)
    {
        //if the return is :
        // || -1 <- the bottom of the paddle
        // ||
        // ||  0 <- the middle of the paddle
        // ||
        // ||  1 <- the top of the paddle
        return (ballPos.y - paddlePos.y) / paddleHeight;
    }
    //colition has the colission information if the ball enteracts with the paddle then...
    private void OnCollisionEnter2D(Collision2D collision)
    {
       //if enteracts with left paddle
       if (collision.gameObject.name == "paddleLeft")
        {
            float y = Hit(transform.position,collision.transform.position,collision.collider.bounds.size.y);

            //calaculate which way the ball is going
            Vector2 way = new Vector2(1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = way * move;
        }

        //if enteracts with right paddle
        if (collision.gameObject.name == "paddleRight")
        {
            float y = Hit(transform.position, collision.transform.position, collision.collider.bounds.size.y);

            //calaculate which way the ball is going
            Vector2 way = new Vector2(-1, y).normalized;

            GetComponent<Rigidbody2D>().velocity = way * move;
        }

        if(collision.gameObject.name == "wallLeft")
        {
            this.transform.position = Vector3.zero;
            this.GetComponent<Rigidbody2D>
            ScoreBoard.instance.Player1AddScore();
            StartCoroutine(PausePeriodAfterGoal());
        }
    }

    // Update is called once per frame
    void Update () {
		
	}
}
