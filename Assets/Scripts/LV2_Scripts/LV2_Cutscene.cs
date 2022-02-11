using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LV2_Cutscene : MonoBehaviour
{
    [SerializeField] private PlayableDirector LV2_Victory;
    public GameObject LV2_Boss;
    // Start is called before the first frame update
    void Start()
    {
        LV2_Boss = GameObject.FindGameObjectWithTag("LV2_Boss");
    }

    // Update is called once per frame
    void Update()
    {
        if (RamonMovement.ramon_health <= 0)
        {
            LV2_Victory.Play();
        }
    }

    void DestroyLV2Boss() 
    {
        Destroy(LV2_Boss);
    }

}
