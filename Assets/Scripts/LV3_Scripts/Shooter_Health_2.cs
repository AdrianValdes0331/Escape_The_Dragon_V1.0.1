using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter_Health_2 : MonoBehaviour
{
    // Start is called before the first frame update
    Vector3 localScale;
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localScale.x = Shooter_Script_2.Shooter_Health_2;
        transform.localScale = localScale;
    }
}
