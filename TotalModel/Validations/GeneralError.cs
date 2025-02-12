namespace TotalModel.Validations
{
    public class GeneralError : IBaseError
    {
        public string PropertyName
        {
            get
            {
                return string.Empty;
            }
        }
        public string PropertyExceptionMessage
        {
            get; set;
        }

        public GeneralError(string errorMessage)
        {
            this.PropertyExceptionMessage = errorMessage;
        }
    }
}
