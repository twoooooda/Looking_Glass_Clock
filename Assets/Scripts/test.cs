using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class test : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        DateTime dt = DateTime.Now;

        Debug.Log(dt.ToString("yyyy/MM/dd HH:mm:ss"));
    }
}
