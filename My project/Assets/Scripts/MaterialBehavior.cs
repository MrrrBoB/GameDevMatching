using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Material))]
public class MaterialBehavior : MonoBehaviour
{
    private MeshRenderer matRenderer;
    void Awake()
    {
        matRenderer = GetComponent<MeshRenderer>();
    }

    public void ChangeMaterialColor(ColorID obj)
    {
        matRenderer.material = obj.mat;
        Debug.Log("Changed Color");
    }

   
}
