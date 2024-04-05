using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateComponent : MonoBehaviour
{

    public CanvasGroup canvasGroup;

    public Button CloseRate;

    private void Start()
    {
        CloseRate.onClick.AddListener(Close);
    }

    public void Open()
    {
        gameObject.SetActive(true);
        canvasGroup.alpha = 0.0f;
    }

    public void Close()
    {
        gameObject.SetActive(false);
    }

    void Update()
    {
        if(canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += 0.01f;
        }
    }


}
