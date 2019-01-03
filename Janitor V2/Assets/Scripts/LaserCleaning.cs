using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LaserCleaning : MonoBehaviour {

    Text Percent;
    bool first = true;
    int Percenatge = 20;
    // Use this for initialization
    void Start()
    {
        Percent = GetComponent<Text>();

    }

    // Update is called once per frame
    void Update()
    {


        if (Input.GetKeyDown("c"))
        {
            Percenatge += 3;
        }
        if (Input.GetKeyDown("e"))
        {
            Percenatge += 5;
        }
        Percent.text = Percenatge.ToString() + "%";

    }
}
