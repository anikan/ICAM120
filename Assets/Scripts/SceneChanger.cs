using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{

    public int sceneIncrementAmount;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEntsser(Collider other)
    {
        //Only head has camera
        if (other.gameObject.GetComponent<Camera>())
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + sceneIncrementAmount);
        }
    }
}
