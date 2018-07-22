using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour {
	
	public GameObject cam;
	public int PlayerScore , HighScore ;
	public Text ScoreText;

	void Start () {
		PlayerPrefs.GetInt

	}
	

	void Update () {
		
		Score ();
		if(PlayerScore > HighScore)
		{
		 HighScore = PlayerScore ;
		 PlayerPrefs.SetInt("High",HighScore);	
		}
	}

	void Score () {
		
		PlayerScore = Mathf.RoundToInt(cam.transform.position.y/2f);
		ScoreText.text = "Score :" + PlayerScore.ToString ();
	}
	
	void HighScore () {
		
		PlayerScore = Mathf.RoundToInt(cam.transform.position.y/2f);
		ScoreText.text = "Score :" + PlayerScore.ToString ();
	}
	
	
}
