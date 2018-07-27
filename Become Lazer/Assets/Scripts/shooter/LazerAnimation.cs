using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerAnimation : MonoBehaviour {
    public float Speed; 
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(Speed * Time.deltaTime, 0));
	}
}
