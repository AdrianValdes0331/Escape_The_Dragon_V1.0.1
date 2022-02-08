using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dragon_LV1 : MonoBehaviour
{
    public GameObject RegularFire;
    public GameObject Ramon;
    private float LastShoot;
    public GameObject target;
    public static float Dragon_Health;
    Vector3 Tdirection;

    void Start()
    {
        Dragon_Health = 10;
    }

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
        if (Dragon_Health <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void Shoot()
    {
        Tdirection = (target.transform.position - transform.position).normalized * 0.8f;
        //rb.velocity = new Vector2(Tdirection.x, Tdirection.y);
        //GameObject bullet = Instantiate(RegularFire, transform.position + (transform.up * 0.2f) + (transform.right*-0.5f) + Tdirection, Quaternion.identity);
        GameObject bullet = Instantiate(RegularFire, transform.position + Tdirection * 0.5f, Quaternion.identity);
        bullet.GetComponent<Bullet_Movement_Villian>().SetDirection(Tdirection);
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gunsword_Bullet")
        {
            Dragon_Health -= 0.01f;
        }
    }
}
