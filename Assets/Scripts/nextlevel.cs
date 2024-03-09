using UnityEngine.SceneManagement;
using UnityEngine;

public class nextlevel : MonoBehaviour
{
    public void levelnext() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
