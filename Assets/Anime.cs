using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Anime : MonoBehaviour
{
    private Animator _animator;
    
    void Start()
    {
        _animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {

    }    
        private void OnCollisionEnter2D(Collision2D collision)
        {
            _animator.SetBool("state", true);
        Debug.Log("Jump");
        }

    private void OnCollisionExit2D(Collision2D collision)
    {
        _animator.SetBool("state", false);
    }


}

internal class AnimationController
{
}