using TMPro;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    public TextMeshProUGUI helloText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        helloText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            helloText.text = "Hello World";
        }
    }
}
