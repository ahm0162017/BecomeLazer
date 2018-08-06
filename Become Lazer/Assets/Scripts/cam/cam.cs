using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cam : MonoBehaviour {
    public float high,speed,Ywallup,Ywalldown;

    public GameObject shooter,wall, LimitUp, LimitDown;
    bool once = false;
	// Use this for initialization
	void Start () {
        high = transform.position.y;//high allways changes when the lazer hits the walls 
        Ywallup   = wall.transform.position.y;
		Ywalldown = wall.transform.position.y;

    }
	
	// Update is called once per frame
	void Update () {

        // move the camera code 
        if (transform.position.y < high)
        {
            transform.Translate(0,speed*Time.deltaTime,0);
        }
        if (transform.position.y > high)
        {
            transform.Translate(0,- speed * Time.deltaTime, 0);

        }

        
        if (Mathf.Abs(transform.position.y - high) < 0.1f && once == true)
        {

            WallLimits();
            once = false;
        }

        if (Mathf.Abs(transform.position.y - high) > 0.1f )
        {
            once = true;
        }

        //wall instantiate code 
        if (transform.position.y > Ywallup)
        {
            Ywallup += 9.937f;
            Instantiate(wall, new Vector3(transform.position.x, Ywallup , 0.5f ), transform.rotation);
        }

		if (transform.position.y < Ywalldown)
		{
			Ywalldown -= 9.937f;
			Instantiate(wall, new Vector3(transform.position.x, Ywalldown , 0.5f ), transform.rotation);
		}


    }

    void WallLimits() {
        float X = shooter.transform.position.x;
        if (shooter.transform.position.x > 0) X += 0.93f; else X -= 1f;

        Instantiate(LimitUp  , new Vector3(X, high+5,0.2f), transform.rotation);
        Instantiate(LimitDown, new Vector3(X, high-5,0.2f), transform.rotation);

    }
}
