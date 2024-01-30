using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouner : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other) {
        if (other.gameObject.tag == "Ball") {
            Debug.Log("The Ball is hitting.");
        }
    }
}
