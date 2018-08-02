using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuAnimation : MonoBehaviour {


    public GameObject Lazer;

    public float TimeUntilNextObstacle;
    public float TimeSeconds, Range;

    private float XPosSpawnPoint;
    private Transform PositionOfSpawn;

    // Use this for initialization
    void Start()
    {
        PositionOfSpawn = gameObject.transform;
        //InvokeRepeating ("SpawnObstacle",TimeSeconds, TimeUntilNextObstacle);
    }

    // Update is called once per frame
    void Update()
    {
        //TimeSeconds -= Time.fixedDeltaTime * 0.015f;
        TimeUntilNextObstacle -= Time.deltaTime;

        if (TimeUntilNextObstacle <= 0f)
        {
            SpawnObstacle();
            TimeUntilNextObstacle = TimeSeconds;
        }

    }


    void SpawnObstacle()
    {
        Vector3 Pos;
        float ang = Random.Range(-90,90);

        Pos.y = Random.Range(-Range, Range);
        Pos.x = PositionOfSpawn.position.y;
        Pos.z = PositionOfSpawn.position.z;

        Instantiate(Lazer, Pos, Quaternion.EulerAngles(0,0,ang));

    }
}
