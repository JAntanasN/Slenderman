using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Collector : MonoBehaviour
{
    public int count;
    public int books = 8;
    public AudioSource audioSource;


    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Collectable"))
        {
            count++;
            audioSource.Play();
            Destroy(collision.gameObject);
        }
    }

    private void Update()
    {
        if(books == count)
        {
            SceneManager.LoadScene("EndScene");
        }
    }
}
