using IISchedule.Validations;
using IISchedule.Models.AllAudiencesList;
using IISchedule.Models.AllCurEmployeesAnnouncements;
using IISchedule.Models.AllDepartmentsList;
using IISchedule.Models.AllEmployeesList;
using IISchedule.Models.AllFacultiesList;
using IISchedule.Models.AllGroupsList;
using IISchedule.Models.AllRelevantDepartmentAnnouncements;
using IISchedule.Models.AllSpecializationsList;
using IISchedule.Models.EmployeeSchedule;
using IISchedule.Models.GroupSchedule;
using IISchedule.Models.LastScheduleUpdate;

namespace IISchedule.Services
{
    internal interface IScheduleService
    {
        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets group schedule by group number.
        /// </summary>
        /// <param name="groupNumber">group number (ex. "351005")</param>
        /// <returns>
        /// GroupSchedule type in *.json format.
        /// </returns>
        /// <seealso cref="GetAllGroups"/>
        /// <seealso cref="GetLastScheduleUpdateDate"/>
        Task<GroupSchedule> GetGroupSchedule(string groupNumber);

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets employee schedule by employee urlId.
        /// </summary>
        /// <param name="urlId">employee url id (ex. "s-nesterenkov")</param>
        /// <returns>
        /// EmployeeSchedule type in *.json format.
        /// </returns>
        /// <seealso cref="GetAllEmployees"/>
        /// <seealso cref="GetLastScheduleUpdateDate"/>
        /// <seealso cref="GetCurEmployeesAnnouncements"/>
        Task<EmployeeSchedule> GetEmployeeSchedule(string urlId);

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets all groups.
        /// </summary>
        /// <returns>
        /// List of all groups AllGroupsList type in *.json format.
        /// </returns>
        /// <seealso cref="GetGroupSchedule(string)"/>
        /// <seealso cref="GetLastScheduleUpdateDate"/>
        Task<List<AllGroupsList>> GetAllGroups();

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets all employees.
        /// </summary>
        /// <returns>
        /// List of AllEmployeesList type in *.json.
        /// </returns>
        /// <seealso cref="GetEmployeeSchedule(string)"/>
        /// <seealso cref="GetLastScheduleUpdateDate"/>
        /// <seealso cref="GetCurEmployeesAnnouncements"/>
        Task<List<AllEmployeesList>> GetAllEmployees();

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets all faculties.
        /// </summary>
        /// <returns>
        /// List of AllFacultiesList type in *.json.
        /// </returns>
        /// <seealso cref="GetAllSpecializations"/>
        /// <seealso cref="GetAllDepartments"/>
        Task<List<AllFacultiesList>> GetAllFaculties();

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets all departments.
        /// </summary>
        /// <returns>
        /// List of AllDepartmentsList type in *.json.
        /// </returns>
        /// <seealso cref="GetAllSpecializations"/>
        /// <seealso cref="GetRelevantDepartmentAnnouncements(int)"/>
        Task<List<AllDepartmentsList>> GetAllDepartments();

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets all specializations.
        /// </summary>
        /// <returns>
        /// List of AllSpecializationsList type in *.json.
        /// </returns>
        Task<List<AllSpecializationsList>> GetAllSpecializations();

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets info about actual employees updates (ex. retake or reschedule).
        /// </summary>
        /// <param name="urlId">employee url id (ex. "s-nesterenkov")</param>
        /// <returns>
        /// List of AllCurEmployeesAnnouncements type in *.json.
        /// </returns>
        /// <seealso cref="GetEmployeeSchedule(string)"/>
        /// <seealso cref="GetAllEmployees"/>
        /// <seealso cref="GetLastScheduleUpdateDate"/>
        Task<List<AllCurEmployeesAnnouncements>> GetCurEmployeesAnnouncements(string urlId);

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets info about actual department updates.
        /// </summary>
        /// <param name="id">department id (ex. 20027)</param>
        /// <returns>
        /// List of AllRelevantDepartmentAnnouncements type in *.json.
        /// </returns>
        /// <seealso cref="GetAllDepartments"/>
        Task<List<AllRelevantDepartmentAnnouncements>> GetRelevantDepartmentAnnouncements(int id);

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets info about all evaluable audiences.
        /// </summary>
        /// <returns>
        /// List of AllAudiencesList type in *.json.
        /// </returns>
        /// <seealso cref="GetGroupSchedule(string)"/>
        /// <seealso cref="GetEmployeeSchedule(string)"/>
        Task<List<AllAudiencesList>> GetAllAudiences();

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets last schedule update.
        /// </summary>
        /// <param name="updateType">
        /// If you want to know last employee schedule update you should input: UpdateType.Employee;
        /// If you want to know last group schedule update you should input: UpdateType.Group;
        /// </param>
        /// <param name="searchParameter">
        /// String parameters which style depends on updateTypeL
        ///  - If updateType == UpdateType.Employee => searchParameter == groupNumber (ex. "351005");
        ///  - If updateType == UpdateType.Group => searchParameter == urlId (ex. "s-nesterenkov").
        /// </param>
        /// <returns>
        /// Last schedule update info in type LastScheduleUpdate.
        /// </returns>
        /// <seealso cref="GetGroupSchedule(string)"/>
        /// <seealso cref="GetEmployeeSchedule(string)"/>
        Task<LastScheduleUpdate> GetLastScheduleUpdateDate(UpdateType updateType, string searchParameter);

        /// <exception cref="StatusCodeException">
        /// Thrown when API returns bad status code.
        /// </exception>
        /// <exception cref="EmptyItemsConvertException">
        /// Thrown when after converting info in .json result is null.
        /// </exception>
        /// <summary>
        /// Gets current schedule week.
        /// </summary>
        /// <returns>
        /// int number - current week number.
        /// </returns>
        /// <seealso cref="GetGroupSchedule(string)"/>
        /// <seealso cref="GetEmployeeSchedule(string)"/>
        Task<int> GetCurrentWeek();
    }
}
