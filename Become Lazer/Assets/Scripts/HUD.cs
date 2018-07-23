using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour {
	
	public GameObject cam;
	int PlayerScore , PlayerHighScore ;
	public Text ScoreText,LoseScore,LoseHighScore;
    public string state;
    public Canvas LoseCanvas;
	void Start () {
        //PlayerHighScore = PlayerPrefs.GetInt("High");
        state = "playing";
	}
	

	void Update () {
		
		Score ();
        if (state == "lose") Lose();


		if(PlayerScore > PlayerHighScore)
		{
         PlayerHighScore = PlayerScore ;
		// PlayerPrefs.SetInt("High", PlayerHighScore);	
		}
	}

	void Score () {
		
		PlayerScore = Mathf.RoundToInt(cam.transform.position.y/2f);
		ScoreText.text = "Score :" + PlayerScore.ToString ();
	}

    /*void HighScore () {


	}*/

    void Lose() {
        Time.timeScale = 0;
        LoseScore.text = ScoreText.text;
        //LoseHighScore.text = PlayerHighScore.ToString() ;
        LoseCanvas.gameObject.SetActive(true);
        state = "playing";
    }


}
