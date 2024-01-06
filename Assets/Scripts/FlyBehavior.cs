using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBehavior : MonoBehaviour
{
    public GameManager game_manager;
    public float velocity;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0) || Input.GetKeyDown(KeyCode.Space) || Input.GetKeyDown(KeyCode.Return))
        {
            rb.velocity = Vector2.up * velocity;
        }

        if (rb.transform.position.x <= -13.5f || rb.transform.position.y <= -3.9f || rb.transform.position.y >= 6f)
        {
            game_manager.GameOver();
        }
    }
}
