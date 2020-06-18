using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawnerscript : MonoBehaviour
{
    public GameObject[] SpawnObject;
    public GameObject ScoreBar;

    private int RandCube;

    float PositionY;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnObjects", 1, 1);
    }

    // Update is called once per frame
    void Update()
    {
       
    }

    void SpawnObjects()
    {
        RandCube = Random.Range(0, SpawnObject.Length);

        PositionY = Random.Range(4, -4f);
        this.transform.position = new Vector3(transform.position.x, PositionY, transform.position.z);
        Instantiate(SpawnObject[RandCube], transform.position, transform.rotation);
        Instantiate(ScoreBar, transform.position, transform.rotation);
    }
}
