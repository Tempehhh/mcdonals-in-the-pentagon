using UnityEngine;

public class columnscript : MonoBehaviour
{
    public float Speed = 7;
    public float deadzone = -40;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = transform.position + (Vector3.left * Speed) * Time.deltaTime;

        if (transform.position.x < deadzone) 
        {
            Debug.Log("column deleted");
            Destroy (gameObject);
        }
    }
}
