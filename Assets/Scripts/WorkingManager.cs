using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WorkingManager : MonoBehaviour
{
    private Image bgImg;
    private Text text;
    public static Action<Color, Color, string, int, int> ShowWorkingPanel;
    // Start is called before the first frame update
    void Start()
    {
        bgImg = transform.Find("Image").GetComponent<Image>();
        text = transform.Find("Text").GetComponent<Text>();

        ShowWorkingPanel += OnShow;
        gameObject.SetActive(false);
    }
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            OnClose();
        }
    }
    private void OnShow(Color bgColor, Color fontColot, string content, int fontSize, int moveSpeed)
    {
        bgImg.color = bgColor;
        text.color = fontColot;
        text.text = content;
        text.fontSize = fontSize;
        text.GetComponent<TextMoveManager>().moveSpeed = moveSpeed;
        gameObject.SetActive(true);
        text.gameObject.SetActive(true);
    }
    private void OnClose()
    {
        text.gameObject.SetActive(false);
        gameObject.SetActive(false);
    }
}
