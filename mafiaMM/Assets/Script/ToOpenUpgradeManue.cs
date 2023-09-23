using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ToOpenUpgradeManue : MonoBehaviour
{
    [SerializeField] GameObject objToTurnOff ;
    void Start()
    {
        
    }

    void Update()
    {
    }
    public void OpenUpgradeManu()
    {
        objToTurnOff.SetActive (true);

    }
}
