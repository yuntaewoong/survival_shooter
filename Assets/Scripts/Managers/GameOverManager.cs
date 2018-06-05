using UnityEngine;
using UnityEngine.SceneManagement;



public class GameOverManager : MonoBehaviour
{
    public PlayerHealth playerHealth;
    public float restartdelay = 5f;

    Animator anim;
    float restartTimer;

    private void Awake()
    {
        anim = GetComponent<Animator>();
    }

    private void Update()
    {
        if (playerHealth.currentHealth <= 0)
        {
            anim.SetTrigger("GameOver");
            restartTimer += Time.deltaTime;
            
            if (restartTimer >= restartdelay)
            {
                RestartLevel();
            }
        }
    }
    
    void RestartLevel()
    {
        SceneManager.LoadScene(0);
    }
}
