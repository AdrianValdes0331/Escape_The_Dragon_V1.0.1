using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall_Shooter : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Shooter_Script.Shooter_Health <= 0 && Shooter_Script_2.Shooter_Health_2 <= 0)
        {
            Destroy(gameObject);
        }
    }
}
