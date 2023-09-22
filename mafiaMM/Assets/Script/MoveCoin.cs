using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class MoveCoin : MonoBehaviour
{
    [SerializeField] Transform spawn;
    Rigidbody2D rb;
    Vector2 move = new Vector2(3, 0);
    CircleCollider2D collision;

    timer Timer ;
   
    void Start()
    {
        spawn = GameObject.Find("money maker").transform;
        collision = GetComponent<CircleCollider2D>();
        rb = GetComponent<Rigidbody2D>();
        transform.position = spawn.position;
        Timer = FindObjectOfType<timer>();
    }

    
    void Update()
    {
        rb.velocity = move;
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.CompareTag("CoinCollector"))
        {
            Timer.AddMoney(gameObject);
        }
        else if(other.CompareTag("CoinDestroyer"))
        {
            Destroy(gameObject);
        }
    }
    
}
