using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exit : MonoBehaviour {

    void OnMouseDown()
    {
        transform.localScale *= 0.9F;
    }

    private void OnMouseUp()
    {
        Application.Quit();
    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
