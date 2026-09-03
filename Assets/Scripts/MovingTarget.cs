using UnityEngine;
using UnityEngine.UIElements;

public class MovingTarget : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {

        transform.localPosition = new Vector3(Random.Range(1, 10), Random.Range(1, 10), Random.Range(1, 10));
    }
}
