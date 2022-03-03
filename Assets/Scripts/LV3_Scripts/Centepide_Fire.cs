using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Centepide_Fire : MonoBehaviour
{
    private Animator Animator;
    public GameObject arrow;
    private float LaunchForce = 5.0f;
    public GameObject FirePoint_1;
    public float fireRate = 0.7f;
    float nextFire;
    public GameObject Ramon;
    public GameObject tester;
    // Start is called before the first frame update
    void Start()
    {
        Animator = GetComponent<Animator>();
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Mathf.Abs(Ramon.transform.position.x - transform.position.x);
        if ((distance > 2.0f) && (distance < 5.5f) && Centepide_Script.Centipede_Health > 0)
        {
            Shoot();
        }
    }

    void Shoot()
    {
        if (Time.time > nextFire)
        {
            fireRate = Random.Range(0.1f, 0.7f);
            LaunchForce = Random.Range(4.0f, 16.0f);
            GameObject proyectile = Instantiate(arrow, FirePoint_1.transform.position, transform.rotation);
            proyectile.GetComponent<Rigidbody2D>().velocity = tester.transform.localScale * LaunchForce;
            nextFire = Time.time + fireRate;
        }
    }
}


