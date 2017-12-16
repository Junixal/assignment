using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    public float move = 30; //made public for easier tweaking

    private Rigidbody2D BallRigid;
    

    


	// Use this for initialization
	void Start () {
        //GetComponent<Rigidbody2D>().velocity = Vector2.right * move;

        StartCoroutine(Pause());
        BallRigid = this.GetComponent<Rigidbody2D>();

        

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
    //colition has the colission information if the ball enteracts with then...
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
            this.transform.position = new Vector3(0,0,0);
            BallRigid.velocity = new Vector3(0, 0, 0);
            ScoreBoard.instance.Player2AddScore();
            StartCoroutine(Pause());
        }

        if (collision.gameObject.name == "wallRight")
        {
            this.transform.position = new Vector3(0, 0, 0);
            BallRigid.velocity = new Vector3(0, 0, 0);
            ScoreBoard.instance.Player1AddScore();
            StartCoroutine(Pause());
        }
    }

    void ResetBall()
    {
        this.transform.position = new Vector3(0,0,0);
        int DirectY = Random.Range(-1, 2);
        int DirectX = Random.Range(-1, 2);

        if(DirectX == 0)
        {
            DirectX = 1;
        }

        BallRigid.velocity = new Vector2(move * DirectX, move * DirectY);
    }

    IEnumerator Pause()
    {
        yield return new WaitForSeconds(2f);

        ResetBall();

    }

    // Update is called once per frame
    void Update () {
		
	}
    
}
