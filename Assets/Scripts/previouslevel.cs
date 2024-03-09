using UnityEngine.SceneManagement;
using UnityEngine;

public class previouslevel : MonoBehaviour
{
    public void levelprevious() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
