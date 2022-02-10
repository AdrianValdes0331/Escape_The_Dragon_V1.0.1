using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV1_Health_Bar : MonoBehaviour
{
    Vector3 localScale;
    // Start is called before the first frame update
    void Start()
    {
        localScale = transform.localScale;
    }

    // Update is called once per frame
    void Update()
    {
        localScale.x = LV1_Ramon_Movement.lv1_ramon_health;
        transform.localScale = localScale;
    }
}
