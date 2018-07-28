using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LazerAnimation : MonoBehaviour {
    public float Speed;
     GameObject cam;
	// Use this for initialization
	void Start () {
        cam = GameObject.Find("MainCamera");
	}
	
	// Update is called once per frame
	void Update () {

        transform.Translate(new Vector2(Speed * Time.deltaTime, 0));
        if (Vector2.Distance(transform.position, cam.transform.position) > 100)
            Destroy(gameObject);
	}
}
