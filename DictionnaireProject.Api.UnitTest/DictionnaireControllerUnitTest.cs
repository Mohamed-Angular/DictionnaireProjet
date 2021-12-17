using DictionnaireProject.Api.Controllers;
using DictionnaireProject.Core.Interfaces;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Net;
using System.Threading.Tasks;
using Xunit;
using EX = DictionnaireProject.Core.Exceptions.Constants.MessagesConstantes;
namespace DictionnaireProject.Api.UnitTest
{
    [ExcludeFromCodeCoverage]
    public class DictionnaireControllerUnitTest
    {
        private readonly Mock<IApiServices> _iapiServices;
        public HttpStatusCode httpStatusCode { get; }
        public DictionnaireControllerUnitTest()
        {
            _iapiServices = new Mock<IApiServices>();
        }
        [Fact]
        public async Task Should_Throw_BadRequestException_When_Inputs_With_Is_Null()
        {
            //Arrange
            var dictionnaireController = new DictionnaireController(_iapiServices.Object);

            //Act
            var result = await dictionnaireController.GetDictionnary(null);
            var response = (BadRequestObjectResult)result;

            //Assert
            var Expected = EX.BAD_REQUEST_BAD_INPUT; ;
            Assert.NotNull(result);
            Assert.Equal(Expected, response.Value);
        }

        [Fact]
        public async Task Should_Throw_BadRequestException_When_Inputs_Not_Equals_KeyWordsInputsType()
        {
            //Arrange
            var dictionnaireController = new DictionnaireController(_iapiServices.Object);

            //Act
            var result = await dictionnaireController.GetDictionnary("Salut");
            var response = (BadRequestObjectResult)result;

            //Assert
            var Expected = EX.BAD_REQUEST_BAD_INPUT; ;
            Assert.NotNull(result);
            Assert.Equal(Expected, response.Value);
        }


        [Theory]
        [InlineData("bonjour")]
        [InlineData("encore")]
        [InlineData("télévision")]
        [InlineData("coaguler")]
        [InlineData("sœur")]
        [InlineData("journée")]
        [InlineData("journal")]
        public async Task SHould_Return_Result_When_The_Input_Equals_KeyWordsInputsType(String KeyWordInput)
        {
            //Arrange
            var dictionnaireController = new DictionnaireController(_iapiServices.Object);

            //Act
            var result = await dictionnaireController.GetDictionnary(KeyWordInput);
            var response = (OkObjectResult)result; ;

            //Assert
            int Expected = 200; ;
            Assert.NotNull(result);
            Assert.Equal(Expected, response.StatusCode);
        }

    }
}
