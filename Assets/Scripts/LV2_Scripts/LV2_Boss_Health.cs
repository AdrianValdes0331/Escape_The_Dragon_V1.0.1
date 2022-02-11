using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LV2_Boss_Health : MonoBehaviour
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
        localScale.x = LV2_Boss.LV2_Boss_Health;
        transform.localScale = localScale;
    }
}
