using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour {
    public float speed = 5.0f;
    CapsuleCollider character;

	// Use this for initialization
	void Start () {
        Cursor.lockState = CursorLockMode.Locked;
        character = GetComponent<CapsuleCollider>();
	}
	
	// Update is called once per frame
	void Update () {

        float translation = Input.GetAxis("Vertical") * speed;
        float straffe = Input.GetAxis("Horizontal") * speed;
        translation *= Time.deltaTime;
        straffe *= Time.deltaTime;

        transform.Translate(straffe, 0, translation);

        if (Input.GetKeyDown("escape"))
        {
            Cursor.lockState = CursorLockMode.None;
        }
        if(Input.GetKeyDown("left shift"))
        {
            speed = 10f;
        }
        if(Input.GetKeyUp("left shift"))
        {
            speed = 5f;
        }
        if(Input.GetKeyDown(KeyCode.LeftControl))
        {
            speed = 3f;
            character.height = 1.0f;
            
        }
        if(Input.GetKeyUp(KeyCode.LeftControl))
        {
            speed = 5f;
            character.height = 2.0f;
        }

	}
}
