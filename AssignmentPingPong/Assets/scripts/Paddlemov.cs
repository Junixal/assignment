using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlemov : MonoBehaviour {
    public float move = 5.0f;
    

    public KeyCode moveUp;
    public KeyCode moveDown;

    // Use this for initialization
    void Start () {
		
	}
    
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKey(moveUp))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0, move, 0);
            transform.Translate(0f, move * Time.deltaTime, 0f);
        }

        if (Input.GetKey(moveDown))
        {
            //GetComponent<Rigidbody2D>().velocity = new Vector3(0, -move, 0);
             transform.Translate(0f, -move * Time.deltaTime, 0f);
        }
        
	}

    private void FixedUpdate()
    {
      
        

    }
}
