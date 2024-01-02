using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SettingManager : MonoBehaviour
{
    private Color bgColor;
    private Color fontColor;
    private string showContent;
    private int fontSize;
    private int moveSpeed;
    public Button startBtn;
    private void Start()
    {
        startBtn.onClick.AddListener(OnStartBtnClick);
    }
    private void OnStartBtnClick()
    {
        bgColor = transform.Find("BGImg").GetComponent<Image>().color;
        fontColor = transform.Find("FontImg").GetComponent<Image>().color;
        showContent = transform.Find("ContentIF").GetComponent<InputField>().text;
        fontSize =int.Parse( transform.Find("FontSizeIF").GetComponent<InputField>().text);
        moveSpeed = int.Parse( transform.Find("MoveSpeedIF").GetComponent<InputField>().text);

        WorkingManager.ShowWorkingPanel?.Invoke(bgColor, fontColor, showContent, fontSize, moveSpeed);
    }
}
