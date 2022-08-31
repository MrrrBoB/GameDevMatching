
using UnityEngine;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{

    public Text label;
    public FloatData dataObj;


    private void Start()
    {
        label = GetComponent<Text>();
        UpdateText();
    }

    public void UpdateText()
    {
        label.text = dataObj.GetNum().ToString();
    }
}
