using UnityEngine;

public class backgroundController : MonoBehaviour
{
    Vector3 trnspos;
    float repeatwidth;
    void Start()
    {
        trnspos = transform.position;
        repeatwidth = GetComponent<BoxCollider>().size.x / 2;
    }

    
    void Update()
    {
        if (transform.position.x < -36)         
        {

            transform.position = trnspos;

        }
    }
}
