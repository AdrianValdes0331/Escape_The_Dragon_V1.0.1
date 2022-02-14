using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weaponize : MonoBehaviour
{
    public GameObject pickupEffect;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Pickup();
        }
    }

    void Pickup()
    {
        Debug.Log("animation");
        Instantiate(pickupEffect, transform.position, transform.rotation);
        Destroy(gameObject);
    }

}
