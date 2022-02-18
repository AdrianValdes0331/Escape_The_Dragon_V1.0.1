using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centepide_Script : MonoBehaviour
{
    public GameObject Ramon;
    public static float Centipede_Health;
    private Animator Animator;

    void Start()
    {
        Centipede_Health = 2;
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Mathf.Abs(Ramon.transform.position.x - transform.position.x);
        if (distance < 3.0f)
        {
            Animator.SetBool("shoot", true);
            if (distance < 2.0f)
            {
                Animator.SetTrigger("attack");
            }
        }
        if (distance > 3.0f)
        {
            Animator.SetBool("shoot", false);
        }
        if (Centipede_Health <= 0)
        {
            Animator.SetTrigger("death");
            Destroy(GetComponent<BoxCollider2D>());
            //Destroy(gameObject, 5.0f);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gunsword_Bullet")
        {
            Centipede_Health -= 0.1f;
            Animator.SetTrigger("damage");
        }
    }
}
