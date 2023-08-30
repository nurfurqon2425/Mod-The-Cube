using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;
    public Vector3 pos;
    public float size;
    public float rotSpeed; 

    private float xRot;
    private float yRot;
    private float zRot;
    private int axis;
    private int counter;

    void Start()
    {
        
        Material material = Renderer.material;
        
        material.color = new Color(0.1f, 0.4f, 0.9f, 0.7f);

        counter = 0;
    }
    
    void Update()
    {
        transform.position = pos;
        transform.localScale = Vector3.one * size;

        if (counter == 1000)
        {
            xRot = Random.Range(-10.0f, 10.0f);
            yRot = Random.Range(-10.0f, 10.0f);
            zRot = Random.Range(-10.0f, 10.0f);

            axis = Random.Range(0, 3);
            counter = 0;
        }
        counter++;

        if (axis == 0)
        {
            yRot = 0;
            zRot = 0;
        }
        else if (axis == 1)
        {
            xRot = 0;
            zRot = 0;
        }
        else if (axis == 2)
        {
            xRot = 0;
            yRot = 0;
        }

        transform.Rotate(xRot * Time.deltaTime * rotSpeed, yRot * Time.deltaTime * rotSpeed, zRot * Time.deltaTime * rotSpeed);
    }
}
