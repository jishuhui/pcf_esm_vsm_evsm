using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[ExecuteAlways]
public class Test : MonoBehaviour
{
    public enum ShadowmapSizeV
    {
        _256 = 256,
        _512 = 512,
        _1024 = 1024,
        _2048 = 2048,
        _4096 = 4096
    }
    public ShadowmapSizeV shadowmapSize = ShadowmapSizeV._1024;

    private void Awake()
    {
        int vol = (int) shadowmapSize;
        Debug.Log("阴影的大小为：" + vol);
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
