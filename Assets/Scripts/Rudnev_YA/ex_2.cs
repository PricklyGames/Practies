using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using PracticeOne;
using PracticeTwo;

public class ex_2 : MonoBehaviour
{
    [SerializeField] int prTwoExOneN;
    [SerializeField] int prTwoExTwoN;
    [SerializeField] int prTwoExThreeNOne;
    [SerializeField] int prTwoExThreeNTwo;
    [SerializeField] int prTwoExFourRow;
    [SerializeField] int prTwoExFourColumn;
    [SerializeField] int prTwoExFiveRow;
    [SerializeField] int prTwoExSixCount;

    [SerializeField] DayWeek prTwoExSevenDayWeek;
    DayWeek prTwoExSevenDayWeekTmp;

    // Start is called before the first frame update
    void Start()
    {
        PrOne practiceOne = new();
        PrTwo practiceTwo = new() { exOneSizeMas = prTwoExOneN, exTwoSizeMas = prTwoExTwoN, exThreeSizeMasOne = prTwoExThreeNOne, exThreeSizeMasTwo = prTwoExThreeNTwo, exFourRow = prTwoExFourRow, exFourColumn = prTwoExFourColumn, exFiveRow = prTwoExFiveRow, exSixCount = prTwoExSixCount, dayWeek = prTwoExSevenDayWeek };

        ExThree ex = new(practiceOne, practiceTwo);

        ex.PracticeOne();
        ex.PracticeTwo();

        prTwoExSevenDayWeekTmp = prTwoExSevenDayWeek;
    }

    // Update is called once per frame
    void Update()
    {
        PrOne practiceOne = new();
        PrTwo practiceTwo = new() { dayWeek = prTwoExSevenDayWeek };

        ExThree ex = new(practiceOne, practiceTwo);

        if (prTwoExSevenDayWeekTmp != ex.practiceTwo.dayWeek)
        {
            prTwoExSevenDayWeekTmp = ex.practiceTwo.dayWeek;
            practiceTwo.PrintDay(prTwoExSevenDayWeekTmp);
        }
    }
}

class ExThree
{
    public PrOne practiceOne;
    public PrTwo practiceTwo;

    public ExThree(PrOne practiceOne, PrTwo practiceTwo)
    {
        this.practiceOne = practiceOne;
        this.practiceTwo = practiceTwo;
    }

    public void PracticeOne()
    {
        practiceOne.PrintBeginPr();

        practiceOne.exOneStr = "Lorem ipsum dolor sit amet, consectetur Adipiscing0 elit. Mauris gravida Aliquam ante nec luctus.";
        practiceOne.ExOne(practiceOne.exOneStr);

        practiceOne.exTwoRadius = 5f;
        practiceOne.ExTwo(practiceOne.exTwoRadius);

        practiceOne.exThreeSetSquareRectangle = 25f;
        practiceOne.exThreeLength = 7f;
        practiceOne.exThreeWidth = 10f;
        practiceOne.ExThree(practiceOne.exThreeSetSquareRectangle, practiceOne.exThreeLength, practiceOne.exThreeWidth);

        practiceOne.ExFour();

        practiceOne.PrintEndPr();
    }

    public void PracticeTwo()
    {
        practiceTwo.PrintBeginPr();

        practiceTwo.ExOne(practiceTwo.exOneSizeMas);

        practiceTwo.ExTwo(practiceTwo.exTwoSizeMas);

        practiceTwo.ExThree(practiceTwo.exThreeSizeMasOne, practiceTwo.exThreeSizeMasTwo);

        practiceTwo.ExFour(practiceTwo.exFourRow, practiceTwo.exFourColumn);

        practiceTwo.ExFive(practiceTwo.exFiveRow);

        practiceTwo.ExSix(practiceTwo.exSixCount);

        practiceTwo.PrintEndPr();

        practiceTwo.PrintDay(practiceTwo.dayWeek);
    }
}
