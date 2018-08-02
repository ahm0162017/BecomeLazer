using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour {


	public GameObject Obstacle,SuperLazer,SlowMotion;

	public float TimeUntilNextObstacle;
	public float TimeSeconds;

	private float XPosSpawnPoint;
	private Transform PositionOfSpawn;

	// Use this for initialization
	void Start () {
		PositionOfSpawn = gameObject.transform;
		//InvokeRepeating ("SpawnObstacle",TimeSeconds, TimeUntilNextObstacle);
	}
	
	// Update is called once per frame
	void Update () {		
		TimeSeconds -= Time.fixedDeltaTime * 0.015f;
		TimeUntilNextObstacle -= Time.deltaTime;

		if (TimeUntilNextObstacle <= 0f) {
			SpawnObstacle ();
			TimeUntilNextObstacle = TimeSeconds;
		}

	}


	void SpawnObstacle(){
		Vector3 Pos;
        int A= Random.Range(0,40);
		Pos.x = Random.Range (-2, 2);
		Pos.y = PositionOfSpawn.position.y;
		Pos.z = PositionOfSpawn.position.z;

        if(A == 0) Instantiate(SuperLazer, Pos, transform.rotation);
        else if(A == 1) Instantiate(SlowMotion, Pos, transform.rotation);
        else Instantiate(Obstacle, Pos, transform.rotation);
        
    }

}
