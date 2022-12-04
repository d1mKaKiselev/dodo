
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ship : MonoBehaviour
{
    public deth Deth;
    public Spawn TeleportDestination;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.transform.position = TeleportDestination.transform.position;
        if (Deth != null)
        {
            Deth.ShakeAction();
        }
    }
   
}




