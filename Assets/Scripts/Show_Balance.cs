using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Show_Balance : MonoBehaviour
{   
    public Slider slider;
    private float mVio = 0.0f;
    public float mySmoothTime = 0.2f;
    public bool clock;


    void Start()
    {
        clock = false;
    }

    // Update is called once per frame
    void Update()
    {
        float balance, rate, smooth;

        if (!clock)
        {
            balance = Player.balance;
            rate = balance / 100;
            smooth = Mathf.SmoothDamp(slider.value, rate, ref mVio, mySmoothTime);
            slider.value = smooth;
        }
        else
        {
            Player.balance = 50;
            balance = Player.balance;
        }
    }
}
