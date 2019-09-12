using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotação : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }
    int yRot = 0, x=0, z=0;
    // Update is called once per frame
    void Update()
    {
        yRot--;
        Vector3 rot = new Vector3(x, yRot, z);
        transform.rotation = Quaternion.Euler(rot);
    }
}
