using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayButton : MonoBehaviour
{

    [SerializeField] private Button buttonPlayAgain;
    private void Awake()
    {
        buttonPlayAgain.onClick.AddListener(OnButtonPlayAgainClick);
    }


    private void OnButtonPlayAgainClick()
    {
        SceneManager.LoadScene("MainGame");
    }

}