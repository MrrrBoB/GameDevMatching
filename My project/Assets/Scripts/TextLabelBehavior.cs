
using System.Globalization;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
[RequireComponent(typeof(Text))]
public class TextLabelBehavior : MonoBehaviour
{

    public Text label;
    public IntData dataObj;
    public UnityEvent startEvent, changeEvent;


    private void Start()
    {
        label = GetComponent<Text>();
        startEvent.Invoke();
    }

    public void UpdateText(FloatData obj)
    {
        label.text = obj.GetNum().ToString(CultureInfo.InvariantCulture);
    }
    public void UpdateText(IntData obj)
    {
        label.text = obj.GetNum().ToString();
    }
}
