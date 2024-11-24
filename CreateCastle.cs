using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateCastle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(0, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(1, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cube).transform.position = new Vector3(-1, 0, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(-1, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Cylinder).transform.position = new Vector3(1, 1, 0);
        GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(1, 2f, 0);
        GameObject.CreatePrimitive(PrimitiveType.Sphere).transform.position = new Vector3(-1, 2f, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
