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
        Y = centerPoint.position.y;
        Z = (5f * Mathf.Cos(Mathf.Deg2Rad * alpha));
        transform.position = new Vector3(X, Y, Z);
        alpha += 2f;
        //print("Z: " + Z + "\n X: " + X); -> Para tirar conclusões geométricas
    }
}
