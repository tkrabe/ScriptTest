using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // 配列を初期化する
        int[] array = { 100, 90, 80, 70, 60, };

        // for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < array.Length; i++)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }
        // for文を使い、配列の各要素の値を逆順に表示
        for (int i = 4; i >= 0; i--)
        {
            // 配列の要素を表示する
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}