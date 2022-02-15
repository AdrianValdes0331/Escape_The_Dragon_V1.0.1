using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_Script : MonoBehaviour
{
    public static float Shooter_Health;
    // Start is called before the first frame update
    void Start()
    {
        Shooter_Health = 2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gunsword_Bullet")
        {
            Shooter_Health -= 0.2f;
        }
        if (Shooter_Health <= 0)
        {
            Destroy(gameObject);
        }
    }
}
