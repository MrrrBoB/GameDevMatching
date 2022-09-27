using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[CreateAssetMenu]
public class ColorIDListData : ScriptableObject
{
    public List<ColorID> colorIDList;
    public ColorID currentColor;
    private int num;

    public void SetCurrentColorRandom()
    {
        num = Random.Range(0, colorIDList.Count);
        currentColor = colorIDList[num];
    }
}
