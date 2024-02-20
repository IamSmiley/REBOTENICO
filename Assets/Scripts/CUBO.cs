using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CUBO : MonoBehaviour
{
    public int puntos;
    public Text textoPuntos;
    void Start()

    {
        puntos =0;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider c)
    {
        Debug.Log("Choque Cubo");
        puntos++;
        textoPuntos.text = puntos.ToString();
    }
}
