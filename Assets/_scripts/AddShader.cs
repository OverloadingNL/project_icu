using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class AddShader : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        gameObject.GetComponent<Image>().material.shader = Shader.Find("Custom/Stencil Mask");
    }
}