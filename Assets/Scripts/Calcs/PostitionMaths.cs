using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class PostitionMaths
{
    public static Vector3 RandomPolarPosition(float minRad, float maxRad){
        float distance = Random.Range(minRad, maxRad);
        float angle = Random.Range(0, 2 * Mathf.PI);

        Vector3 cartPosition = PolarToCart(distance, angle);

        return cartPosition;
    }

    public static Vector3 PolarToCart(float distance, float angle){

        float x = distance * Mathf.Cos(angle);
        float y = 0.0f;
        float z = distance * Mathf.Sin(angle);

        Vector3 cartPosition = new Vector3(x, y, z);

        return cartPosition;

    }
}
