using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteAlways]
public class UVAdjusting : MonoBehaviour
{
    public Vector2 textOffset = Vector2.one;
    public Vector2 textScale = Vector2.one;
    public MeshFilter filter;
    public Mesh mesh;
    public MeshRenderer meshRenderer;

    private void Start()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        filter = GetComponent<MeshFilter>();
        mesh = filter.mesh;
        
    }

    void Update()
    {
        meshRenderer.material.mainTextureOffset = textOffset;
        meshRenderer.material.mainTextureScale = textScale;
    }
}