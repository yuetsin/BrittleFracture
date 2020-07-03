﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Splitter : MonoBehaviour
{
    public Material m;
    // Start is called before the first frame update
    void Start()
    {
        var g = new GameObject("Tetra");
        var sb = g.AddComponent<ShaderBase>();
        sb.material = m;
        
        List<Vector3> vectors = new List<Vector3>
        {
            new Vector3(0.0f, 0.0f, 0.0f),
            new Vector3(10.0f, 0.0f, 0.0f),
            new Vector3(0.0f, 10.0f, 0.0f),
            new Vector3(0.0f, 0.0f, 10.0f),
            new Vector3(0.0f, 10.0f, 10.0f),
            new Vector3(10.0f, 10.0f, 0.0f)
        };
        List<Vector3> vectors2 = new List<Vector3>
        {
            new Vector3(10.0f, 0.0f, 10.0f),
            new Vector3(10.0f, 0.0f, 0.0f),
            new Vector3(10.0f, 10.0f, 10.0f),
            new Vector3(0.0f, 0.0f, 10.0f),
            new Vector3(0.0f, 10.0f, 10.0f),
            new Vector3(10.0f, 10.0f, 0.0f)
        };
        
        sb.tetraPart.PushBackTriPrism(vectors);
        sb.tetraPart.PushBackTriPrism(vectors2);
        /*
        List<Vector3> vectors = new List<Vector3>
        {
            new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f)),
            new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f)),
            new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f)),
            new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), Random.Range(-5f, 5f)),
        };
        sb.tetraPart.PushBackTetra(vectors);
        */
        for (int i = 0; i < 3; i++)
        {
            sb.tetraPart.SplitSelf();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
