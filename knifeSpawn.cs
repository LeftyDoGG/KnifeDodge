using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class knifeSpawn : MonoBehaviour
{
    public GameObject obstacle;
    private float max_Y = 4.5f, min_Y = -3f;

    void Start()
    {
        StartCoroutine(StartSpawning());
    }


    void Update()
    {
        
    }
    IEnumerator StartSpawning()
    {
        yield return new WaitForSeconds(Random.Range(1f, 2f));
        Instantiate(obstacle);
        float y = Random.Range(min_Y, max_Y);
        obstacle.transform.position = new Vector2(transform.position.x, y);
        StartCoroutine(StartSpawning());

    }
}
