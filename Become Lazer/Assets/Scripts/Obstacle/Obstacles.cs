using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour {

	public GameObject Player;

	// Use this for initialization
	void Start () {
		Player = GameObject.FindGameObjectWithTag ("Player");

    }

    // Update is called once per frame
    void Update () {

		if (gameObject.transform.position.y <= -6f) {
			Destroy (gameObject);
		}

        transform.Translate(0, -5 * Time.deltaTime, 0);

	}


	/*IEnumerator DestroyPlayer(){

		yield return new WaitForSeconds (0.08f);
		Destroy(Player);
	}*/
}
