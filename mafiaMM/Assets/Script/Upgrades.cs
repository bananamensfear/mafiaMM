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
}
