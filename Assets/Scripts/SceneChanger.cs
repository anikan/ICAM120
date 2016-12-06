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

    void OnTriggerEnter(Collider other)
    {
        //Only head has camera
        if (other.gameObject.GetComponent<Camera>())
        {
            int sceneIndex = (SceneManager.GetActiveScene().buildIndex + sceneIncrementAmount + SceneManager.sceneCountInBuildSettings) % SceneManager.sceneCountInBuildSettings;
            SceneManager.LoadScene(sceneIndex);
        }
    }
}
