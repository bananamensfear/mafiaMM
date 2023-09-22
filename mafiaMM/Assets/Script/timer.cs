using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class timer : MonoBehaviour
{
    [SerializeField] Image cooldown;
    [SerializeField] bool coolingDown;
    [SerializeField] float waitTime = 30.0f;
    [SerializeField] Vector3 coinStartingPos;
    [SerializeField] GameObject coin ;
    [SerializeField] TMP_Text moneyDisplay;
    float money = 0;
    public float[] MoneyCollect;
    int coinLevel;
    

    float timer1;
    void Start()
    {
        float timer1 = waitTime;
        
    }
    public void AddMoney()
    {
        money += MoneyCollect[coinLevel];
        moneyDisplay.text = "Money = " + money.ToString(".00");
        Debug.Log(money);
    }
    void Update()
    {

        cooldown.fillAmount -= 1.0f/timer1 * Time.deltaTime;
        if (cooldown.fillAmount <= 0f)
        {
            Instantiate(coin , transform.position, transform.rotation);
            timer1 = waitTime;
            cooldown.fillAmount = 1.0f;

        }
    }
}
