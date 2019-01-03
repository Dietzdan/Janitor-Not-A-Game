using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ani : MonoBehaviour {
    Animation animation;
    bool pause = false;
	// Use this for initialization
	void Start () {
        animation = GetComponent<Animation>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        if (Input.GetKeyDown("p"))
        {
            if (pause == false)
            {
                print("Pause on");
                animation.enabled = false;
                pause = true;
            }
            else if (pause == true)
            {
                print("Pause off");
                animation.enabled = true;
                pause = false;
            }
        }
            if (Input.GetKeyDown("e"))
        {
            animation.PlayQueued("PA_WarriorCollapse_Clip", QueueMode.PlayNow);
            animation.PlayQueued("PA_WarriorRecover_Clip", QueueMode.CompleteOthers);
            animation.PlayQueued("PA_WarriorIdle_Clip", QueueMode.CompleteOthers);
            animation.PlayQueued("PA_WarriorAttack_Clip", QueueMode.CompleteOthers);
        }



    }
}
