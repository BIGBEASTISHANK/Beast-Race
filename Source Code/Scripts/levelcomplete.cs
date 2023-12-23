using UnityEngine.SceneManagement;
using UnityEngine;

public class levelcomplete : MonoBehaviour
{
    void OnTriggerEnter(Collider other)
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        Debug.Log("Level Complete");
    }
}
