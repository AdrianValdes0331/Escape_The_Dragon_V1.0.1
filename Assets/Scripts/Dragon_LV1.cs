using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_LV1 : MonoBehaviour
{
    public GameObject RegularFire;
    public GameObject Ramon;
    private float LastShoot;
    public GameObject target;
    Vector3 Tdirection;

    // Update is called once per frame
    private void Update()
    {
        float distance = Mathf.Abs(Ramon.transform.position.x - transform.position.x);
        //Vector3 direction = Ramon.transform.position;
        if (distance < 3.0f && Time.time > LastShoot + 0.25f)
        {
            Shoot();
            LastShoot = Time.time;
        }
    }

    private void Shoot()
    {
        Tdirection = (target.transform.position - transform.position).normalized * 0.8f;
        //rb.velocity = new Vector2(Tdirection.x, Tdirection.y);

        GameObject bullet = Instantiate(RegularFire, transform.position + Tdirection * 0.8f, Quaternion.identity);
        bullet.GetComponent<Bullet_Movement>().SetDirection(Tdirection);
    }
}
