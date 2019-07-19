using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneLoad : MonoBehaviour

 {
    
    // Start is called before the first frame update
    void Start()
    {

        Debug.Log("Hola");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SceneLoading(string nombreEscena)
    {
        SceneManager.LoadScene(nombreEscena);
    }
}
