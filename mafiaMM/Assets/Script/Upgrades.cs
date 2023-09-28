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
    void Start()
    {
        
    }

    void Update()
    {
        
    }
    
}
