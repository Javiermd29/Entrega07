using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.XR;
using Random = UnityEngine.Random;

public class Entrega07 : MonoBehaviour
{

    void Start()
    {
        Exercise01();
        Exercise02();
        Exercise03();
        Exercise04();
        Exercise05();
    }

    private void Exercise01()
    {
        int sum = 0;

        for (int i = 2; i <= 100; i += 2)
        {
            sum += i;
        }
        Debug.Log("The sum of even numbers from 1 to 100 is: " + sum);
    }

    private void Exercise02()
    {
        string[] lettersArray = { "a", "j", "e", "m", "d", "g", "t", "z", "u", "r" };
        int count = 0;

        for (int i = 0; i < lettersArray.Length; i++)
        {

            if (lettersArray[i] == "a" || lettersArray[i] == "e" || lettersArray[i] == "i" || lettersArray[i] == "o" || lettersArray[i] == "u")
            {
                count++;
            }
        }

        Debug.Log("There are " + count + " vowels.");

    }

    private void Exercise03()
    {
        /*10 green bottles
        Hanging on the wall
10 green bottles
Hanging on the wall
And if one green bottle
Should accidentally fall
There’ll be 9 green bottles
Hanging on the wall*/

        for (int i = 10; i >= 1; i--)
        {

            Debug.Log(i + " green bottles\n Hanging of the wall\n " + i + " green bottle hanging of the wall\n And if one green bottle\n Should accidentally fall\n There’ll be " + (i - 1) + " green bottles\nHanging on the wall");
        }

    }

    private void Exercise04()
    {
        int randomTotal = 0;
        int fiveCount = 0;

        while (randomTotal <= 100)
        {
            int randomNumber = Random.Range(1, 11);

            randomTotal = randomTotal + randomNumber;

            Debug.Log(randomTotal);

            if (randomNumber == 5)
            {
                fiveCount++;
            }

        }

        Debug.Log("The total number of 5 drawn is: " + fiveCount);


    }

    private void Exercise05()
    {

        string stopString = "Mi nombre es Javier";

        for (int i = 0; i< stopString.Length; i++)
        {

            if (stopString[i] == 'a')
            {
                i = stopString.Length;
            }
            else
            {
                Debug.Log(stopString[i]);
            }


        }



    }

}
