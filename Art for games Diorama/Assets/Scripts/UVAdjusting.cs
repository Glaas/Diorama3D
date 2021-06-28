using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UVAdjusting : MonoBehaviour
{
    public Vector2 textOffset = Vector2.one;
    public Vector2 textScale = Vector2.one;
    public MeshRenderer meshRenderer;
    
    

    void Update()
    {
        meshRenderer = GetComponent<MeshRenderer>();
        meshRenderer.material.mainTextureOffset = textOffset;
        meshRenderer.material.mainTextureScale = textScale;
        
    }
}