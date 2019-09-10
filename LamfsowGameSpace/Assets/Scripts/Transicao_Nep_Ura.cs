using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Transicao_Nep_Ura : MonoBehaviour
{
    // Start is called before the first frame update
    //void Start()
    //{

    //}

    public float timer = 10;

    // Update is called once per frame
    void Update()
    {
        timer -= Time.deltaTime;

        if (timer <= 0)
        {
            Application.LoadLevel("Uranus");
        }
    }
}
