/*
Source File Name: BackgroundController.cs
Student Name: Ramin Amiri
StudentID: 101190944
Date Last Modified: 2020-10-24
Program Description: Operates the background scrolling.
Revision Histroy: Modified to scroll horizontally and not vertically.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controls background
public class BackgroundController : MonoBehaviour
{
    //old values for scrolling vertically
    //public float verticalBoundary;
    //public float verticalSpeed;
    public float mHorizontalSpeed;
    public float mHorizontalBoundary;

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    //Reset background position
    private void _Reset()
    {
        transform.position = new Vector3(mHorizontalBoundary, 0.0f);
    }

    //Moves background
    private void _Move()
    {
        transform.position -= new Vector3(mHorizontalSpeed, 0.0f) * Time.deltaTime;
    }

    //Checks bounds
    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -mHorizontalBoundary)
        {
            _Reset();
        }
    }
}
