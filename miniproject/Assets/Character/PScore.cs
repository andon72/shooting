using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PScore : MonoBehaviour
{
    [SerializeField] private TMP_Text _Text;
    public int Score = 0;

    void Start()
    {
        _Text.text = Score.ToString();
        StartCoroutine(Timerepeat());

    }

    // Update is called once per frame
    void Update()
    {
        _Text.text = Score.ToString();

    }
    IEnumerator Timerepeat()
    {
        while (true)
        {
            Score += 1;
            yield return new WaitForSeconds(0.7f);
        }
    }
}
