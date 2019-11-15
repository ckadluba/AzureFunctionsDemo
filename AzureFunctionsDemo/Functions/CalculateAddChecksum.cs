using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using AzureFunctionsDemo.Logic;

namespace AzureFunctionsDemo.Functions
{
    public static class CalculateAddChecksum
    {
        [FunctionName("CalculateAddChecksum")]
        public static IActionResult Run(
            [HttpTrigger(AuthorizationLevel.Anonymous, "get", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function CalculateAddChecksum processing a request.");

            var numberParameter = req.Query["number"].ToString();
            if (string.IsNullOrEmpty(numberParameter))
            {
                return new BadRequestObjectResult("Please pass an integer as parameter number on the query string!");
            }

            if (!int.TryParse(numberParameter, out var number))
            {
                return new BadRequestObjectResult("Parameter number must be an integer!");
            }

            var checksumCalculator = new ChecksumCalculator();
            var checksum = checksumCalculator.CalculateAdditionChecksum(number);

            return new OkObjectResult(checksum);
        }
    }
}
