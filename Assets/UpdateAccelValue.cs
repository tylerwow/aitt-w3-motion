using UnityEngine;
using UnityEngine.UI;

public class UpdateAccelValue : MonoBehaviour
{
    public Text AccelValue;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 dir = Vector3.zero;

        dir.x = -Input.acceleration.y;
        dir.z = Input.acceleration.x;

        AccelValue.text = dir.x + " " + dir.y;
    }
}