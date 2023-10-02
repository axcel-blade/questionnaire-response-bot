using System;
using System.Collections.Generic;

public class QuestionnaireResponseBot
{
    public int RandomNumberMethod(int ListLength)
    {
        var RandomNumberFunction = new Random();

        int RandomNumber = RandomNumberFunction.Next(0, ListLength);

        return RandomNumber;
    }

    public static void Main(string[] args)
    {
        QuestionnaireResponseBot QRBObject = new QuestionnaireResponseBot();

        //Question 01
        Console.WriteLine("Question 01: What is you age range?");
        List<string> AnswerOneList = new List<string>()
        {
            "16-18", "19-21", "22-24"
        };

        string AnswerOne = AnswerOneList[QRBObject.RandomNumberMethod(AnswerOneList.Count)];
        Console.WriteLine("Answer 01  : {0}\n", AnswerOne);
        
        //Question 02
        Console.WriteLine("Question 02: What is your gender?");
        List<string> AnswerTwoList = new List<string>()
        {
            "Male", "Female"
        };

        string AnswerTwo = AnswerTwoList[QRBObject.RandomNumberMethod(AnswerTwoList.Count)];
        Console.WriteLine("Answer 02  : {0}\n", AnswerTwo);

        //Question 03
        Console.WriteLine("Question 03: What is your highest level of education?");
        List<string> AnswerThreeList = new List<string>()
        {
            "Ordinary Level (O/L)", "Advance Level (A/L)", "University"
        };

        string AnswerThree = AnswerThreeList[QRBObject.RandomNumberMethod(AnswerThreeList.Count)];
        Console.WriteLine("Answer 03  : {0}\n", AnswerThree);

        //Question 04
        Console.WriteLine("Question 04: What is your degree type?");
        List<string> AnswerFourList = new List<string>()
        {
            "Foundation", "IT", "Engineering", "Business", "Architecture", "Not a university student", "Other"
        };

        string AnswerFour = AnswerFourList[QRBObject.RandomNumberMethod(AnswerFourList.Count)];
        Console.WriteLine("Answer 04  : {0}\n", AnswerFour);

        //Question 05
        Console.WriteLine("Question 05: What is your academic year?");
        List<string> AnswerFiveList = new List<string>()
        {
            "Foundation Year", "First Year", "Second Year", "Third Year", "Final year", "Not a university student"
        };

        string AnswerFive = AnswerFiveList[QRBObject.RandomNumberMethod(AnswerFiveList.Count)];
        Console.WriteLine("Answer 05  : {0}\n", AnswerFive);

        //Question 06
        Console.WriteLine("Question 06: In a scale of 1 to 5, How challenging do you find learning a new language?");
        List<string> AnswerSixList = new List<string>()
        {
            "1", "2", "3", "4", "5"
        };

        string AnswerSix = AnswerSixList[QRBObject.RandomNumberMethod(AnswerSixList.Count)];
        Console.WriteLine("Answer 06  : {0}\n", AnswerSix);

        //Question 07
        Console.WriteLine("Question 07: How do you currently address overcome challenges you face in learning English?");
        List<string> AnswerSevenList = new List<string>()
        {
            "Self learning", "English classes and courses", "Language exchange programs", "YouTube tutorials", "Social media groups", "Reading books and articles", "Listening to podcasts", "Conversation with native", "Online forum and communities", "Daily language practice"
        };

        string AnswerSeven = AnswerSevenList[QRBObject.RandomNumberMethod(AnswerSevenList.Count)];
        Console.WriteLine("Answer 07  : {0}\n", AnswerSeven);

        //Question 08
        Console.WriteLine("Question 08: On a scale of  1 to 5, How confident are you in your English speaking abilities?");
        List<string> AnswerEightList = new List<string>()
        {
            "1", "2", "3", "4", "5"
        };

        string AnswerEight = AnswerEightList[QRBObject.RandomNumberMethod(AnswerEightList.Count)];
        Console.WriteLine("Answer 08  : {0}\n", AnswerEight);

        //Question 09
        Console.WriteLine("Question 08: Do you think your language challenges are more related to mental block or lack of exposure?");
        List<string> AnswerNineList = new List<string>()
        {
            "Mental block", "Lack of exposure"
        };

        string AnswerNine = AnswerNineList[QRBObject.RandomNumberMethod(AnswerNineList.Count)];
        Console.WriteLine("Answer 09  : {0}\n", AnswerNine);

        //Question 10
        Console.WriteLine("Question 08: How often do you engage with native english speakers?");
        List<string> AnswerTenList = new List<string>()
        {
            "Rarely", "Occasionally", "Regularly", "Very Frequently"
        };

        string AnswerTen = AnswerTenList[QRBObject.RandomNumberMethod(AnswerTenList.Count)];
        Console.WriteLine("Answer 10  : {0}\n", AnswerTen);
    }
}