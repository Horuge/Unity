using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ResetScript : MonoBehaviour {

    // Recarga la escena
	public void reset () {
        SceneManager.LoadScene(0);
    }
}
