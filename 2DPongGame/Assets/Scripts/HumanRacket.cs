
using System;
using TMPro;
using UnityEngine;

public class HumanRacket : Racket
{
    String axisName = "Vertical1";

    protected override void Move()
    {
        float moveRACKET = Input.GetAxis(axisName) * moveSpeed;

        GetComponent<Rigidbody2D>().velocity = new Vector2(0, moveRACKET);

    }
}
