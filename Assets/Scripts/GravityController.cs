using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GravityController : MonoBehaviour
{
    const float Gravity = 9.81f;
    [SerializeField]
    public float gravityScale = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("OK");
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("in");
        Vector3 vector = new Vector3();
        vector.x = Input.GetAxis("Horizontal");
        vector.z = Input.GetAxis("Vertical");
        if (Input.GetKey("z"))
        {
            vector.y = 1.0f;
        }
        else
        {
            vector.y = -1.0f;
        }
        Physics.gravity = Gravity * vector.normalized * gravityScale;
        
    }
}
