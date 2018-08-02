using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Abilities : MonoBehaviour {

    public bool SlowMotionAbility;
    public bool  SuperLazer;

    void Start() {

    }


    void Update() {
        if (SlowMotionAbility)
        {
            Invoke("disSlow", 7f); // after 7 seconds disable slow motion by calling disslow function 

        }

        if (SuperLazer)
        {
            Invoke("disSuper", 7f); // after 7 seconds disable slow motion by calling disslow function 

        }
    }

    void disSlow() { SlowMotionAbility = false; } // disable slow motion 
    void disSuper() { SuperLazer = false; } // disable super lazer

    public void SlowMotionOn() {
        if (SlowMotionAbility)
        {
            Time.timeScale = 0.5f;

        }
    }

    public void SlowMotionOff()
    {
        

            Time.timeScale = 1f;


    }

    public void SuperLazerOn() {

    }


}
