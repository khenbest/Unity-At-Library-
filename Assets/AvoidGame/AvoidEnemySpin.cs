using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AvoidEnemySpin : MonoBehaviour
{
    public Vector2 Direction;
    public List<Vector2> Directions = new List<Vector2>() { Vector2.down, Vector2.left, Vector2.right, Vector2.up };
    public float Speed; 
    public float SpinSpeed = 20;
    public int Index;
    // Start is called before the first frame update
    void Start()
    {
        Speed = Random.Range(2, 7);
        Index = Random.Range(0, 3);
        Direction = Directions[Index];
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(new Vector3(0, 0, 1) * Time.deltaTime * SpinSpeed * 10);
        transform.Translate(Direction * Time.deltaTime * Speed);

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {

            Destroy(collision.gameObject);
            Destroy(gameObject);
        }
    }
}
