using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Lazer : MonoBehaviour {

    public GameObject cam, HUD, Effect1;
    public float speed ;
    //public bool SuperLazer;

    void Start () {
        cam = GameObject.Find("MainCamera"); // cam = MainCamera Object
        HUD = GameObject.Find("HUD");

    }


    void Update()
    {

        transform.Translate(new Vector2(speed * Time.deltaTime, 0));// move the lazer in x-axis 
        ChangeShooterPosition();//destroy the lazer & change the shooter position 

    }
    void ChangeShooterPosition() {

        if ((transform.position.x > 2.82f)) //when the lazer hits the walls
        {
            GameObject.Find("Pointer").transform.position = new Vector2(2.8f, transform.position.y); ;//find the shooter and move it to the location of the collision            
            var CamSc = cam.GetComponent("cam") as cam;
            CamSc.high = transform.position.y;
			Destroy (gameObject);
            Instantiate(Effect1, new Vector3( 8.2f, transform.position.y,2),transform.rotation);
        }

        if ((transform.position.x < -2.82f)) //when the lazer hits the walls
        {
            //gameObject.SetActive(false);//Destroy (gameObject);
            GameObject.Find("Pointer").transform.position = new Vector2(-2.8f, transform.position.y);//find the shooter and move it to the location of the collision
            var CamSc = cam.GetComponent("cam") as cam;
            CamSc.high = transform.position.y;
            Destroy(gameObject);
            Instantiate(Effect1, new Vector3(-8.2f, transform.position.y,2), transform.rotation);
        }
    }






     void OnTriggerEnter2D(Collider2D Block)
    {
        if (Block.gameObject.tag == "Obstacle")
        {

            var super = HUD.GetComponent("Abilities") as Abilities;
            if (!super.SuperLazer)
            {
                var myHUD = HUD.GetComponent("HUD") as HUD;
                myHUD.state = "lose";
            }

        }
    }




}
