using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        // �z�������������
        int[] array = { 100, 90, 80, 70, 60, };

        // for�����g���A�z��̊e�v�f�̒l�����Ԃɕ\��
        for (int i = 0; i < array.Length; i++)
        {
            // �z��̗v�f��\������
            Debug.Log(array[i]);
        }
        // for�����g���A�z��̊e�v�f�̒l���t���ɕ\��
        for (int i = 4; i >= 0; i--)
        {
            // �z��̗v�f��\������
            Debug.Log(array[i]);
        }
    }

    // Update is called once per frame
    void Update()
    {

    }
}