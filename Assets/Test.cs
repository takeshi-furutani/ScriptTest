using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start()
    {
        // �z�������������
        int[] array = { 10, 20, 30, 40, 50 };

        // �z��̗v�f���̂Ԃ񂾂��������J��Ԃ�
        for (int i = 0; i < array.Length; i++)
        {
            // �z��̗v�f��\������
            Debug.Log(array[i]);
        }

        // �z��̗v�f���̂Ԃ񂾂��������J��Ԃ�
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