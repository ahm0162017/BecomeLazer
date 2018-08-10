using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using EZCameraShake;

public class Lazer : MonoBehaviour {

    public GameObject cam, HUD, LoseEffect;
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
            GameObject.Destroy(gameObject);
            var CamSc = cam.GetComponent("cam") as cam;
            CamSc.high = transform.position.y;
        }

        if ((transform.position.x < -2.82f)) //when the lazer hits the walls
        {
            //gameObject.SetActive(false);//Destroy (gameObject);
            GameObject.Find("Pointer").transform.position = new Vector2(-2.8f, transform.position.y);//find the shooter and move it to the location of the collision
            GameObject.Destroy(gameObject);
            var CamSc = cam.GetComponent("cam") as cam;
            CamSc.high = transform.position.y;
        }
    }






     void OnTriggerEnter2D(Collider2D Block)
    {
        if (Block.gameObject.tag == "Obstacle")
        {
            CameraShaker.Instance.ShakeOnce(4, 4f, 0.1f, 0.1f);

            var super = HUD.GetComponent("Abilities") as Abilities;
            if (!super.SuperLazer)
            {
                var myHUD = HUD.GetComponent("HUD") as HUD;
                myHUD.state = "lose";
                Instantiate(LoseEffect,new Vector3(transform.position.x , transform.position.y ,-5),transform.rotation);
                speed = 0;

            }

        }

        if (Block.gameObject.tag == "Slow")
        {
            var myHUD = HUD.GetComponent("Abilities") as Abilities;
            myHUD.SlowMotionAbility = true;
            CameraShaker.Instance.ShakeOnce(2, 4f, 0.1f, 0.1f);

        }

        if (Block.gameObject.tag == "Super")
        {
            var myHUD = HUD.GetComponent("Abilities") as Abilities;
            myHUD.SuperLazer = true;
            CameraShaker.Instance.ShakeOnce(2, 4f, 0.1f, 0.1f);

        }
    }




}
