using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreBox : MonoBehaviour
{
    [Range(0, 6)]
    public float Speed = 2;
    void Update()
    {
        transform.Translate(Vector2.left * Time.deltaTime * Speed);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Debug.Log("Player Hit Me");
        }
    }
}
