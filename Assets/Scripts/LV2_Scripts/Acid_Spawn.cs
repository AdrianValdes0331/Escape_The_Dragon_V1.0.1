using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Acid_Spawn : MonoBehaviour
{
    public GameObject Acid_spit;
    private float LastShoot;
    public GameObject FirePoint;
    private Animator Animator;

    void Start()
    {
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    private void Update()
    {
        if (Time.time > LastShoot + 1.15f)
        {
            Instantiate(Acid_spit, FirePoint.transform.position, Quaternion.identity);
            LastShoot = Time.time;
        }
    }
}
