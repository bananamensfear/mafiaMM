using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class timer : MonoBehaviour
{
    [SerializeField] Image cooldown;
    [SerializeField] bool coolingDown;
    [SerializeField] float waitTime = 30.0f;
    [SerializeField] GameObject gameObjectPosiX;
    [SerializeField] GameObject gameObjectPosiY;
    [SerializeField] GameObject gameObject;

    float timer1;
    void Start()
    {
        float timer1 = waitTime;
    }
    void Update()
    {
        
        cooldown.fillAmount -= 1.0f/timer1 * Time.deltaTime;
        Debug.Log(timer1);
        if (cooldown.fillAmount <= 0f)
        {
            timer1 = waitTime;
            cooldown.fillAmount = 1.0f;
        }
    }
}
