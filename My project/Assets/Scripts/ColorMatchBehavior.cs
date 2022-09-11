using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorMatchBehavior : MatchBehaviour
{
    public ColorIDListData colorDataListObj;
    private void Awake()
    {
        idObj = colorDataListObj.currentColor;
    }

    public void ChangeMaterial(MeshRenderer renderer)
    {
        var newColor = idObj as ColorID;
        renderer.material = newColor.mat;
    }
}
