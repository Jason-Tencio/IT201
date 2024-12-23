using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerColor : MonoBehaviour
{
    public float timer = 0.0f;

    void Start()
    {

    }
    void Update()
    {


        timer += Time.deltaTime;
        if (timer >= 0.5f)
        {
            Color newColor = new Color(Random.value, Random.value, Random.value, 1.0f);
            GetComponent<Renderer>().material.color = newColor;
            timer = 0;
        }


    }


}
