using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RamonMovement : MonoBehaviour
{
    // Start is called before the first frame update
    public float Speed;
    public float JumpForce;
    public GameObject Bullet;
    private Animator Animator;
    private Rigidbody2D Rigidbody2D;
    private float Horizontal;
    private float LastShoot;
    void Start()
    {
        Rigidbody2D = GetComponent<Rigidbody2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Horizontal = Input.GetAxisRaw("Horizontal");

        if (Horizontal < 0.0f)
        {
            transform.localScale = new Vector3(-259.5f, 259.5f, 259.5f);
        }
        else if (Horizontal > 0.0f)
        {
            transform.localScale = new Vector3(259.5f, 259.5f, 259.5f);
        }
        Animator.SetBool("running", Horizontal != 0.0f);
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
        if (Input.GetKey(KeyCode.LeftShift) && Time.time > LastShoot + 0.25f)
        {
            Animator.SetTrigger("shoot");
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Jump()
    {
        Rigidbody2D.AddForce(Vector2.up * JumpForce);
    }

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 259.5f)
        {
            direction = Vector2.right;
        }
        else
        {
            direction = Vector2.left;
        }
        GameObject bullet =  Instantiate(Bullet, transform.position + direction * 0.1f, Quaternion.identity);
        bullet.GetComponent<Bullet_Movement>().SetDirection(direction);
    }

    private void FixedUpdate()
    {
        Rigidbody2D.velocity = new Vector2(Horizontal, Rigidbody2D.velocity.y);
    }


}
