using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLimit : MonoBehaviour {
    public float speed,originY,originX;
     GameObject HUD;
    public GameObject LoseEffect ;
	// Use this for initialization
	void Start () {
        originY = transform.position.y;
        originX = transform.position.x;

        HUD = GameObject.Find("HUD");

    }
	
	// Update is called once per frame
	void Update () {
        if (Mathf.Abs(transform.position.y - originY) < 5)
            transform.Translate(new Vector2(0, speed * Time.deltaTime));
        else
            OUT();

        if (Mathf.Abs(transform.position.x )>4) GameObject.Destroy(gameObject);

    }

    private void OnTriggerEnter2D(Collider2D pointer)
    {
        if (pointer.gameObject.tag == "Pointer")
        {
            var myHUD = HUD.GetComponent("HUD") as HUD;
            myHUD.state = "lose";
            Instantiate(LoseEffect, new Vector3(transform.position.x, transform.position.y, -5), transform.rotation);

        }
    }
    void OUT() {
        if (originX > 0)
        {
            transform.Translate(new Vector2(  0.3f * Time.deltaTime,0));
        }

        if (originX < 0)
        {
            transform.Translate(new Vector2(-0.3f * Time.deltaTime,0));
        }

    }
}
