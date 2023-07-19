using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GuessNumber : MonoBehaviour
{
    public int max=1000000;
    public int min=0;
    public int guess=0;
    public Text guessnumber;
    public void Higher()
    {
        min=guess;
        // guess=(min+max)/2;
        guess=Random.Range(min, max);
        guessnumber.text=guess.ToString();
    }
    public void Lower()
    {
        max=guess;
        // guess=(min+max)/2;
        guess=Random.Range(min, max);
        guessnumber.text=guess.ToString();
    }
    public void Equal()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        SceneManager.LoadScene(currentSceneIndex + 1);
    }
}
