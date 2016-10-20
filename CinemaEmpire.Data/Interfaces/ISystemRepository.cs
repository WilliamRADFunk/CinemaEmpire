using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaEmpire.Data.Repositories
{
    public interface ISystemRepository
    {
        /// <summary> Create (Insert) system log. </summary>
        Entities.SystemLog CreateLog(Entities.SystemLog log);

        /// <summary> Delete system log permanently. </summary>
        void DeleteLog(int id);

        /// <summary> Get specific system log. </summary>
        Entities.SystemLog GetLog(int id);

        /// <summary> Get all system logs. </summary>
        IList<Entities.SystemLog> GetLogs();

        /// <summary> Changes (UPDATE) system log. </summary>
        Entities.SystemLog SetLog(Entities.SystemLog log);
    }
}
