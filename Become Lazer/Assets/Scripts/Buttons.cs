using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buttons : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void retry()
    {
        Application.LoadLevel(1);
        Time.timeScale = 1;
    }

    public void exit()
    {
        Application.Quit();
        //Time.timeScale = 1;
    }
}
