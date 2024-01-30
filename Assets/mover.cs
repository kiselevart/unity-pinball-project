using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public float moveSpeed = 20f;
    void Update()
    {
        float delta = Input.GetAxis("Horizontal") * moveSpeed * Time.deltaTime;
        transform.Translate(delta,0,0);

        float x = transform.position.x;
        float y = transform.position.y;
        float z = transform.position.z;

        if (x < -1) {
            Vector3 targetPosition = new Vector3(-1,y,z);
            transform.position = targetPosition;
        }
        if (x > 1) {
            Vector3 targetPosition = new Vector3(1,y,z);
            transform.position = targetPosition;
        }
    }
}
