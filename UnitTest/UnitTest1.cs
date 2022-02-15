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
                model="������ ����� ������ ����� ����",
                maxWeight="25���"
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
                model = "���������",
                maxWeight = "25���"
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
                model = "���������",
                maxWeight = "25���"
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

        // All(collection, action) : ����� ������������, ��� ��� �������� ��������� collection ������������� �������� action

        // Contains(expectedSubString, actualString): ����� ������������, ��� ������ actualString �������� expectedSubString

        //DoesNotContain(expectedSubString, actualString) : ����� ������������, ��� ������ actualString �� �������� ������ expectedSubString

        //DoesNotMatch(expectedRegexPattern, actualString) : ����� ������������, ��� ������ actualString �� ������������� ����������� ��������� expectedRegexPattern

        // Matches(expectedRegexPattern, actualString): ����� ������������, ��� ������ actualString ������������� ����������� ��������� expectedRegexPattern

        //Equal(expected, result) : ����� ���������� ��������� ����� � ���� �������� result � ��������� �������� expected � ������������ �� ���������

        //NotEqual(expected, result) : ����� ���������� ��������� ����� � ���� �������� result � ��������� �������� expected � ������������ �� �����������

        //Empty(collection) : ����� ������������, ��� ��������� collection ������

        // NotEmpty(collection): ����� ������������, ��� ��������� collection �� ������

        //True(result) : ����� ������������, ��� ��������� ����� ����� true

        //False(result) : ����� ������������, ��� ��������� ����� ����� false

        //IsType(expected, result) : ����� ������������, ��� ��������� ����� ����� ��� expected

        // IsNotType(expected, result): ����� ������������, ��� ��������� ����� �� ������������ ��� expected

        //IsNull(result) : ����� ������������, ��� ��������� ����� ����� �������� null

        //IsNotNull(result) : ����� ������������, ��� ��������� ����� �� ����� null

        //InRange(result, low, high) : ����� ������������, ��� ��������� ����� ��������� � ��������� ����� low � high

        // NotInRange(result, low, high): ����� ������������, ��� ��������� ����� �� ����������� ��������� �� low �� high

        // Same(expected, actual): ����� ������������, ��� ������ expected � actual ��������� �� ���� � ��� �� ������ � ������

        // NotSame(expected, actual): ����� ������������, ��� ������ expected � actual ��������� �� ������ ������� � ������

        //Throws(exception, expression) : ����� ������������, ��� ��������� expression ���������� ���������� exception
    }
}