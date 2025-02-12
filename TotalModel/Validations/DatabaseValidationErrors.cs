using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace TotalModel.Validations
{
    public class DatabaseValidationErrors : ValidationErrors
    {
        public DatabaseValidationErrors(DbUpdateException exception) : base()
        {
            if (exception?.InnerException != null)
            {
                Errors.Add(new PropertyError("Database", exception.InnerException.Message));
            }

            if (exception?.Entries != null)
            {
                // Trong Entity Framework 6 (EF6), khi SaveChanges() bị lỗi do validation,
                // Entity Framework tự động trả về danh sách lỗi validation thông qua DbEntityValidationResult.
                // Nhưng trong Entity Framework Core (EF Core), cơ chế này đã bị loại bỏ và thay thế bằng DbUpdateException.
                
                // --- CHÚ Ý --- 
                // DbUpdateException trong EF Core chỉ bắt các lỗi liên quan đến cơ sở dữ liệu (database),
                // mà không tự động kiểm tra lỗi validation ở cấp ứng dụng như các lỗi validation ([Required], [MaxLength], [Range]...)
                // đã được khai báo ở class trước khi gửi dữ liệu xuống database. Thay vào đó, ta phải tự kiểm tra bằng Validator.TryValidateObject()
                foreach (var entry in exception.Entries)
                {
                    var validationContext = new ValidationContext(entry.Entity);
                    var validationResults = new List<ValidationResult>();

                    if (!Validator.TryValidateObject(entry.Entity, validationContext, validationResults, true))
                    {
                        foreach (var validationResult in validationResults)
                        {
                            foreach (var memberName in validationResult.MemberNames)
                            {
                                if (!string.IsNullOrEmpty(validationResult.ErrorMessage))
                                {
                                    Errors.Add(new PropertyError(memberName, validationResult.ErrorMessage));
                                }
                            }
                        }
                    } 
                } 
            } 
        }
    }
}
