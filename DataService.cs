using DemoApp.Interface;

namespace DemoApp
{
    public class DataService : IDataService
    {
        public async Task<int> GetStringCount(string request)
        {
            try
            {
                if (string.IsNullOrEmpty(request))
                {
                    return await Task.FromResult(0);
                }

                while (request.Length > 0)
                {
                    int count = 0;

                    for (int i = 0; i < request.Length; i++)
                    {
                        if (request[0] == request[i])
                        {
                            count++;
                        }
                    }
                }

                int stringCount = request.Length;
                return await Task.FromResult(stringCount);
            }
            catch (Exception ex)
            {
                throw new NotImplementedException();
            }
            
        }
    }
}
