using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV1_Dragon_HealthBar : MonoBehaviour
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
        localScale.x = Dragon_LV1.Dragon_Health;
        transform.localScale = localScale;
    }
}
