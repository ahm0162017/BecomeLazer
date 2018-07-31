using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseEffect : MonoBehaviour
{
    Vector2 Scale;
    public float Speed;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scale = transform.localScale;


        if (Scale.y < 40)
        {
            Scale.y += Speed;//* Time.deltaTime;
            Scale.x += Speed;//* Time.deltaTime;
            transform.localScale = Scale;
        } //else
          //Destroy (gameObject);
    }
}