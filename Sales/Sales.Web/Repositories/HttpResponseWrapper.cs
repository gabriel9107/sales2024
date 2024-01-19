using System.Net

namespace Sales.Web.Repositories
{
    public class HttpResponseWrapper<T>
    {


        public HttpResponseWrapper(T? response, bool error, HttpResponseMessage httpResponseMenssage)
        {
            Error = error;
            Response = response;
            HttpResponseMessage = httpResponseMenssage;



        }

        public bool Error { get; set; }
        public T? Response { get; set; }
        public HttpResponseMessage HttpResponseMessage { get; set; }

        public async Task<string?> GetErrorMenssage()
        {
            if(!Error)
            {
                return null;
            }

            var codigoEstatus = HttpResponseMessage.StatusCode;
            if(codigoEstatus == HttpStatusCode.NotFound )
            {
                return "Recurso no encontrado";
            }
            else if(codigoEstatus == HttpStatusCode.BadRequest)
            {
                return await HttpResponseMessage.Content.ReadAsStringAsync();
            }
            else if( codigoEstatus == HttpStatusCode.Unauthorized )
            {
                return "Tienes que loquarte para hacer esta operacion";
            }
            else if(codigoEstatus == HttpStatusCode.Forbidden )
            {
                return "No tienes permisos para hacer esta operacion";
            }

            return "Ha ocurrido un error inesperado";
        }

    }
}
