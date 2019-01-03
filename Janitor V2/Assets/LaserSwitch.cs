using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaserSwitch : MonoBehaviour {
    bool Off = true;
    LineRenderer render;
   
	// Use this for initialization
	void Start () {
        render = GetComponent<LineRenderer>();
        render.enabled = false;
    }
	
	// Update is called once per frame
	void Update () {
		if(Input.GetKeyDown("e"))
        {
            if (Off == false)
            {
                render.enabled = false;
                Off = true;
            }
            else if(Off == true)
            {
                render.enabled = true;
                Off = false;
            }
        }
	}
}
