using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnObstacle : MonoBehaviour
    {
   public Rigidbody2D projectile;
    void Update() {
        if (Input.GetButtonDown("Jump")) {
            Rigidbody2D clone;
            clone = Instantiate(projectile, transform.position, transform.rotation) as Rigidbody2D;
            clone.velocity = transform.TransformDirection(Vector2.left * 2);
        }
    }
}