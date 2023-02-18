using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeColor : MonoBehaviour
{
    [SerializeField] ParticleSystem part;
    private int r;
    private int b;
    private int g;

    [System.Obsolete]
    void Start()
    {
       part.GetComponent<ParticleSystem>().startColor = new Color(1, 0, 1, .5f);
    }

    void Update()
    {
        if(r <= 255)
        {
            r += 1;
            if (b <= 255)
            {
                r += 1;
            }
        }
    }
}
