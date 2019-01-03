using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeTexture : MonoBehaviour {
    public Texture texture1;
    public Texture texture2; 
	// Use this for initialization
	void Start () {
        GetComponent<Renderer>().material.mainTexture = texture1;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("c"))
        {
            transform.GetComponent<Renderer>().material.mainTexture = texture2;
        }
	}
}
