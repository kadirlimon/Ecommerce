using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UdemyApiWithToken.Domain.Response
{
    public class BaseResponse<T> 
    {
        public T Data { get; set; }

        public BaseResponse()
        {

        }

        public BaseResponse(T data)
        {
            this.Success = true;
            this.Data = data;
        }

        public BaseResponse(string errrorMessage)
        {
            this.Success = false;
            this.Message = errrorMessage;
        }

        public bool Success { get; set; }
        public string Message { get; set; }
    }
}
