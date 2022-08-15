using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGScroll : MonoBehaviour
{

    public float scroll_Speed = 0.3f;

    private MeshRenderer mesh_renderer;
    void Awake() 
    {
        mesh_renderer = GetComponent<MeshRenderer>();
    }
    
    // Update is called once per frame
    void Update()
    {
        
    }
    void Scroll() 
    {
        Vector2 offset = mesh_renderer.sharedMaterial.GetTextureOffset("_MainTex");
    }
}
