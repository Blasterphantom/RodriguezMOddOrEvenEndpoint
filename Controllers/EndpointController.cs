//Marcel Rodriguez
//10-25-22
//Odd or Even Endpoint
//This program will take a user input from the url and output if the number is odd or even
//Peer review - John Magpantay     notes : Code is clean! super clean and very simple, To type in the end point and the program will tell you if It's even or odd, goodjob overall!
using Microsoft.AspNetCore.Mvc;

namespace RodriguezMOddOrEvenEndpoint.Controllers;

[ApiController]
[Route("[controller]")]
public class EndpointController : ControllerBase
{
    [HttpGet]
    [Route("oddoreven/{numberOne}")]

    public string OddOrEven(string numberOne)
    {
        string result;
        int convertedNum1 = Convert.ToInt32(numberOne); 

        if(convertedNum1%2 == 0)
        {
            result = $"{numberOne} is even!";
        }
        else
        {
            result = $"{numberOne} is odd!";
        }
        return result;
    }
}
