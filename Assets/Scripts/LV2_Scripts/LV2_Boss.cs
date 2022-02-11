using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV2_Boss : MonoBehaviour
{
    public GameObject Acid_spit;
    public GameObject Acid_spit_2;
    private float LastShoot;
    public GameObject target;
    public GameObject FirePoint_1;
    public GameObject FirePoint_2;
    public static float LV2_Boss_Health;
    private Animator Animator;
    Vector3 Tdirection;
    Vector3 Tdirection_2;

    void Start()
    {
        LV2_Boss_Health = 2;
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Mathf.Abs(target.transform.position.x - transform.position.x);
        if (distance < 3.0f)
        {
            Animator.SetBool("Attack", true);
        }
        else if (distance > 3.0f)
        {
            Animator.SetBool("Attack", false);
        }
        if (distance < 3.0f && Time.time > LastShoot + 0.5f)
        {
            Shoot();
            Shoot2();
            LastShoot = Time.time;
        }
        /*if (LV2_Boss_Health <= 0)
        {
            //Destroy(gameObject);
        }*/
    }

    private void Shoot()
    {
        Tdirection = (target.transform.position - transform.position).normalized * 0.8f;
        GameObject bullet = Instantiate(Acid_spit, FirePoint_1.transform.position, Quaternion.identity);
        bullet.GetComponent<Bullet_Movement_Villian>().SetDirection(Tdirection);
    }
    private void Shoot2()
    {
        Tdirection_2 = (target.transform.position - transform.position).normalized * 0.8f;
        GameObject bullet_2 = Instantiate(Acid_spit_2, FirePoint_2.transform.position, Quaternion.identity);
        bullet_2.GetComponent<Bullet_Movement_Villian>().SetDirection(Tdirection_2);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gunsword_Bullet")
        {
            LV2_Boss_Health -= 0.1f;
            Animator.SetTrigger("Damage");
        }
    }

}
