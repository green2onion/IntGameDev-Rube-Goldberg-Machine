using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class Bruh : MonoBehaviour
{
    public Slider slider;
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().Play();
            StartCoroutine(RestartCoroutine());
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Player")
        {
            if (slider.gameObject != null)
            { 
                Destroy(slider.gameObject); 
            }

            Time.timeScale = 0.5f;
        }
    }
    IEnumerator RestartCoroutine()
    {
        yield return new WaitForSeconds(2);
        Time.timeScale = 1;
        SceneManager.LoadScene(0);
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}
