using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstaclePawner : MonoBehaviour
{
    public float max_time = 1;
    private float timer = 0;
    public GameObject obstacle;
    
    public float height;
    void Start()
    {
        GameObject new_obstacle = Instantiate(obstacle);
        new_obstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0); 

    }

    void Update()
    {
        if (timer > max_time)
        {
            GameObject new_obstacle = Instantiate(obstacle);
            new_obstacle.transform.position = transform.position + new Vector3(0, Random.Range(-height, height), 0);
            Destroy(new_obstacle, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}
