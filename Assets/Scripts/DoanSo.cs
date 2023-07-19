using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoanSo : MonoBehaviour
{
    public int max = 1000;
    public int min = 100;
    int guess = 0;

    void Start()
    {
        print("Chào");
        print("Nhập số không được lớn hơn 1000");
        print("Nhập số không nhỏ hơn 100");
        guess = (max + min) / 2;
        print("Nhấn phím lên nếu lớn hơn đoán");
        print("Nhấn phím xuống nếu nhỏ hơn");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            min = guess;
            guess = (max + min) / 2;
            print("Số bạn nghĩ có hơn " + guess);
        }
        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            max = guess;
            guess = (max + min) / 2;
            print("Số bạn nghĩ có nhỏ hơn " + guess);
        }
    }
}
