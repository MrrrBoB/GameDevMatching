using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

[CreateAssetMenu]
public class IntData : ScriptableObject
{
  public int num;
 
  public void SetNum(int val)
  {
    num = val;
  }
  public void SetNum(IntData dataObj)
  {
    num = dataObj.GetNum();
  }

  public void CompareValue(IntData dataObj)
  {
    num = dataObj.GetNum() > num ? dataObj.GetNum() : num;
  }
  public void UpdateValue(int val)
  {
    num += val;
  }

  public int GetNum()
  {
    return num;
  }

  public void DisplayInText(Text txt)
  {
    txt.text = num.ToString();
  }

  public void DisplayInImage(Image img)
  {
    img.fillAmount = num;
  }
  
}
