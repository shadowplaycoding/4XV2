using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpaceObjects
{
    public static GameObject CreateShereObject(Vector3 position){
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.transform.position = position;

        return sphere;
    }
}
