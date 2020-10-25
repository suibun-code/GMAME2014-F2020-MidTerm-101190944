/*
Source File Name: EnemyController.cs
Student Name: Ramin Amiri
StudentID: 101190944
Date Last Modified: 2020-10-24
Program Description: Controls the movement for the enemies.
Revision Histroy: Modified for the enemies to move vertically and not horizontally.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controls the movement on the enemies.
public class EnemyController : MonoBehaviour
{
    //public float horizontalSpeed;
    //public float horizontalBoundary;
    public float mVerticalSpeed;
    public float mVerticalBoundary;
    public float direction;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    private void _Move()
    {
        transform.position += new Vector3(0.0f, mVerticalSpeed * direction * Time.deltaTime, 0.0f);
    }

    private void _CheckBounds()
    {
        // check right boundary
        if (transform.position.y >= mVerticalBoundary)
        {
            direction = -1.0f;
        }

        // check left boundary
        if (transform.position.y <= -mVerticalBoundary)
        {
            direction = 1.0f;
        }
    }
}
