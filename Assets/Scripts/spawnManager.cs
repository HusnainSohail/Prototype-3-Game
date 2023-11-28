using UnityEngine;

public class spawnManager : MonoBehaviour
{
   
    
    
    public GameObject obstacles;
    Vector3 Pos = new Vector3 (15, 0, 0);
    void Start()
    {
        InvokeRepeating("spawmRepeate", 2f, 2f);
    }


    void Update()
    {
       
    }

    public void spawmRepeate()
    {
        Instantiate(obstacles, Pos, obstacles.transform.rotation);

    }
}
