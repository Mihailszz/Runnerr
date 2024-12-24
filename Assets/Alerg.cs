using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Alerg : MonoBehaviour
{

    public Vector2 speed;
    public Vector2 direction;

    private void Update()
    {
        Vector3 movement = new Vector3(speed.x*direction.x,0,0);
        movement *= Time.deltaTime;
        transform.Translate(movement);

    }
}
