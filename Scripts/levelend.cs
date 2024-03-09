using UnityEngine.SceneManagement;
using UnityEngine;

public class levelend : MonoBehaviour
{
    void OnTriggerEnter(Collider other) {
        SceneManager.LoadScene(14);
    }
}
