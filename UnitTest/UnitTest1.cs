using System.Net;
using System.Net.Http;
using System.Net.Http.Json;
using Xunit;

namespace UnitTests
{
    public class UnitTest1
    {
        private readonly HttpClient _client;
        const string _url = "localhost:5144";
        public UnitTest1()
        {
            _client = new HttpClient();
        }
        [Fact]
        public async void TestGet()
        {
            string id = "5";
            var request = new HttpRequestMessage(new HttpMethod("GET"), $"http://localhost:5144/api/Car/{id}");

            var response = await _client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public async void TestSelect()
        {
            var request = new HttpRequestMessage(new HttpMethod("GET"), $"http://localhost:5144/api/Car");

            var response = await _client.SendAsync(request);

            response.EnsureSuccessStatusCode();
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public async void TestAddBadRequest()
        {
            var data = new
            {
                adda="adad"
            };

            var response = await _client.PostAsJsonAsync("http://localhost:5144/api/Car/insert", data);
            Assert.Equal(HttpStatusCode.InternalServerError, response.StatusCode);

        }
        [Fact]
        public async void TestAdd()
        {
            var data = new
            {
                model="Пример ввода данных через пост",
                maxWeight="25тон"
            };

            var response = await _client.PostAsJsonAsync("http://localhost:5144/api/Car/insert", data);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);

        }
        [Fact]
        public async void TestUpdateBadRequest()
        {
            var data = new
            {
                id="222ad",
                model = "Изменение",
                maxWeight = "25тон"
            };

            var response = await _client.PutAsJsonAsync("http://localhost:5144/api/Car/update", data);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
        [Fact]
        public async void TestUpdate()
        {
            var data = new
            {
                id = 5,
                model = "Изменение",
                maxWeight = "25тон"
            };

            var response = await _client.PutAsJsonAsync("http://localhost:5144/api/Car/update", data);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }
        [Fact]
        public async void TestDeleteBadRequest()
        {
            var id = "a211";
            var request = new HttpRequestMessage(new HttpMethod("DELETE"), $"http://localhost:5144/api/Car/{id}");

            var response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.BadRequest, response.StatusCode);
        }
        [Fact]
        public async void TestDelete()
        {
            var id = 1;
            var request = new HttpRequestMessage(new HttpMethod("DELETE"), $"http://localhost:5144/api/Car/{id}");

            var response = await _client.SendAsync(request);
            Assert.Equal(HttpStatusCode.OK, response.StatusCode);
        }

        // All(collection, action) : метод подтверждает, что все элементы коллекции collection соответствуют действию action

        // Contains(expectedSubString, actualString): метод подтверждает, что строка actualString содержит expectedSubString

        //DoesNotContain(expectedSubString, actualString) : метод подтверждает, что строка actualString не содержит строку expectedSubString

        //DoesNotMatch(expectedRegexPattern, actualString) : метод подтверждает, что строка actualString не соответствует регулярному выражению expectedRegexPattern

        // Matches(expectedRegexPattern, actualString): метод подтверждает, что строка actualString соответствует регулярному выражению expectedRegexPattern

        //Equal(expected, result) : метод сравнивает результат теста в виде значения result и ожидаемое значение expected и подтверждает их равенство

        //NotEqual(expected, result) : метод сравнивает результат теста в виде значения result и ожидаемое значение expected и подтверждает их неравенство

        //Empty(collection) : метод подтверждает, что коллекция collection пустая

        // NotEmpty(collection): метод подтверждает, что коллекция collection не пустая

        //True(result) : метод подтверждает, что результат теста равен true

        //False(result) : метод подтверждает, что результат теста равен false

        //IsType(expected, result) : метод подтверждает, что результат теста имеет тип expected

        // IsNotType(expected, result): метод подтверждает, что результат теста не представляет тип expected

        //IsNull(result) : метод подтверждает, что результат теста имеет значение null

        //IsNotNull(result) : метод подтверждает, что результат теста не равен null

        //InRange(result, low, high) : метод подтверждает, что результат теста находится в диапазоне между low и high

        // NotInRange(result, low, high): метод подтверждает, что результат теста не принадлежит диапазону от low до high

        // Same(expected, actual): метод подтверждает, что ссылки expected и actual указывают на один и тот же объект в памяти

        // NotSame(expected, actual): метод подтверждает, что ссылки expected и actual указывают на разные объекты в памяти

        //Throws(exception, expression) : метод подтверждает, что выражение expression генерирует исключение exception
    }
}