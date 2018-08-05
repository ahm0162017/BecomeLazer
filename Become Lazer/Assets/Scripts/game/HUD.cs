using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;

using UnityEngine.UI;
using EZCameraShake;

public class HUD : MonoBehaviour {
	
	public GameObject cam , Shooter , LoseEffect;
	int PlayerScore , PlayerHighScore ;
	public Text ScoreText,HighScoreText,LoseScore,LoseHighScore;
    public string state;
    public Canvas LoseCanvas;
	void Start () {
        PlayerHighScore = PlayerPrefs.GetInt("High");
        state = "playing";
        Advertisement.Initialize("2721324");
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
        CameraShaker.Instance.ShakeOnce(4, 4f, 0.1f, 0.1f);
        LoseScore.text = "Score : "+ScoreText.text;
        LoseHighScore.text = HighScoreText.text;
        LoseCanvas.gameObject.SetActive(true);
        state = "playing";
        Invoke("StopTime", 0.2f);
    }

    void StopTime()
    {
        Time.timeScale = 0f;
        if(Advertisement.IsReady())
        Advertisement.Show("rewardedVideo");
    }

}
