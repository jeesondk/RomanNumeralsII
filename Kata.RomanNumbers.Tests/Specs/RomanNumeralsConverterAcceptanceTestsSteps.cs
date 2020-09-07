using Kata.RomanNumbers.Tests.UnitTests;
using System;
using TechTalk.SpecFlow;

namespace Kata.RomanNumbers.Tests.Specs
{
    [Binding]
    public class RomanNumeralsConverterAcceptanceTestsSteps
    {

        [Given(@"I have entered (.*) into the converter")]
        public void GivenIHaveEnteredIntoTheConverter(int p0)
        {
            ScenarioContext.Current.Add("arabicNumeral", p0);
        }

        [Given(@"I have entered '(.*)' into the converter")]
        public void GivenIHaveEnteredIntoTheConverter(string p0)
        {
            ScenarioContext.Current.Add("romanNumeral", p0);
        }

        [When(@"I press enter")]
        public void WhenIPressEnter()
        {
            try
            {
                if (ScenarioContext.Current.ContainsKey("romanNumeral"))
                {
                    string romanNumeral = ScenarioContext.Current.Get<string>("romanNumeral");
                    var converter = new RomanToArabicTest();

                    converter.SetUp();
                    int arabicResult = converter.CanConvertFromRoman(romanNumeral);

                    ScenarioContext.Current.Add("result", arabicResult);
                }
                else
                {
                    int arabicNumeral = ScenarioContext.Current.Get<int>("arabicNumeral");

                    var converter = new ArabicToRomanTest();

                    converter.SetUp();
                    string romanResult = converter.CanConvertToRoman(arabicNumeral);

                    ScenarioContext.Current.Add("result", romanResult);
                }
            }
            catch(Exception ex)
            {
                ScenarioContext.Current.Add("result", ex);
            }
            
        }
        
        [Then(@"the result should be '(.*)' on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(string p0)
        {
            var res = ScenarioContext.Current.Get<string>("result");
            res.Equals(p0);
        }
        
        [Then(@"the result should be (.*) on the screen")]
        public void ThenTheResultShouldBeOnTheScreen(int p0)
        {

            var res = ScenarioContext.Current.Get<int>("result");
            res.Equals(p0);
        }
        
        [Then(@"the result shoudl be '(.*)' and a description on the screen")]
        public void ThenTheResultShoudlBeAndADescriptionOnTheScreen(string p0)
        {
            ScenarioContext.Current.Get<Exception>("result").GetType().Name.Equals(p0);

        }
    }
}
