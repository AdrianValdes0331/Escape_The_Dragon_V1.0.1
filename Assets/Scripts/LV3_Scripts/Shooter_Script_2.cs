using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_Script_2 : MonoBehaviour
{
    public static float Shooter_Health_2;
    // Start is called before the first frame update
    void Start()
    {
        Shooter_Health_2 = 2;
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Gunsword_Bullet")
        {
            Shooter_Health_2 -= 0.2f;
        }
        if (Shooter_Health_2 <= 0)
        {
            Destroy(gameObject);
        }
    }
}
