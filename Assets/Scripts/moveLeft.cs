using UnityEngine;

public class moveLeft : MonoBehaviour
{
   private float speed= 15f;
    
    void Start()
    {
        
    }

    
    void Update()
    {
        transform.Translate(Vector3.left * Time.deltaTime * speed);
        
        
        if(transform.position.x < -10 && gameObject.CompareTag("Obs"))
            
            
        {

            Destroy(gameObject);

        }
    
    
    }
}
