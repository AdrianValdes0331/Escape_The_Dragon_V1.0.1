using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blood_Wave : MonoBehaviour
{
    public GameObject Blood_Rises;
    public float speed;
    private Transform target;
    public GameObject target_direction;
    // Start is called before the first frame update
    void Start()
    {
        target = target_direction.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
    }

}
