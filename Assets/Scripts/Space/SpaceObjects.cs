using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class SpaceObjects
{
    public static GameObject CreateSphereObject(string name, Vector3 position, Transform parent = null){
        GameObject sphere = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        sphere.name = name;
        sphere.transform.position = position;
        sphere.transform.parent = parent;

        return sphere;
    }
}
