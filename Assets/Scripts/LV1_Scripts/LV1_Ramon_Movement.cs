using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV1_Ramon_Movement : MonoBehaviour
{
    public Rigidbody2D rb;
    public float moveSpeed = 5;
    private Vector2 MoveDirection;
    public static float lv1_ramon_health;
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        lv1_ramon_health = 1;
    }

    // Update is called once per frame
    void Update()
    {
        ProcessInputs();
        if (lv1_ramon_health <= 0)
        {
            Destroy(gameObject);
        }
    }
    private void FixedUpdate()
    {
        Move();
    }

    void ProcessInputs()
    {
        float moveX = Input.GetAxisRaw("Vertical");
        float moveY = Input.GetAxisRaw("Horizontal");

        MoveDirection = new Vector2(moveX, moveY);
    }

    void Move()
    {
        rb.velocity = new Vector2(MoveDirection.x * moveSpeed, MoveDirection.y * moveSpeed);
    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("LV1_Obstacle"))
        {
            lv1_ramon_health -= 0.1f;
        }
    }

}
