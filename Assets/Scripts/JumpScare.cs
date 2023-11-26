using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class JumpScare : MonoBehaviour
{
    public static JumpScare inst;
    public float length = 5;
    public GameObject image;

    private void Awake()
    {
        if (inst == null) inst = this;
        else Destroy(gameObject);
    }


    void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    
    public void Show()
    {
        image.SetActive(true);
        Invoke(nameof(Restart), length);
    }
}
