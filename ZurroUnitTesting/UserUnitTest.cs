using Xunit;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using ZurroService.Data;
using ZurroService.Controllers;
using ZurroService.Models;

namespace ZurroUnitTesting
{
    public class UserUnitTest
    {
        private readonly ZurroDBContext zdbContext;
        private readonly ZurroUserController zuserController;

        public UserUnitTest()
        {
            var op = new DbContextOptionsBuilder<ZurroDBContext>().
                         UseInMemoryDatabase(databaseName: "Test").Options;

            zdbContext = new ZurroDBContext(op);

            zuserController = new ZurroUserController(zdbContext);
        }

        /// <summary> Test to verify the creation of the user and save it in the DDBB </summary>
        [Fact]
        public async Task TestCreateUser()
        {
            ZUser zuser = new ZUser { Id = 1, Name = "Pierre Curie", Birthdate = DateTime.Now, Active = true };

            DTOCreateZUser newuser = new DTOCreateZUser { Name = zuser.Name, Birthdate = zuser.Birthdate };

            var resultado = await zuserController.CreateZUser(newuser);

            Assert.IsType<OkObjectResult>(resultado);
        }
    }
}