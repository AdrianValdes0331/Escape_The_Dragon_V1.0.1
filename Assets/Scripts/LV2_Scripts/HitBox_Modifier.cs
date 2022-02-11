using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitBox_Modifier : MonoBehaviour
{
    public CapsuleCollider2D LV2_Boss;
    private Animator Animator;
    void Start()
    {
        LV2_Boss = LV2_Boss.GetComponent<CapsuleCollider2D>();
        Animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Animator.GetBool("Attack_1") == true)
        {
            LV2_Boss.offset = new Vector2(-0.132f, 0.145f);
            LV2_Boss.size = new Vector2(0.38f, 0.145f);
        }
        else if (Animator.GetBool("Attack_2") == true)
        {
            LV2_Boss.offset = new Vector2(-0.132f, 0.0f);
            LV2_Boss.size = new Vector2(0.38f, 0.145f);
        }
        else if (Animator.GetBool("Attack_3") == true)
        {
            LV2_Boss.offset = new Vector2(-0.132f, 0.085f);
            LV2_Boss.size = new Vector2(0.38f, 0.145f);
        }
        else
        {
            LV2_Boss.size = new Vector2(0.1f, 0.1f);
            LV2_Boss.offset = new Vector2(0.1f, 0.1f);
        }
    }
}
