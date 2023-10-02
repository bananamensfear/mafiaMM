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
    [SerializeField] GameObject coin;
    public TextMeshProUGUI moneyDisplay;
    public  float money ;
    public float[] MoneyCollect;
    int coinLevel;
    float coinSpawnTimer;
    [SerializeField] float collectCoinTimer;
    [SerializeField] Upgrades upgradeScript;
    [SerializeField] float workerCollectDelay;
    [SerializeField] bool workerCanCollectCoin = true;
    [SerializeField] Image workerTimerObject;
    [SerializeField] upgradesCode upgradeCodeScript;

    public void AddMoney(GameObject coin)
    {
        if (workerCanCollectCoin)
        {
            Destroy(coin);
            money += upgradeScript.ValueOfCoin[upgradeCodeScript.upgrade3CurrentOn];
            moneyDisplay.text = "Money = " + money.ToString(".00");
            workerCanCollectCoin = false;
            
        }
    }
    void Update()
    {
        CoinSpawnerTimer();

        if (!workerCanCollectCoin)
        {
            WorkerCollectDelay();
        }
    }

    void CoinSpawnerTimer()
    {
        cooldown.fillAmount -= 1.0f / coinSpawnTimer * Time.deltaTime;
        if (cooldown.fillAmount <= 0f)
        {
            Instantiate(coin, transform.position, transform.rotation);
            coinSpawnTimer = upgradeScript.TimeToRegeneratCoin[upgradeCodeScript.upgrade1CurrentOn];
            cooldown.fillAmount = 1.0f;

        }
    }

    void WorkerCollectDelay()
    {
        workerCollectDelay = upgradeScript.TimeForWorkerCoin[upgradeCodeScript.upgrade2CurrentOn];
        workerTimerObject.enabled = true;
        workerTimerObject.fillAmount -= 1.0f / upgradeScript.TimeForWorkerCoin[upgradeCodeScript.upgrade2CurrentOn] * Time.deltaTime;

        if (workerTimerObject.fillAmount <= 0)
        {
            workerCanCollectCoin = true;
        
            workerTimerObject.fillAmount = 1;
            workerTimerObject.enabled = false;
        }
    }
}