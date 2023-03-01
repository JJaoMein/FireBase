using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flappy_Controller : MonoBehaviour
{
    [SerializeField] Rigidbody2D rb2D;
    [SerializeField] float impulse;

    public GameManager manager;

    private void Awake()
    {
        if (rb2D == null)
        {
            rb2D = GetComponent<Rigidbody2D>();

        }
    }
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2D.velocity = Vector2.up * impulse;
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        manager.GameOver();
    }
}
