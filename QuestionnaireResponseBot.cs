using System;
using System.Collections.Generic;
using System.Linq;

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

        //Section 03
        //Question 11
        Console.WriteLine("Question 11: Learning grammar in English is,");
        List<string> AnswerElevenList = new List<string>()
        {
            "1", "2", "3", "4", "5"
        };

        string AnswerEleven = AnswerElevenList[QRBObject.RandomNumberMethod(AnswerElevenList.Count)];
        Console.WriteLine("Answer 11  : {0}\n", AnswerEleven);

        //Question 12
        Console.WriteLine("Question 12: How often do you practice English pronunciation?");
        List<string> AnswerTwelveList = new List<string>()
        {
            "Never", "Rarely", "Sometimes", "Often", "Always"
        };

        string AnswerTwelve = AnswerTwelveList[QRBObject.RandomNumberMethod(AnswerTwelveList.Count)];
        Console.WriteLine("Answer 12  : {0}\n", AnswerTwelve);

        //Question 13
        Console.WriteLine("Question 13: In your opinion, Which is the most challenging: Listening to native speakers or Speaking with them");
        List<string> AnswerThirteenList = new List<string>()
        {
            "Listening is more challenging", "Speaking is more challenging"
        };

        string AnswerThirteen = AnswerThirteenList[QRBObject.RandomNumberMethod(AnswerThirteenList.Count)];
        Console.WriteLine("Answer 13  : {0}\n", AnswerThirteen);

        //Question 14
        Console.WriteLine("Question 14: Which of these resources do you find most effective for improve your vocabulary ");
        List<string> AnswerFourteenList = new List<string>()
        {
            "Reading books", "Watching movies", "Watching TV shows", "Using language learning apps"
        };

        string AnswerFourteen = AnswerFourteenList[QRBObject.RandomNumberMethod(AnswerFourteenList.Count)];
        Console.WriteLine("Answer 14  : {0}\n", AnswerFourteen);

        //Section 04
        //Question 15
        Console.WriteLine("Question 15: Please rate your level of agreement with the statement. 'I feel that my language challenges have improved overtime.'");
        List<string> AnswerFifteenList = new List<string>()
        {
            "1", "2", "3", "4", "5"
        };

        string AnswerFifteen = AnswerFifteenList[QRBObject.RandomNumberMethod(AnswerFifteenList.Count)];
        Console.WriteLine("Answer 15 : {0}\n", AnswerFifteen);

        //Question 16
        Console.WriteLine("Question 16: What is your language level before you came to the university?");
        List<string> AnswerSixteenList = new List<string>()
        {
            "1", "2", "3", "4", "5"
        };

        string AnswerSixteen = AnswerSixteenList[QRBObject.RandomNumberMethod(AnswerSixteenList.Count)];
        Console.WriteLine("Answer 16 : {0}\n", AnswerSixteen);

        //Question 17
        Console.WriteLine("Question 17: Did you follow any course before you came to the university?");
        List<string> AnswerSeventeenList = new List<string>()
        {
            "Yes", "No"
        };

        string AnswerSeventeen = AnswerSeventeenList[QRBObject.RandomNumberMethod(AnswerSeventeenList.Count)];
        Console.WriteLine("Answer 17 : {0}\n", AnswerSeventeen);

        //Question 18
        Console.WriteLine("Question 18: How helpful is your university English module for your language improvement?");
        List<string> AnswerEighteenList = new List<string>()
        {
            "1", "2", "3", "4", "5"
        };

        string AnswerEighteen = AnswerEighteenList[QRBObject.RandomNumberMethod(AnswerEighteenList.Count)];
        Console.WriteLine("Answer 18 : {0}\n", AnswerEighteen);

        //Question 19
        Console.WriteLine("Question 19: How helpful do you find language learning apps in addressing your language challenges?");
        List<string> AnswerNineteenList = new List<string>()
        {
            "1", "2", "3", "4", "5"
        };

        string AnswerNineteen = AnswerNineteenList[QRBObject.RandomNumberMethod(AnswerNineteenList.Count)];
        Console.WriteLine("Answer 19 : {0}\n", AnswerNineteen);

        //Question 20
        Console.WriteLine("Question 20: Indicate your level of agreement with the statement. 'I believe that practicing regularly with native speakers in essential for overcoming language challenges.'");
        List<string> AnswerTwentyList = new List<string>()
        {
            "1", "2", "3", "4", "5"
        };

        string AnswerTwenty = AnswerTwentyList[QRBObject.RandomNumberMethod(AnswerTwentyList.Count)];
        Console.WriteLine("Answer 20 : {0}\n", AnswerTwenty);

        //Section 05
        //Question 21
        Console.WriteLine("Question 21: How would you describe your experience with learning English so far?");
        List<string> AnswerTwentyOneList = new List<string>()
        {
            "Unpleasant", "Pleasant", "Frustrating", "Fulfilling", "Complex-simple"
        };

        string AnswerTwentyOne = AnswerTwentyOneList[QRBObject.RandomNumberMethod(AnswerTwentyOneList.Count)];
        Console.WriteLine("Answer 21 : {0}\n", AnswerTwentyOne);

        //Section 06
        //Question 22
        Console.WriteLine("Question 22: What is the main reason you decide to learn English?");
        List<string> AnswerTwentyTwoList = new List<string>()
        {
            "Academic purposes", "Professional advancement", "Travel and tourism", "Personal interest"
        };

        string AnswerTwentyTwo = AnswerTwentyTwoList[QRBObject.RandomNumberMethod(AnswerTwentyTwoList.Count)];
        Console.WriteLine("Answer 22 : {0}\n", AnswerTwentyTwo);

        //Section 07
        //Question 23
        Console.WriteLine("Question 23: Do you find speaking English more challenging than writing it?");
        List<string> AnswerTwentyThreeList = new List<string>()
        {
            "Yes", "No"
        };

        string AnswerTwentyThree = AnswerTwentyThreeList[QRBObject.RandomNumberMethod(AnswerTwentyThreeList.Count)];
        Console.WriteLine("Answer 23 : {0}\n", AnswerTwentyThree);

        //Question 24
        Console.WriteLine("Question 24: Have you ever taken a formal English language classes?");
        List<string> AnswerTwentyFourList = new List<string>()
        {
            "Yes", "No"
        };

        string AnswerTwentyFour = AnswerTwentyFourList[QRBObject.RandomNumberMethod(AnswerTwentyFourList.Count)];
        Console.WriteLine("Answer 23 : {0}\n", AnswerTwentyFour);

        //Section 08
        //Question 25
        Console.WriteLine("Question 25: Please rank the following language in order of difficulty, with 1 being the most difficult and 5 being least difficult");
        //List<string> AnswerTwentyFiveList = new List<string>()
        //{
        //    "Grammar", "Pronunciation", "Listening comprehension", "Vocabulary", "Speaking fluency"
        //};

        //string AnswerTwentyFive = AnswerTwentyFiveList[QRBObject.RandomNumberMethod(AnswerTwentyFourList.Count)];

        Random rand = new Random();
        List<int> listOfInt = new List<int>() {1, 2, 3, 4, 5};
        listOfInt = listOfInt.OrderBy(x=> rand.Next()).ToList();
        foreach (int item in listOfInt)
        {
            Console.WriteLine("Answer 25 : {0}", item);
        }
        Console.Write("\n");

        //Section 09
        //Question 26
        Console.WriteLine("Question 26: Which aspect of learning english would you priorities improving first?");
        List<string> AnswerTwentySixList = new List<string>()
        {
            "Grammar", "Pronunciation", "Listening comprehension", "Vocabulary", "Speaking fluency"
        };

        string AnswerTwentySix = AnswerTwentySixList[QRBObject.RandomNumberMethod(AnswerTwentySixList.Count)];
        Console.WriteLine("Answer 23 : {0}\n", AnswerTwentySix);
    }
}