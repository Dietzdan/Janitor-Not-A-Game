using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani2 : MonoBehaviour {
    bool pause = false;
    Animation animation;
	// Use this for initialization
	void Start () {
       
      
	}
	
	// Update is called once per frame
	void Update () {
       if(Input.GetKeyDown("g"))
        {
            Destroy(this.gameObject);
        }
    }
}
