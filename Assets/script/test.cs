using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test : MonoBehaviour
{
    private int speed;
    private object time;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if(Input.GetKey(KeyCode.A))
        {
            Move(Vector3.up);
            Debug.Log("нажата кнопка 'A'");
        }




        if (Input.GetKey(KeyCode.A))
        {
            Move(Vector3.up);
            Debug.Log("нажата кнопка 'A'");
        }
        if (Input.GetKey(KeyCode.S))
        {
            Move(Vector3.up);
            Debug.Log("нажата кнопка 'S'");
        }
        if (Input.GetKey(KeyCode.D))
        {
            Move(Vector3.up);
            Debug.Log("нажата кнопка 'D'");
        }
    }
    

    private void Move(Vector3 up)
    {
        transform.position += up* Time.fixedDeltaTime* speed;
        throw new NotImplementedException();
    }
}

  
