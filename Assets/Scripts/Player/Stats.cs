using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stats : MonoBehaviour {

    public float health;
    public float armor;
    public float playerSpeed;
    public float fireRate;
    public float bulletSpeed;
    public float bulletPower;


	// Use this for initialization
	void Start () {
    health = 10;
    armor = 1;
    playerSpeed = 5;
    fireRate = .2f;
    bulletSpeed = 10;
    bulletPower = 5;

}

// Update is called once per frame
void Update () {
        if (health < 1)
        {
            Destroy(gameObject);
        }
    }
}
