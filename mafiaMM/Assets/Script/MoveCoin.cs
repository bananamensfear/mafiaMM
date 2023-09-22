using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MoveCoin : MonoBehaviour
{
    [SerializeField] Transform spawn;
    float money = 0;
    Rigidbody2D rb;
    Vector2 move = new Vector2(3, 0);
    CircleCollider2D collision;
    [SerializeField] GameObject gameObj;
    [SerializeField] TMP_Text moneyDisplay;
   
    void Start()
    {
        collision = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        transform.position = spawn.position;
    }

    
    void Update()
    {
        rb.velocity = move;
    }

    private void OnCollisionEnter2D(Collision2D other) 
    {
        Destroy(gameObj);
       
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Destroy(gameObj);
        money += 0.1f;
        Debug.Log(money);
        moneyDisplay.text = "Money = " + money;

    }
    
}
