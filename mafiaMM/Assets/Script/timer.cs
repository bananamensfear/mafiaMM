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
    [SerializeField] TMP_Text moneyDisplay;
    float money = 0;
    public float[] MoneyCollect;
    int coinLevel;
    float coinSpawnTimer;

    [SerializeField] float collectCoinTimer;
    [SerializeField] float workerCollectDelay;
    [SerializeField] bool workerCanCollectCoin = true;
    [SerializeField] Image workerTimerObject;

    public void AddMoney(GameObject coin)
    {
        if (workerCanCollectCoin)
        {
            Destroy(coin);
            money += MoneyCollect[coinLevel];
            moneyDisplay.text = "Money = " + money.ToString(".00");
            workerCanCollectCoin = false;
            collectCoinTimer = workerCollectDelay;
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
            coinSpawnTimer = waitTime;
            cooldown.fillAmount = 1.0f;

        }
    }

    void WorkerCollectDelay()
    {
        collectCoinTimer -= Time.deltaTime;
        workerTimerObject.fillAmount = collectCoinTimer / workerCollectDelay;

        if (collectCoinTimer < 0)
        {
            workerCanCollectCoin = true;
            collectCoinTimer = workerCollectDelay;
            workerTimerObject.fillAmount = workerCollectDelay;
        }
    }
}