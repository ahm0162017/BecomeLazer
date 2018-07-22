using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {
    //public GameObject dt; // small part of the tail
    public GameObject cam;
    public GameObject HUD;
    public float speed ;

    void Start () {
        cam = GameObject.Find("MainCamera"); // cam = MainCamera Object
        HUD = GameObject.Find("HUD");

    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(new Vector2(speed * Time.deltaTime, 0));// move the lazer in x-axis 
        //Instantiate(dt, transform.position, transform.rotation); // for the tail 
        ChangeShooterPosition();//destroy the lazer & change the shooter position 

    }
    void ChangeShooterPosition() {

        if ((transform.position.x > 2.82f)) //when the lazer hits the walls
        {
            GameObject.Find("Pointer").transform.position = new Vector2(2.8f, transform.position.y); ;//find the shooter and move it to the location of the collision            
            var CamSc = cam.GetComponent("cam") as cam;
            CamSc.high = transform.position.y;
			Destroy (gameObject);
        }

        if ((transform.position.x < -2.82f)) //when the lazer hits the walls
        {
            gameObject.SetActive(false);//Destroy (gameObject);
            GameObject.Find("Pointer").transform.position = new Vector2(-2.8f, transform.position.y);//find the shooter and move it to the location of the collision
            var CamSc = cam.GetComponent("cam") as cam;
            CamSc.high = transform.position.y;

        }
    }

     void OnTriggerEnter2D(Collider2D Obstacle)
    {
        if (Obstacle.gameObject.tag == "Obstacle")
        {
            //print("you lose");
            var myHUD = HUD.GetComponent("HUD") as HUD;
            myHUD.state = "lose";
            Time.timeScale = 0f;

        }
    }




}
