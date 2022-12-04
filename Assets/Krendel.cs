using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Krendel : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D colision)
    {
        Destroy(this.gameObject, 0.1f);
    }
}
