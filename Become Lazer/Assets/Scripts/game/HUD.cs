using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class HUD : MonoBehaviour {
	
	public GameObject cam , Shooter , LoseEffect;
	int PlayerScore , PlayerHighScore ;
	public Text ScoreText,HighScoreText,LoseScore,LoseHighScore;
    public string state;
    public Canvas LoseCanvas;
	void Start () {
        PlayerHighScore = PlayerPrefs.GetInt("High");
        state = "playing";
	}
	

	void Update () {

        //LoseHighScore.text = PlayerHighScore.ToString();

        Score ();
        if (state == "lose") Lose();


	}

	void Score () {
		
		PlayerScore = Mathf.RoundToInt(cam.transform.position.y/2f);
        if (PlayerScore > PlayerHighScore)
        {
            PlayerHighScore = PlayerScore;
            PlayerPrefs.SetInt("High", PlayerScore);
        }

        ScoreText.text =  PlayerScore.ToString ();
        HighScoreText.text = "High Score : " + PlayerHighScore.ToString();
       // if (PlayerScore > PlayerHighScore) PlayerHighScore = PlayerScore;

    }

    /*void HighScore () {


	}*/

    void Lose() {
        LoseScore.text = "Score : "+ScoreText.text;
        LoseHighScore.text = HighScoreText.text;
        LoseCanvas.gameObject.SetActive(true);
        state = "playing";
        Time.timeScale = 0f;

    }


}
