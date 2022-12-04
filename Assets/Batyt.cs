using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent (typeof(Collision2D))]

public class Batyt : MonoBehaviour
{
    [SerializeField]
    private Vector2 Direction { get; set; } = new Vector2(0, 10);
    private void OnCollisionEnter2D(Collision2D player)
    {
        var rigidbody = player.gameObject.GetComponent<Rigidbody2D>();
        if(rigidbody != null)
        {
            rigidbody.AddForce(Direction, ForceMode2D.Impulse);
        }
    }
}
