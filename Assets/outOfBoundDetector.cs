using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class outOfBoundDetector : MonoBehaviour
{
    private void OnTriggerEnter2D(Collision2D other) {
        if(other.gameObject.tag == "Ball") {
            Debug.Log("Trigger");
        }
    }
}
