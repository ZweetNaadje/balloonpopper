using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalloonController : MonoBehaviour
{
    public int clicksToPop = 3;

    void OnMouseDown()
    {
        clicksToPop--;
        
        // increase the balloon's scale
        transform.localScale += new Vector3(0.2f, 0.2f, 0.2f);
       
        // if we're out of clicks, destroy the balloon
        if(clicksToPop == 0)
        {
            Destroy(gameObject);
        }
    }
}
