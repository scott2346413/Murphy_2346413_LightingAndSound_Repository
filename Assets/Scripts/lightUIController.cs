using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class lightUIController : MonoBehaviour
{
    [SerializeField] Light targetLight;
    [SerializeField] UnityEngine.UI.Slider intensity;

    [SerializeField] UnityEngine.UI.Slider red;
    [SerializeField] UnityEngine.UI.Slider green;
    [SerializeField] UnityEngine.UI.Slider blue;

    private void Start()
    {
        setIntensity();
        setColour();
    }

    public void setIntensity()
    {
        targetLight.intensity = intensity.value;
    }

    public void setColour()
    {
        Color color = new Color();

        color.r = red.value / 255;
        color.g = green.value / 255;
        color.b = blue.value / 255;

        targetLight.color = color;
    }
}
