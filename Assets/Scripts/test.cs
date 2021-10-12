using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using JerkyTreats.MongoDB;
using MongoDB.Driver;

public class test  : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        var test = new Database("test");
        var db = test.GetDatabase("config");
    }

    // Update is cal led once per frame
    void Update()
    {

    }
}
