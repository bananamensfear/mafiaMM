using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro ;
[CreateAssetMenu(menuName = "Upgrades", fileName = "New Upgrade")]
public class Upgrades : ScriptableObject
{
    public float[] TimeToRegeneratCoin;
    public float[] TimeForWorkerCoin;
    public float[] ValueOfCoin;
    public float[] TimeToRegeneratCoinCost;
    public float[] TimeForWorkerCoinCost;
    public float[] ValueOfCoinCost;
    public static string TimeToRegeneratCoinText;
    public static string TimeForWorkerCoinText;
    public static string ValueOfCoinText;
    public string TimeToRegeneratCoinText1;
    public string TimeForWorkerCoinText1;
    public string ValueOfCoinText1;
    void Start()
    {
        TimeToRegeneratCoinText = TimeToRegeneratCoinText1;
        TimeForWorkerCoinText = TimeForWorkerCoinText1;
        ValueOfCoinText = ValueOfCoinText1;
        Debug.Log(ValueOfCoinText);
    }
    public float upgradeMachineTime(int index)
    {
        return TimeToRegeneratCoin[index];
    }
    public float UpgradeWorkerTime(int index)
    {
        return TimeForWorkerCoin[index];
    }
    public float UpgradeValueOfCoin(int index)
    {
        return ValueOfCoin[index];
    }
    public float upgradeMachineTimeCost(int index)
    {
        return TimeToRegeneratCoinCost[index];
    }
    public float UpgradeWorkerTimeCost(int index)
    {
        return TimeForWorkerCoinCost[index];
    }
    public float UpgradeValueOfCoinCost(int index)
    {
        return ValueOfCoinCost[index];

    }
    public string allText()
    {
        return TimeToRegeneratCoinText;
        return TimeForWorkerCoinText;
        return ValueOfCoinText;
        return TimeToRegeneratCoinText1;
        return TimeForWorkerCoinText1;
        return ValueOfCoinText1;
    }
}
