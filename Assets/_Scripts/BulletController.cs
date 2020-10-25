/*
Source File Name: BulletController.cs
Student Name: Ramin Amiri
StudentID: 101190944
Date Last Modified: 2020-10-24
Program Description: Controls the bullet movement.
Revision Histroy: Modified for the bullets to move horizontally and not vertically.
*/

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

//Controls the movement of the bullet.
public class BulletController : MonoBehaviour, IApplyDamage
{
    //public float verticalSpeed;
    //public float verticalBoundary;
    public float mHorizontalSpeed;
    public float mHorizontalBoundary;
    public BulletManager bulletManager;
    public int damage;
    
    // Start is called before the first frame update
    void Start()
    {
        bulletManager = FindObjectOfType<BulletManager>();
    }

    // Update is called once per frame
    void Update()
    {
        _Move();
        _CheckBounds();
    }

    //Moves the bullet.
    private void _Move()
    {
        transform.position += new Vector3(mHorizontalSpeed, 0.0f, 0.0f) * Time.deltaTime;
    }

    //Check the bullet's bounds.
    private void _CheckBounds()
    {
        if (transform.position.x > mHorizontalBoundary)
        {
            bulletManager.ReturnBullet(gameObject);
        }
    }

    //If a bullet hits an enemy.
    public void OnTriggerEnter2D(Collider2D other)
    {
        //Debug.Log(other.gameObject.name);
        bulletManager.ReturnBullet(gameObject);
    }

    //Applies damage to what is hit.
    public int ApplyDamage()
    {
        return damage;
    }
}
