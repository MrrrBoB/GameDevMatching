using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorIDBehavior : IDContainerBehavior
{
    public ColorIDListData colorDataListObj;
    // Start is called before the first frame update
    private void Awake()
    {
        idObj = colorDataListObj.currentColor;
    }
}
