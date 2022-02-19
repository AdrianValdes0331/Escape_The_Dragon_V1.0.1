using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood_Rise : MonoBehaviour
{
    public GameObject Blood_Rises;
    public float speed;
    private Transform target;
    // Start is called before the first frame update
    void Start()
    {
        Blood_Rises = GameObject.FindGameObjectWithTag("LV3_Centipede");
        target = GameObject.FindGameObjectWithTag("bloodlimit").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Centepide_Script.Centipede_Health <= 0)
        {
            transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        }
    }
}
