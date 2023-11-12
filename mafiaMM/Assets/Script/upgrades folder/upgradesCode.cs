using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class upgradesCode : MonoBehaviour
{
   [SerializeField] Upgrades upgrade1;
    public int upgrade1CurrentOn = 0;
    public int upgrade2CurrentOn = 0;
    public int upgrade3CurrentOn = 0;
    public TextMeshProUGUI upgrade1Text;
    public TextMeshProUGUI upgrade2Text;
    public TextMeshProUGUI upgrade3Text;
    public TextMeshProUGUI buttomUpgrade1Text;
    public TextMeshProUGUI buttomUpgrade2Text;
    public TextMeshProUGUI buttomUpgrade3Text;

    [SerializeField] timer timerScript;
     
    void Start()
    {
        
        upgrade1Text.text = ($"{ upgrade1.TimeToRegeneratCoinText1}  { upgrade1CurrentOn} - {upgrade1CurrentOn + 1}");
        upgrade2Text.text = ($"{ upgrade1.TimeForWorkerCoinText1}  { upgrade2CurrentOn} - {upgrade2CurrentOn + 1}");
        upgrade3Text.text = ($"{ upgrade1.ValueOfCoinText1}  { upgrade3CurrentOn} - {upgrade3CurrentOn + 1}");
        buttomUpgrade1Text.text = ($"${upgrade1.TimeToRegeneratCoinCost[upgrade1CurrentOn]}");
        buttomUpgrade2Text.text = ($"${upgrade1.TimeForWorkerCoinCost[upgrade2CurrentOn]}");
        buttomUpgrade3Text.text = ($"${upgrade1.ValueOfCoinCost[upgrade3CurrentOn]}");
        
    }

    void Update()
    {
        
    }
    public void buttom1Upgrade()
    {

        if (timerScript.money >= upgrade1.TimeToRegeneratCoinCost[upgrade1CurrentOn] &&upgrade1.TimeToRegeneratCoinCost[upgrade1CurrentOn]!= 0)
        {
            
            upgrade1CurrentOn ++ ;
            upgrade1Text.text = ($"{ upgrade1.TimeToRegeneratCoinText1}  { upgrade1CurrentOn} - {upgrade1CurrentOn + 1}");
            buttomUpgrade1Text.text = ($"${upgrade1.TimeToRegeneratCoinCost[upgrade1CurrentOn]}");
            timerScript.money -= upgrade1.TimeToRegeneratCoinCost[upgrade1CurrentOn - 1];
            timerScript.moneyDisplay.text = ($"Money =   { timerScript.money.ToString(".00")}");
            if (upgrade1.TimeToRegeneratCoinCost[upgrade1CurrentOn ]== 0)
            {
                buttomUpgrade1Text.text = ("max upgrade");
            }

        }
         else
        {
            buttomUpgrade1Text.text = ("max upgrade");
        }   
    }
    public void buttom2Upgrade()
    {
        if (timerScript.money >= upgrade1.TimeForWorkerCoinCost[upgrade2CurrentOn] && upgrade1.TimeForWorkerCoinCost[upgrade2CurrentOn]!= 0)
        {
            upgrade2CurrentOn += 1;
            upgrade2Text.text = ($"{ upgrade1.TimeForWorkerCoinText1}  { upgrade2CurrentOn} - {upgrade2CurrentOn + 1}");
            buttomUpgrade2Text.text = ($"${upgrade1.TimeForWorkerCoinCost[upgrade2CurrentOn]}");
            timerScript.money -= upgrade1.TimeForWorkerCoinCost[upgrade2CurrentOn - 1];
            timerScript.moneyDisplay.text = ($"Money =   { timerScript.money.ToString(".00")}");
            if (upgrade1.TimeForWorkerCoinCost[upgrade2CurrentOn+ 1] == 0)
            {
            buttomUpgrade2Text.text = ("max upgrade");
            }
        }
    }
    public void buttom3Upgrade()
    {
        if (timerScript.money >= upgrade1.ValueOfCoinCost[upgrade3CurrentOn] &&upgrade1.ValueOfCoinCost[upgrade3CurrentOn]!= 0)
        {
            upgrade3CurrentOn += 1;
            upgrade3Text.text = ($"{ upgrade1.ValueOfCoinText1}  { upgrade3CurrentOn} - {upgrade3CurrentOn + 1}");
            upgrade3Text.text = ($"{ upgrade1.TimeForWorkerCoinText1}  { upgrade3CurrentOn} - {upgrade3CurrentOn + 1}");
            buttomUpgrade3Text.text = ($"${upgrade1.ValueOfCoinCost[upgrade3CurrentOn]}");
            timerScript.money -= upgrade1.ValueOfCoinCost[upgrade3CurrentOn - 1];
            timerScript.moneyDisplay.text = ($"Money =   { timerScript.money.ToString(".00")}");
            if (upgrade1.ValueOfCoinCost[upgrade3CurrentOn+ 1] == 0)
            {
            buttomUpgrade3Text.text = ("max upgrade");
            }
        }
        
           
    }
}
