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
        upgrade1CurrentOn += 1;
        upgrade1Text.text = ($"{ upgrade1.TimeToRegeneratCoinText1}  { upgrade1CurrentOn} - {upgrade1CurrentOn + 1}");
        buttomUpgrade1Text.text = ($"${upgrade1.TimeToRegeneratCoinCost[upgrade1CurrentOn]}");
    }
    public void buttom2Upgrade()
    {
        upgrade2CurrentOn += 1;
        upgrade2Text.text = ($"{ upgrade1.TimeForWorkerCoinText1}  { upgrade2CurrentOn} - {upgrade2CurrentOn + 1}");
        buttomUpgrade2Text.text = ($"${upgrade1.TimeForWorkerCoinCost[upgrade2CurrentOn]}");
    }
    public void buttom3Upgrade()
    {
        upgrade3CurrentOn += 1;
        upgrade3Text.text = ($"{ upgrade1.ValueOfCoinText1}  { upgrade3CurrentOn} - {upgrade3CurrentOn + 1}");
        buttomUpgrade2Text.text = ($"${upgrade1.TimeForWorkerCoinCost[upgrade2CurrentOn]}");
        buttomUpgrade3Text.text = ($"${upgrade1.ValueOfCoinCost[upgrade3CurrentOn]}");
    }
}
