using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV2_Boss : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject Acid_spit;
    public GameObject Ramon;
    private float LastShoot;
    public GameObject target;
    public GameObject FirePoint;
    public static float LV2_Boss_Health;
    private Animator Animator;
    Vector3 Tdirection;

    void Start()
    {
        LV2_Boss_Health = 2;
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        float distance = Mathf.Abs(Ramon.transform.position.x - transform.position.x);
        //Vector3 direction = Ramon.transform.position;
        if (distance < 3.0f)
        {
            int randomNumber = Random.Range(1,4);
            if (randomNumber == 1)
            {
                Animator.SetBool("Attack_1", true);
                Animator.SetBool("Attack_2", false);
                Animator.SetBool("Attack_3", false);
            }
            else if (randomNumber == 2)
            {
                Animator.SetBool("Attack_1", false);
                Animator.SetBool("Attack_2", true);
                Animator.SetBool("Attack_3", false);
            }
            else if (randomNumber == 3)
            {
                Animator.SetBool("Attack_1", false);
                Animator.SetBool("Attack_2", false);
                Animator.SetBool("Attack_3", true);
            }
        }
        else if (distance > 3.0f)
        {
            Animator.SetBool("Attack_1", false);
            Animator.SetBool("Attack_2", false);
            Animator.SetBool("Attack_3", false);
        }

        if (distance < 3.0f && Time.time > LastShoot + 0.5f)
        {
            //Animator.SetBool("attack", true);
            Shoot();
            LastShoot = Time.time;
        }
        if (LV2_Boss_Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Shoot()
    {
        Tdirection = (target.transform.position - transform.position).normalized * 0.8f;
        GameObject bullet = Instantiate(Acid_spit, FirePoint.transform.position + Tdirection * 0.5f, Quaternion.identity);
        bullet.GetComponent<Bullet_Movement_Villian>().SetDirection(Tdirection);
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
