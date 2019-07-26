using System;
using System.Collections.Generic;

namespace TranslationService
{
    public class ParseNumber
    {
        public string GetText(int input)
        {
            var response = "Not matched";
            var singleDigitLookUp = new Dictionary<int, string>();

            singleDigitLookUp.Add(1, "ONE");
            singleDigitLookUp.Add(2, "TWO");
            singleDigitLookUp.Add(3, "THREE");
            singleDigitLookUp.Add(4, "FOUR");
            singleDigitLookUp.Add(5, "FIVE");
            singleDigitLookUp.Add(6, "SIX");
            singleDigitLookUp.Add(7, "SEVEN");
            singleDigitLookUp.Add(8, "EIGHT");
            singleDigitLookUp.Add(9, "NINE");

            var doubleDigitLookUp = new Dictionary<int, string>();
            doubleDigitLookUp.Add(1, "ONE");
            doubleDigitLookUp.Add(2, "TWENTY");
            doubleDigitLookUp.Add(3, "THIRTY");
            doubleDigitLookUp.Add(4, "FOURTY");
            doubleDigitLookUp.Add(5, "FIFTY");
            doubleDigitLookUp.Add(6, "SIXTY");
            doubleDigitLookUp.Add(7, "SEVENTY");
            doubleDigitLookUp.Add(8, "EIGHTY");
            doubleDigitLookUp.Add(9, "NINTY");

            var inputLength = input.ToString().Length;
            if (inputLength == 1) return singleDigitLookUp[input];

            var numberAsString = input.ToString();

            string firstDigitAsString;
            string secondDigitAsString;
            string thirdDigitAsString;
            string fourthDigitAsString;


            switch (inputLength)
            {
                case 2:
                    firstDigitAsString = numberAsString[0].ToString();
                    secondDigitAsString = numberAsString[1].ToString();

                    if (firstDigitAsString == "1")
                    {
                        switch (secondDigitAsString)
                        {
                            case "0":
                                response = "TEN";
                                break;
                            case "1":
                                response = "ELEVEN";
                                break;
                            case "2":
                                response = "TWELVE";
                                break;
                            case "3":
                                response = "THIRTEEN";
                                break;
                            case "5":
                                response = "FIFTEEN";
                                break;
                            default:
                                response = singleDigitLookUp[Int32.Parse(secondDigitAsString)] + "TEEN";
                                break;
                        }

                    }
                    else
                    {
                        if (secondDigitAsString == "0")
                        {
                            response = doubleDigitLookUp[Int32.Parse(firstDigitAsString)];
                        }
                        else
                        {
                            response = doubleDigitLookUp[Int32.Parse(firstDigitAsString)] + " " + singleDigitLookUp[Int32.Parse(secondDigitAsString)];
                        }
                    }
                    break;

                case 3:
                    firstDigitAsString = numberAsString[0].ToString();
                    secondDigitAsString = numberAsString[1].ToString();
                    thirdDigitAsString = numberAsString[2].ToString();

                    if (!input.ToString().Contains("0"))
                    {
                        response = singleDigitLookUp[Int32.Parse(firstDigitAsString)] + " HUNDRED AND " + doubleDigitLookUp[Int32.Parse(secondDigitAsString)] + " " + singleDigitLookUp[Int32.Parse(thirdDigitAsString)];
                    }
                    else if (secondDigitAsString == "0")
                    {
                        response = singleDigitLookUp[Int32.Parse(firstDigitAsString)] + " HUNDRED AND " + singleDigitLookUp[Int32.Parse(thirdDigitAsString)];
                    }
                    else if (thirdDigitAsString == "0")
                    {
                        response = singleDigitLookUp[Int32.Parse(firstDigitAsString)] + " HUNDRED AND " + doubleDigitLookUp[Int32.Parse(secondDigitAsString)];
                    }
                    
                    break;
            }

            return response;
        }
    }
}
