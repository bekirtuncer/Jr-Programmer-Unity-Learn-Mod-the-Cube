using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube : MonoBehaviour
{
    public MeshRenderer Renderer;

    public float startDelay = 1f;
    public float repeatTime = 2f;
    
    void Start()
    {
        Material material = Renderer.material;

        InvokeRepeating("ChangeScale", startDelay, repeatTime);
        InvokeRepeating("ChangePosition", startDelay, repeatTime);
        InvokeRepeating("ChangeMaterial", startDelay, repeatTime);
    }
    
    void Update()
    {
        float speed = Random.Range(0.3f, 10f);
        float angleX = Random.Range(-0f, 90f);
        float angleY = Random.Range(-0f, 90f);
        float angleZ = Random.Range(-0f, 90f);

        transform.Rotate(angleX * Time.deltaTime * speed, angleY * Time.deltaTime * speed, angleZ * Time.deltaTime * speed);
    }

    void ChangeScale()
    {
        float x = Random.Range(0.3f, 10f);
        transform.localScale = Vector3.one * x;
    }

    void ChangePosition()
    {
        float x = Random.Range(-3f, 3f);
        float y = Random.Range(-3f, 3f);
        float z = Random.Range(-3f, 3f);
        transform.position = new Vector3(x, y, z);
    }

    void ChangeMaterial()
    {
        float r = Random.Range(0f, 1f);
        float g = Random.Range(0f, 1f);
        float b = Random.Range(0f, 1f);
        float o = Random.Range(0f, 1f);
        Renderer.material.color = new Color(r, g, b, o);
    }
}
