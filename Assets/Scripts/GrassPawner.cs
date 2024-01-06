using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UIElements;

public class GrassPawner : MonoBehaviour
{
    public float max_time = 1;
    private float timer = 0;
    public GameObject grass;
    public float XMove = 1;

    void Start()
    {
        GameObject new_grass = Instantiate(grass);
        new_grass.transform.position = transform.position + new Vector3(XMove, 0, 0);
        Destroy(new_grass, 15);
    }

    void Update()
    {
        if (timer > max_time)
        {
            GameObject new_grass = Instantiate(grass);
            new_grass.transform.position = transform.position + new Vector3(XMove, 0, 0);
            Destroy(new_grass, 15);
            timer = 0;
        }

        timer += Time.deltaTime;
    }
}