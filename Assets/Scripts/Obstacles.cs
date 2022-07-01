using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacles : MonoBehaviour
{
    [SerializeField] private float Obstacles_speed;

    private void FixedUpdate()
    {
        transform.Translate(Obstacles_speed * Time.deltaTime, 0, 0);
    }
}
