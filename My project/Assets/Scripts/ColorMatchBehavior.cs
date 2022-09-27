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

    public void ChangeMaterial(MeshRenderer Mrend)
    {
        var newColor = idObj as ColorID;
        if (newColor != null) Mrend.material = newColor.mat;
    }
}
