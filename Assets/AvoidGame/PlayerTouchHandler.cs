using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTouchHandler : MonoBehaviour
{
    public float Speed = 10;
    public float MinY = -3.5f;
    public float MaxY = 3.5f;


    public float MinX = -8.5f;
    public float MaxX = 8.5f;

    Vector2 targetPosition;

    // Start is called before the first frame update
    void Start()
    {
        targetPosition.x = transform.position.x;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, Time.deltaTime * Speed);

        if (Input.GetMouseButton(0))
        {
            HandleMoveToPosition(Input.mousePosition);
        }

        if (Input.touches.Length > 0)
        {
            HandleMoveToPosition(Input.touches[0].position);
        }
    }

    public void HandleMoveToPosition(Vector3 RawPosition)
    {
        var position = Camera.main.ScreenToWorldPoint(RawPosition);
        if (position.y > MaxY)
        {
            position.y = MaxY;
        }
        if (position.y < MinY)
        {
            position.y = MinY;
        }

        if (position.x > MaxX)
        {
            position.x = MaxX;
        }
        if (position.x < MinX)
        {
            position.x = MinX;
        }

        targetPosition.y = position.y;
        targetPosition.x = position.x;

    }
}
