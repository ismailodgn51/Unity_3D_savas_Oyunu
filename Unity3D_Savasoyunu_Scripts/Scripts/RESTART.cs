using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RESTART : MonoBehaviour
{
  
        public void playgame()
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex -2);
        }

    
}
