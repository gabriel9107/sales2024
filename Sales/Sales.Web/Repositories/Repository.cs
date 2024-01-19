
namespace Sales.Web.Repositories
{
    public class Repository : IRepository
    {
        public Task<HttpResponseWrapper<T>> Get<T>(string url)
        {
            throw new NotImplementedException();
        }

        public Task<HttpResponseWrapper<object>> Post<T>(string url, T model)
        {
         
        }

        public Task<HttpResponseWrapper<TResponse>> Post<T, TResponse>(string url, T model)
        {
            throw new NotImplementedException();
        }
    }
}
