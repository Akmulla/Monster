using UnityEngine;
using System.Collections;

public class GameController : MonoBehaviour
{
    public static void GameOver()
    {
        Application.LoadLevel("GameOver");

    }

    public static void Win()
    {
        Application.LoadLevel("Win");

    }
}
