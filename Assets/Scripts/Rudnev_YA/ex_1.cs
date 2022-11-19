using UnityEngine;

public class ex_1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

        string stroka = "Lorem ipsum dolor sit amet, consectetur Adipiscing0 elit. Mauris gravida Aliquam ante nec luctus.";
        int count = 0, countA = 0;

        Debug.Log("The beginning of the first task");

        foreach (char c in stroka)
        {
            count++;

            if (c == '0')
            {
                Debug.Log($"The sentence has the symbol 0, its index {count - 1}.");
                break;
            }

            if (c.ToString().ToLower() == "a")
            {
                countA++;
            }
        }

        Debug.Log($"In the sentence {count} characters");
        Debug.Log($"In the sentence {countA} characters a");

        Debug.Log("End of the first task");

    }

}