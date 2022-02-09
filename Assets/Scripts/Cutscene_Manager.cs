using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class Cutscene_Manager : MonoBehaviour
{
    [SerializeField] private PlayableDirector Obligatory_Death;
    public GameObject ramon;
    // Start is called before the first frame update
    void Start()
    {
        ramon = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (RamonMovement.ramon_health <= 0)
        {
            Obligatory_Death.Play();
            Debug.Log("hello");
            //Destroy(ramon, 2.99f); //fix destroy
        }
    }
}
