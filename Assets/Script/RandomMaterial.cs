using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RandomMaterial : MonoBehaviour
{
    public Material[] materials;
    public float StopTime;
    public GameObject ColorToMatch;

    // Update is called once per frame
    void Update()
    {
        RandomColor();
    }

    void RandomColor()
    {
        gameObject.GetComponent<MeshRenderer>().material = materials [Random.Range (0, materials.Length)];
    }

    void EndRand()
    {
        enabled = false;

        if (this.GetComponent<MeshRenderer>().material.name == ColorToMatch.GetComponent <MeshRenderer> ().material.name)
        {
            Debug.Log("the color of " + this.gameObject.name + " matches!");

            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
        }
    }
    public void StopRand()
    {
        Invoke("EndRand", StopTime);
    }
    public void StartRand()
    {
        enabled = true;
    }
}
