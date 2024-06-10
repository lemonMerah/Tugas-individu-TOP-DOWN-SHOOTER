using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyMoveable : MonoBehaviour
{
    private Vector3 direction;
    public float speed = 1;

    // Update is called once per frame
    void Update()
    {
        UpdatePosition();
    }

    void UpdatePosition()
    {
        transform.position = transform.position + direction * Time.deltaTime * speed;
    }

    public void setDirection(Vector3 value)
    {
        direction = value;
    }

    public void setDirection(Vector2 value)
    {
        direction.x = value.x;
        direction.y = value.y;
    }

    internal void setXDirection(float v)
    {
        direction.x = v;
    }

    internal void setYDirection(float v)
    {
        direction.y = v;
    }
    public Vector3 getNextPosition()
    {
        return transform.position + (direction * Time.deltaTime * speed);
    }
}