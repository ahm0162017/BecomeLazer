using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseEffect : MonoBehaviour
{
    Vector2 Scale;
    public float Speed,alpha = 0.5f,Range ;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scale = transform.localScale;


        if (Scale.y < Range)
        {
            Scale.y += Speed;//* Time.deltaTime;
            Scale.x += Speed;//* Time.deltaTime;
            transform.localScale = Scale;
        } //else
          //Destroy (gameObject);
        alpha -= 0.01f;
        GetComponent<SpriteRenderer>().color = new Color(1, 1, 1, alpha); // CHANGE ALPHA 
        if (alpha < 0) Destroy(this.gameObject);
    }
}