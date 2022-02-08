using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Movement_Villian : MonoBehaviour
{
    public float Speed;
    private Rigidbody2D Rigidbody2D;
    private Vector2 Direction;

    // Start is called before the first frame update
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    private void FixedUpdate()
    {
        Rigidbody2D.velocity = Direction * Speed;
    }

    public void SetDirection(Vector2 direction)
    {
        Direction = direction;
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag != "LV1_Dragon")
        {
            Debug.Log("Activate_LV");
            DestroyBullet();
        }
    }

    public void DestroyBullet()
    {
        Destroy(gameObject, 0.05f);
    }
}
