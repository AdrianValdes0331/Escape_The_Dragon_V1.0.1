using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid_Drops : MonoBehaviour
{
    //private Rigidbody2D Rigidbody2D;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {     
         DestroyBullet();
    }

    public void DestroyBullet()
    {
        Destroy(gameObject);
    }
}
