using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpecialBullet : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        DestroyBullet();
    }

    public void DestroyBullet()
    {
        Destroy(gameObject, 0.05f);
    }
}
