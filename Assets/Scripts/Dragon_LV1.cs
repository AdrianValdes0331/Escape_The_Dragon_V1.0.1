using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_LV1 : MonoBehaviour
{
    public GameObject RegularFire;
    public GameObject Ramon;
    private float LastShoot;

    // Update is called once per frame
    private void Update()
    {
        float distance = Mathf.Abs(Ramon.transform.position.x - transform.position.x);
        if(distance < 3.0f && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Shoot()
    {
        Vector3 direction;
        if (transform.localScale.x == 259.5f)
        {
            direction = Vector2.left;
        }
        else
        {
            direction = Vector2.right;
        }
        GameObject bullet = Instantiate(RegularFire, transform.position + direction * 0.8f, Quaternion.identity);
        bullet.GetComponent<Bullet_Movement>().SetDirection(direction);
    }
}
