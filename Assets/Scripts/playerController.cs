using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class playerController : MonoBehaviour
{
    Rigidbody playerRb;
    public bool onGroundl = true;
    public GameObject gameOver;
    private Animator playerAni;
    public ParticleSystem explosion;
    public ParticleSystem dirt;

    public AudioClip jumpSound;
    public AudioClip crashSound;

    private AudioSource playerAudio;
    void Start()
    {
        Time.timeScale = 1;
        
        playerRb = GetComponent<Rigidbody>();
      
        playerAni = GetComponent<Animator>();

        playerAudio = GetComponent<AudioSource>();
       
        

        
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && onGroundl == true)
        
        {
            dirt.Stop();
            playerRb.AddForce(Vector3.up * 2000, ForceMode.Impulse);
            onGroundl = false;
            playerAudio.PlayOneShot(jumpSound, 1.0f);
            playerAni.SetTrigger("Jump_trig");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))

        {
            onGroundl = true;
            dirt.Play();
        }
        else if (collision.gameObject.CompareTag("Obs"))
        {
            gameOver.SetActive(true);
         
            playerAni.SetBool("Death_b", true);
            playerAni.SetInteger("DeathType_int", 2);
            InvokeRepeating("Timecale", .5f,.5f);
            Destroy(collision.gameObject);
            explosion.Play();
            dirt.Stop();
            playerAudio.PlayOneShot(crashSound, 1.0f);
           
        }
             
        
    }
    public void playAgain()
    {
        SceneManager.LoadScene(0);
    }
    void Timecale()
   
    { Time.timeScale = 0;}

}
