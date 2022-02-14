using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet_Direction : MonoBehaviour
{
    [SerializeField]
    GameObject bullet;
    public GameObject FirePoint_1;
    public float fireRate = 0.7f;
    float nextFire;
    public GameObject target;
    void Start()
    {
        nextFire = Time.time;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Mathf.Abs(target.transform.position.x - transform.position.x);
        if (distance < 3.0f)
        {
            CheckIfTimeToFire();
        }
    }

    void CheckIfTimeToFire()
    {
        if (Time.time > nextFire)
        {
            Instantiate(bullet, FirePoint_1.transform.position, Quaternion.identity);
            nextFire = Time.time + fireRate;
        }
    }
}
