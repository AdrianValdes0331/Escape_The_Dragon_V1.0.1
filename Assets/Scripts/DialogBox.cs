using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DialogBox : MonoBehaviour
{
    public string popUp;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            Debug.Log("Activate");
            PopUps pop = GameObject.FindGameObjectWithTag("GameManager").GetComponent<PopUps>();
            pop.PopUP(popUp);
        }
    }
}
