using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Script1 : MonoBehaviour
{
    public Button Rate_Button;

    public RateComponent rateDialog;

    void Start()
    {
        Rate_Button.onClick.AddListener(OnRate);
    }

    void OnRate()
    {
        rateDialog.Open();
        //Debug.log("Messege")
    }

    void Update()
    {
        
    }
}