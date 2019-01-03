using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour {
    int minutes;
    int seconds;
    Text time;
    string Formatedtime;
    public static float timer = 300.0f;
	// Use this for initialization
	void Start () {

        time = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timer -= Time.deltaTime;
        int minutes = Mathf.FloorToInt(timer / 60f);
        int seconds = Mathf.FloorToInt(timer - minutes * 60);
        Formatedtime = string.Format("{0:00}:{1:00}", minutes, seconds);
        time.text = Formatedtime;
	}
}
