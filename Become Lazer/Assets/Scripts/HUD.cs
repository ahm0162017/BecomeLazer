using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour {
	
	public GameObject cam;
	public int PlayerScore , PlayerHighScore ;
	public Text ScoreText;
    public string state;

	void Start () {
        //PlayerPrefs.GetInt
        state = "playing";
	}
	

	void Update () {
		
		Score ();
        if (state == "lose") print("you lose");


		/*if(PlayerScore > PlayerHighScore)
		{
         PlayerHighScore = PlayerScore ;
		 PlayerPrefs.SetInt("High", PlayerHighScore);	
		}*/
	}

	void Score () {
		
		PlayerScore = Mathf.RoundToInt(cam.transform.position.y/2f);
		ScoreText.text = "Score :" + PlayerScore.ToString ();
	}
	
	/*void HighScore () {
		
		PlayerScore = Mathf.RoundToInt(cam.transform.position.y/2f);
		ScoreText.text = "Score :" + PlayerScore.ToString ();
	}*/
	
	
}
