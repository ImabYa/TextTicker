using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;
using System;
public enum RBGAType
{
    R, G, B, A
}

public class SliderValueChanged : MonoBehaviour
{
    public Image image;
    public RBGAType rgbaType;
    private Slider slider;
    private InputField inputField;

    void Start()
    {
        slider = GetComponent<Slider>();
        inputField = GetComponentInChildren<InputField>();

        inputField.onValueChanged.AddListener(OnInputFieldValueChanged);
        slider.onValueChanged.AddListener(OnSliderValueChanged);

        SliderInit();
    }
    void SliderInit()
    {
        switch (rgbaType)
        {
            case RBGAType.R:
                slider.value = image.color.r;
                break;
            case RBGAType.G:
                slider.value = image.color.g;
                break;
            case RBGAType.B:
                slider.value = image.color.b;
                break;
            case RBGAType.A:
                slider.value = image.color.a;
                break;
            default:
                break;
        }
    }

    private void OnSliderValueChanged(float value)
    {
        //Debug.Log(value);
        inputField.text = value.ToString("F3");
        switch (rgbaType)
        {
            case RBGAType.R:
                image.color = new Color(value, image.color.g, image.color.b, image.color.a);
                break;
            case RBGAType.G:
                image.color = new Color(image.color.r, value, image.color.b, image.color.a);
                break;
            case RBGAType.B:
                image.color = new Color(image.color.r, image.color.g, value, image.color.a);
                break;
            case RBGAType.A:
                image.color = new Color(image.color.r, image.color.g, image.color.b, value);
                break;
            default:
                break;
        }
    }

    private void OnInputFieldValueChanged(string content)
    {
        try
        {
            slider.value = float.Parse(content);
        }
        catch (Exception e)
        {
            Debug.Log("输入内容不合法" + e.Message);
        }
    }
}
