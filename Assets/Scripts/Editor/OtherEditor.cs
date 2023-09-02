using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class OtherEditor : MonoBehaviour
{
    void Start()
    {
        // Check if this is Scene 4 (you can also check by scene name).
        if (SceneManager.GetActiveScene().buildIndex == 4)
        {
            // Load Scene 0.
            SceneManager.LoadScene(0);
        }
    }
}
