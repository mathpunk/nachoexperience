using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MyStringManager : MonoBehaviour {

    #region Variables
    #region Text Vars
    Text textComponent;

    string sampleStr = "This is a test to see if this script actually works.";

    int strIndex = 0;
    #endregion Text Vars

    #region Time Vars
    float currentTime = Mathf.Epsilon, maxTime = 1f;
    #endregion Time Vars

    #region Adjustable Vars
    [Range(1, 200)]
    [SerializeField]
    float speechSpeed = 20f, bubbleBufferX = 50f, bubbleBufferY = 30f;
    #endregion Adjustable Vars

    #region Rectangle Transforms
    RectTransform textRectTrans, bubbleRecTrans, dotsRectTrans;
    #endregion Rectangle Tranforms
    #endregion Varables

    // Use this for initialization
    void Start ()
    {
        InitializeComponents();
        ClearText();
    }

    // Update is called once per frame
    void Update ()
    {
        BuildTextBox();
        ResizeThoughtBubble();
        PositionThoguhtDots();

        //if (strIndex >= sampleStr.Length)
        //{
        //    ClearText();
        //}
    }

    private void InitializeComponents()
    {
        textComponent = transform.Find("Text").GetComponent<Text>();
        textRectTrans = transform.Find("Text").GetComponent<RectTransform>();
        bubbleRecTrans = transform.Find("ThoughtBubbleGroup").
            Find("ThoughtBubble").GetComponent<RectTransform>();
        dotsRectTrans = transform.Find("ThoughtBubbleGroup").
            Find("ThoughtDots").GetComponent<RectTransform>();

        textComponent.text = "";
    }

    private void BuildTextBox()
    {
        currentTime += Time.deltaTime * speechSpeed;

        if (strIndex < sampleStr.Length && currentTime >= maxTime)
        {
            textComponent.text += sampleStr[strIndex];
            strIndex++;

            currentTime = Mathf.Epsilon;
        }
    }

    private void ResizeThoughtBubble()
    {
        bubbleRecTrans.sizeDelta = textRectTrans.sizeDelta + new Vector2(bubbleBufferX, bubbleBufferY);
    }

    private void PositionThoguhtDots()
    {
        dotsRectTrans.localPosition = new Vector3(
                        -bubbleRecTrans.sizeDelta.x / 2 + dotsRectTrans.sizeDelta.x / 2,
                        -bubbleRecTrans.sizeDelta.y / 2 - dotsRectTrans.sizeDelta.y / 2,
                        Mathf.Epsilon
                );
    }

    private void ClearText()
    {
            textComponent.text = "";
            strIndex = 0;
    }
}
