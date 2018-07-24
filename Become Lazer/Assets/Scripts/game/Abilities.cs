using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour {

    public bool SlowMotionAbility;
    public bool sl = false, SuperLazer;

    void Start() {

    }


    void Update() {
       // if (sl)  else Time.timeScale = 1; // controling the time scale be sl



    }

    void disSlow() { SlowMotionAbility = false; } // disable slow motion 

    public void SlowMotionOn() {
        if (SlowMotionAbility)
        {
            Time.timeScale = 0.5f;

            Invoke("disSlow", 7f); // after 7 seconds disable slow motion by calling disslow function 
        }
    }

    public void SlowMotionOff()
    {
        

            Time.timeScale = 1f;


    }

    public void SuperLazerOn() {

    }


}
