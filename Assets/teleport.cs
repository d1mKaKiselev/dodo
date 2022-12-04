using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleport : MonoBehaviour
{
    
    public teleport2 TeleportDestination;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = TeleportDestination.transform.position;
    }


}


