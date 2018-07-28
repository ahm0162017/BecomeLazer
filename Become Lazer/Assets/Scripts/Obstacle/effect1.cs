using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class effect1 : MonoBehaviour {
    public float speed,X;
	// Use this for initialization
	void Start () {
        X = transform.position.x;
	}
	
	// Update is called once per frame
	void Update () {
        if(X > 0) transform.Translate(-speed * Time.deltaTime, 0, 0);
        if(X < 0) transform.Translate( speed * Time.deltaTime, 0, 0);
        if (Mathf.Abs(transform.position.x) < 3.85f) Destroy(gameObject);
	}
}
