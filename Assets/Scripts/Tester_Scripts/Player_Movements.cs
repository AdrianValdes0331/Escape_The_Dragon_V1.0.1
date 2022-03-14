using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Movements : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private bool isOnGround()
    {
        float lengthToSearch = 0.1f;
        float colliderThreshhold = 0.001f;
        Vector2 linestart = new Vector2(this.transform.position.x, this.transform.position.y - this.GetComponent<Renderer>().bounds.extents.y - colliderThreshhold);
        Vector2 vectorToSearch = new Vector2(this.transform.position.x, linestart.y - lengthToSearch);
        RaycastHit2D hit = Physics2D.Linecast(linestart, vectorToSearch);
        return hit;
    }

    /*private bool isOnWallet()
    {
        float lengthToSearch = 0.1f;
        float colliderThreshhold = 0.01f;
        Vector2 linestart = new Vector2(this.transform.position.x - this.GetComponent<Renderer>().bounds.extents.x - colliderThreshhold);
        Vector2 vectorToSearch = new Vector2(linestart.x - lengthToSearch, this.transform.position.y);
    }
    */
}
