using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddlemov : MonoBehaviour {
    public float move = 30;
    

    public KeyCode moveUp;
    public KeyCode moveDown;

    // Use this for initialization
    void Start () {
		
	}
    
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyDown(moveUp))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, move, 0);
        }

        if (Input.GetKeyDown(moveDown))
        {
            GetComponent<Rigidbody2D>().velocity = new Vector3(0, -move, 0);
        }
        
	}

    private void FixedUpdate()
    {
      
        

    }
}
