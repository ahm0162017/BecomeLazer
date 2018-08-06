using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoseEffect : MonoBehaviour
{
    Vector2 Scale;
    public float Speed,alpha = 0.5f,Range, AlphaSpeed;


    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        Scale = transform.localScale;


        if (Scale.y < Range)
        {
            Scale.y += Speed * Time.deltaTime;  
            Scale.x += Speed * Time.deltaTime; 
            transform.localScale = Scale;
        } //else
          //Destroy (gameObject);
        alpha -= AlphaSpeed*Time.deltaTime;
        //GetComponent<SpriteRenderer>().color = new Color(255, 255, 255, alpha); // CHANGE ALPHA 
        GetComponent<SpriteRenderer>().color = new Color(GetComponent<SpriteRenderer>().color.r, GetComponent<SpriteRenderer>().color.g, GetComponent<SpriteRenderer>().color.b, alpha);

        if (alpha < 0) Destroy(this.gameObject);
    }
}