using UnityEngine;
using System.Collections;


public class deth : MonoBehaviour
{
    public float _duration = .8f;
    private Transform _cameraTransform;
    private Vector3 _originalPosition;

    
    

    // Start is called before the first frame update
    void Start()
    {
        _cameraTransform = Camera.main.transform;
        _originalPosition = _cameraTransform.position;
    }

    public void ShakeAction()
    {
        _originalPosition = _cameraTransform.position;
        StartCoroutine(_Shake());
    }

    IEnumerator _Shake()
    {

        float x;
        float y;
        float timeLeft = Time.time;

        while ((timeLeft + _duration) > Time.time)
        {
            x = Random.Range(-0.3f, 0.3f);
            y = Random.Range(-0.3f, 0.3f);

            _cameraTransform.position = new Vector3(x, y, _originalPosition.z); yield return new WaitForSeconds(0.025f);
        }

        _cameraTransform.position = _originalPosition;
    }
}

