using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RepeatBackgroundX : MonoBehaviour
{
    private Vector3 startPos;
    private float repeatWidth;

    private void Start()
    {
        startPos = transform.position; // Телепортация в стартовую позицию
        repeatWidth = GetComponent<BoxCollider>().size.x / 2; // Высчитываем центр фона
    }

    private void Update()
    {
        // Если фон ушёл на половину влево, то возвращаем его на стартовую позицию
        if (transform.position.x < startPos.x - repeatWidth)
        {
            transform.position = startPos;
        }
    }

 
}


