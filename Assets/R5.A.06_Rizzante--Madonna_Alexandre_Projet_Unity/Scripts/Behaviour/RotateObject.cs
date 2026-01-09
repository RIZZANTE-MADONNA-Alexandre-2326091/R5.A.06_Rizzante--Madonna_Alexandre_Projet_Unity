using System;
using System.Collections;
using System.Collections.Generic;
using TreeEditor;
using UnityEditor.Rendering;
using UnityEngine;

public class RotateObject : MonoBehaviour
{
    [SerializeField] Vector3 m_AngleSpeed;
    [SerializeField] Space m_Space;
    [SerializeField] bool m_Randomize;

    // Start is called before the first frame update
    void Start()
    {
        if (m_Randomize) transform.Rotate(m_AngleSpeed * UnityEngine.Random.Range(0, 1.0f));
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log("Unity Test log Update " + Time.deltaTime);
        //transform.Translate(m_Speed * Time.deltaTime, Space.Self);
        transform.Rotate(m_AngleSpeed * Time.deltaTime, m_Space);
        //transform.position = transform.position * m_Speed * Time.deltaTime;
        //transform.rotation = transform.rotation * Quaternion.Euler(m_AngleSpeed * Time.deltaTime);
    }
}
