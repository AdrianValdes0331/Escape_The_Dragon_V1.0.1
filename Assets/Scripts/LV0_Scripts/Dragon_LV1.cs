using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_LV1 : MonoBehaviour
{
    public GameObject RegularFire;
    public GameObject Ramon;
    public static float Dragon_Health;
    private Animator Animator;

    void Start()
    {
        Dragon_Health = 4;
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Mathf.Abs(Ramon.transform.position.x - transform.position.x);
        if (distance < 3.0f)
        {
            Animator.SetBool("attack", true);
        }
        else if (distance > 3.0f)
        {
            Animator.SetBool("attack", false);
        }
        if (Dragon_Health <= 0)
        {
            Destroy(gameObject);
        }    
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gunsword_Bullet")
        {
            Dragon_Health -= 0.01f;
        }
    }
}

/*
   //private float LastShoot;
   //public GameObject target;
   //public GameObject FirePoint;
   //Vector3 Tdirection;
   //Vector3 direction = Ramon.transform.position;
   private void Shoot()
   {
       Tdirection = (target.transform.position - transform.position).normalized * 0.8f;
       //rb.velocity = new Vector2(Tdirection.x, Tdirection.y);
       //GameObject bullet = Instantiate(RegularFire, transform.position + (transform.up * 0.2f) + (transform.right*-0.5f) + Tdirection, Quaternion.identity);
       GameObject bullet = Instantiate(RegularFire, FirePoint.transform.position + Tdirection * 0.5f, Quaternion.identity);
       bullet.GetComponent<Bullet_Movement_Villian>().SetDirection(Tdirection);
   }*/

/*if (distance < 3.0f && Time.time > LastShoot + 0.25f)
    {
        //Animator.SetBool("attack", true);
        Shoot();
        LastShoot = Time.time;
    }*/
