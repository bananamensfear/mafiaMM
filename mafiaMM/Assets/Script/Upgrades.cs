using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro ;
[CreateAssetMenu(menuName = "Upgrades", fileName = "New Upgrade")]
public class Upgrades : ScriptableObject 
{
    [SerializeField] float[] TimeToRegeneratCoin;
    [SerializeField] float[] TimeForWorkerCoin;
    [SerializeField] float[] ValueOfCoin;
    [SerializeField] float[] TimeToRegeneratCoinCost;
    [SerializeField] float[] TimeForWorkerCoinCost;
    [SerializeField] float[] ValueOfCoinCost;
    [SerializeField] string TimeToRegeneratCoinText;
    [SerializeField] string TimeForWorkerCoinText;
    [SerializeField] string ValueOfCoinText;
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
    }
}
