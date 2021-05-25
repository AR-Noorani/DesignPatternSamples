using System;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    public class DbHandler : Handler
    {
        public DbHandler(Handler successor) : base(successor) { }

        public override async Task<Data> GetDataAsync(int id)
        {
            var fetchedData = FetchDataFromDatabase(id); 

            if (fetchedData is not null)
                return fetchedData;
            else
                return await successor.GetDataAsync(id);
        }

        private static Data FetchDataFromDatabase(int id)
        {
            //source: https://www.educative.io/edpresso/how-to-generate-a-random-string-in-c-sharp
            static string GenerateRandomValue()
            {
                var result = new StringBuilder();
                var random = new Random();

                for (var i = 0; i < 10; i++)
                {
                    var flt = random.NextDouble();
                    var shift = Convert.ToInt32(Math.Floor(25 * flt));
                    var letter = Convert.ToChar(shift + 65);
                    result.Append(letter);
                }
                return result.ToString();
            }

            return new Data { ID = id, Value = GenerateRandomValue() };
        }
    }
}
