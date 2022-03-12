using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class miniDragon : MonoBehaviour
{
    public GameObject Ramon;
    public static float Skeleton_Health;
    private Animator Animator;
    public float speed;
    private Transform target;

    void Start()
    {
        Skeleton_Health = 2;
        Animator = GetComponent<Animator>();
        target = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Mathf.Abs(Ramon.transform.position.x - transform.position.x);
        Vector3 direction = Ramon.transform.position - transform.position;
        if (direction.x >= 0.0f)
        {
            transform.localScale = new Vector3(0.5f, 0.5f, 1.0f);
        }
        else
        {
            transform.localScale = new Vector3(-0.5f, 0.5f, 1.0f);
        }
        if (distance < 3.0f)
        {
            /*Animator.SetBool("walk", true);
            if (distance < 0.5f)
            {
                Animator.SetTrigger("attack");
            }
            else
            {*/
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
            //}
        }
        /*if (distance > 3.0f)
        {
            Animator.SetBool("walk", false);
        }*/
        if (Skeleton_Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gunsword_Bullet")
        {
            Skeleton_Health -= 0.1f;
            //Animator.SetTrigger("damage");
        }
    }
}
