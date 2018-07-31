using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WallLimit : MonoBehaviour {
    public float speed,origin;
     GameObject HUD;
    public GameObject LoseEffect ;
	// Use this for initialization
	void Start () {
        origin = transform.position.y;
        HUD = GameObject.Find("HUD");

    }
	
	// Update is called once per frame
	void Update () {
        transform.Translate(new Vector2(0,speed*Time.deltaTime));
        if (Mathf.Abs(transform.position.y - origin) > 5) Destroy(gameObject);
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
}
