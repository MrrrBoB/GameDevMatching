using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
[CreateAssetMenu]
public class IntData : ScriptableObject
{
  private int num;

  public void SetNum(int val)
  {
    num = val;
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
