using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RateComponent : MonoBehaviour
{

    public CanvasGroup canvasGroup;

    public void Open()
    {
        gameObject.SetActive(true);
        canvasGroup.alpha = 0.0f;
    }

    void Update()
    {
        if(canvasGroup.alpha < 1)
        {
            canvasGroup.alpha += 0.01f;
        }
    }


}
