using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class platfomadvig : MonoBehaviour
    
{
    public Vector2[] Target;
    public bool Active = false;
    private int _pointer;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        var targetPosition = Target[_pointer];
        var distance = Vector2.Distance(transform.position, targetPosition);
        transform.position = Vector2.Lerp(transform.position, targetPosition, 1 /distance * Time.fixedDeltaTime);
        if (distance <= 0.1f) 
        {
            _pointer++;
            if (_pointer >= Target.Length)
            {
                _pointer = 0;
            }
        }
        
        

    }
}
