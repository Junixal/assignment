using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class obsticale : MonoBehaviour {
    float movespeed = 1f;
    // Use this for initialization
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        movespeed += (Time.deltaTime * 0.5f);
        

        transform.Rotate(0,0, movespeed);//rotates at the movespeed



    }
}