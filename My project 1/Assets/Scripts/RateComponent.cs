using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class RateComponent : MonoBehaviour
{

    public CanvasGroup canvasGroup;

    public Button CloseRate;
    
    public float OpenAnimation;

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
        var time = Time.time;
        var deltaTime = Time.deltaTime;

        Debug.Log($"Time : {time}, DeltaTime: {deltaTime}");

        if(canvasGroup.alpha < 1)
        {
            var deltaAlpha = deltaTime / OpenAnimation;

            canvasGroup.alpha += deltaAlpha;
        }
    }


}
