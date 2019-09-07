using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Wiper : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

            if (Input.GetKey(KeyCode.Alpha1))
            {
                SceneManager.LoadScene("Cubes");
            }

            if (Input.GetKey(KeyCode.Alpha2))
            {
                SceneManager.LoadScene("Particles");
            }

            if (Input.GetKey(KeyCode.Alpha3))
            {
                SceneManager.LoadScene("Petals");
            }

            if (Input.GetKey(KeyCode.Alpha4))
            {
                SceneManager.LoadScene("Plexus");
            }

            if (Input.GetKey(KeyCode.Alpha5))
            {
                SceneManager.LoadScene("Rain");
            }

            if (Input.GetKey(KeyCode.Alpha6))
            {
                SceneManager.LoadScene("Scanner");
            }

            if (Input.GetKey(KeyCode.Alpha7))
            {
                SceneManager.LoadScene("Squares");
            }

            if (Input.GetKey(KeyCode.Alpha8))
            {
                SceneManager.LoadScene("Stream");
            }

            if (Input.GetKey(KeyCode.Alpha9))
            {
                SceneManager.LoadScene("Triangles");
            }

            if (Input.GetKey(KeyCode.Alpha0))
            {
                SceneManager.LoadScene("Wiper");
            }
        }
}