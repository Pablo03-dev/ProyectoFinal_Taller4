using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager manager;

    //public Slider barrahp;

    public Slider barraTime;
    public float time;

    //private int score;
    //public Text scoreText;

    //public Transform posReseteo;
    //public Rigidbody2D rb;

    //public float timer = 10;
    //private bool juegoPausado = false;

    public GameoverScreen GameOverScreen;


    //private void Awake()
    //{
    //    manager = this;
    //    score = 0;
    //    UpdatedScore();
    //}

    //public int vidas;

   public void GameOver()
    {
        print("EndGame");
        //GameOverScreen.Setup(score);
    }


    public void WinGame()
    {

    }

    public void ResetearJuego()
    {

    }

    public void QuitarTiempo()
    {

        if (time < 0)
        {
            GameOver();
        }

    }

    void UpdatedScore()
    {
        //scoreText.text = "Score: " + score;
    }

    public void AddScore(int puntajesumaar)
    {
        //score += puntajesumaar;
        //Audiomanager.PlaySound("Coin");
        UpdatedScore();
    }

   

}
