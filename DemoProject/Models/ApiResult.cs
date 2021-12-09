using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DemoProject.Models
{
    public class ApiResult
    {
        public ApiResult()
        {
        }

        public ApiResult(string status)
        {
            Status = status;
        }

        public string Status { get; set; }
        public string Message { get; set; }
        public object Data { get; set; }
    }

    public class ApiResultStatus
    {
        public const string Success = "success";
        public const string Error = "error";
        public const string Exists = "exists";
        public const string ValidationFailed = "validation_failed";
        public const string InvalidGrant = "invalid_grant";
    }
}
