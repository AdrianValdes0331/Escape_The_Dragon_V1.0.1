using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Playables;

public class LV2_Cutscene : MonoBehaviour
{
    [SerializeField] private PlayableDirector LV2_Victory;
    [SerializeField] private PlayableDirector LV2_Victory_PT2;
    public GameObject LV2_Boss_Char;
    // Start is called before the first frame update
    void Start()
    {
        LV2_Boss_Char = GameObject.FindGameObjectWithTag("LV2_Boss");
    }

    // Update is called once per frame
    void Update()
    {
        if (LV2_Boss.LV2_Boss_Health <= 0)
        {
            LV2_Victory.Play();
            LV2_Victory_PT2.Play();
        }
    }
}
