using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TextMoveManager : MonoBehaviour
{
    public float moveSpeed=100;
    private Text text;
    private bool isInitSuccess = false;//初始化成功
    private float endPostionX;
    private void OnEnable()
    {
        text = GetComponent<Text>();
        StartCoroutine(IECalTextSice());
    }
    private void OnDisable()
    {
        isInitSuccess = false;
    }
    IEnumerator IECalTextSice()
    {
        yield return new WaitForEndOfFrame();
        text.rectTransform.localPosition = new Vector2(text.rectTransform.sizeDelta.x / 2 + Screen.width / 2, 0);
        endPostionX = -text.rectTransform.localPosition.x;
        isInitSuccess = true;
    }
    private void Update()
    {
        if (isInitSuccess)
        {
            if (text.rectTransform.localPosition.x<endPostionX)
            {
                text.rectTransform.localPosition = new Vector3(-endPostionX, 0, 0);
                return;
            }
            text.rectTransform.localPosition = text.rectTransform.localPosition += new Vector3(-0.01f*moveSpeed, 0, 0);
        }
    }
}
