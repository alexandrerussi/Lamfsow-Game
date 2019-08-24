using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OrbitaElipse : MonoBehaviour
{
    float alpha, X, Y, Z;
    public Transform centerPoint;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ElipticalTranslation();
        transform.LookAt(centerPoint);
    }

    void ElipticalTranslation()
    {
        X = (0f + (10f * Mathf.Sin(Mathf.Deg2Rad * alpha)));
        Z = (0f + (5f * Mathf.Cos(Mathf.Deg2Rad * alpha)));
        transform.position = new Vector3(X, 0, Z) + centerPoint.position;
        //transform.position = new Vector2(0f + (10f * Mathf.Sin(Mathf.Deg2Rad * alpha)),0f + (5f * Mathf.Cos(Mathf.Deg2Rad * alpha)));
        alpha += 2f;//can be used as speed
    }
}