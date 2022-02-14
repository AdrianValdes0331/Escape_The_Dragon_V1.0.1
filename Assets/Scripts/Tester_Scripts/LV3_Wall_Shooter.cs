using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV3_Wall_Shooter : MonoBehaviour
{
    public GameObject Acid_spit;
    private float LastShoot;
    public GameObject target;
    public GameObject FirePoint_1;
    public static float shooter_health;
    private Animator Animator;
    Vector3 Tdirection;

    void Start()
    {
        shooter_health = 1;
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Mathf.Abs(target.transform.position.x - transform.position.x);
        if (distance < 3.0f && Time.time > LastShoot + 0.5f)
        {
            Shoot();
            LastShoot = Time.time;
        }
        if (shooter_health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Shoot()
    {
        int number = Random.Range(1, 3);
        if (number == 1)
        {
            Tdirection = (target.transform.position - transform.position);
            GameObject bullet = Instantiate(Acid_spit, FirePoint_1.transform.position, Quaternion.identity);
            bullet.GetComponent<Bullet_Movement_Villian>().SetDirection(target.transform.position.normalized);
        }
        else
        {
            Tdirection = (target.transform.position - transform.position).normalized * 0.8f;
            GameObject bullet = Instantiate(Acid_spit, FirePoint_1.transform.position, Quaternion.identity);
            bullet.GetComponent<Bullet_Movement_Villian>().SetDirection(Tdirection);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gunsword_Bullet")
        {
            shooter_health -= 0.1f;
            //Animator.SetTrigger("Damage");
        }
    }
}
