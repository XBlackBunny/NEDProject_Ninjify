using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Ninjaficator2020.Model
{
    /// <summary>
    /// Wrapper used in most treatment for basic error management.
    /// </summary>
    /// <typeparam name="T">Type of the return value.</typeparam>
    public class TreatmentResult<T>
    {
        /// <summary>
        /// Treatment result
        /// </summary>
        public T Result { get; set; }

        /// <summary>
        /// True if the treatment encountered an error.
        /// </summary>
        public bool HasError => !string.IsNullOrWhiteSpace(ErrorMessage) || Exception != null;

        /// <summary>
        /// Optional error message
        /// </summary>
        public string ErrorMessage { get; set; }

        /// <summary>
        /// Not null if an exception has been fired.
        /// </summary>
        [JsonIgnore]
        public Exception Exception { get; set; }

        public TreatmentResult()
        {
            Result = default;
        }

        public TreatmentResult(T result)
        {
            Result = result;
            ErrorMessage = null;
            Exception = null;
        }

        public TreatmentResult(string errorMessage, Exception ex)
        {
            Result = default;
            ErrorMessage = errorMessage;
            Exception = ex;
        }
    }
}
