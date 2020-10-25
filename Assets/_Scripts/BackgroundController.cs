using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    private void _Reset()
    {
        transform.position = new Vector3(mHorizontalBoundary, 0.0f);
    }

    private void _Move()
    {
        transform.position -= new Vector3(mHorizontalSpeed, 0.0f) * Time.deltaTime;
    }

    private void _CheckBounds()
    {
        // if the background is lower than the bottom of the screen then reset
        if (transform.position.x <= -mHorizontalBoundary)
        {
            _Reset();
        }
    }
}
