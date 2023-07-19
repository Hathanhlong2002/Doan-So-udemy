using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class ResutLevel3 : MonoBehaviour
{
    // Start is called before the first frame update
    public int numberGuess;
    public InputField inputField;
    public Text resultText;
    protected string number;
    protected string result= " ";
    protected int count;
    public Text CountText;
    void Start()
    {
        numberGuess=Random.Range(0,1000);
        CountText.text="Số lần đoán là: "+0;
    }

    // Update is called once per frame
    void Update()
    {
        // number=inputField.text;

    }
    public void Guess()
    {
        number=inputField.text;
        count++;
        int num=int.Parse(number);
        if(num==numberGuess)
        {
            result="Bạn đoán đúng rồi!!!!!!";
        }
        else if(num>numberGuess)
        {
            result="Số cần tìm nhỏ hơn số bạn đoán";
        }
        else
        {
            result="Số cần tìm lớn hơn số bạn đoán";
        }
        resultText.text=result;
        CountText.text="Số lần đoán là: "+count.ToString();
    }
    public void MenuGame()
    {
        SceneManager.LoadScene("StartGame");
    }
}
