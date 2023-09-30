using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class upgradesCode : MonoBehaviour
{
   [SerializeField] Upgrades upgrade1;
    public int upgrade1CurrentOn;
    public int upgrade2CurrentOn;
    public int upgrade3CurrentOn;
    public TextMeshProUGUI upgrade1Text;
    public TextMeshProUGUI upgrade2Text;
    public TextMeshProUGUI upgrade3Text;
    Upgrades upgradeScript;
    void Start()
    {
        upgradeScript = FindObjectOfType<Upgrades>();
        upgrade1Text.text = (Upgrades.TimeToRegeneratCoinText);
        upgrade2Text.text = (Upgrades.TimeForWorkerCoinText);
        upgrade3Text.text = (Upgrades.ValueOfCoinText);
    }

    void Update()
    {
        
    }
}
