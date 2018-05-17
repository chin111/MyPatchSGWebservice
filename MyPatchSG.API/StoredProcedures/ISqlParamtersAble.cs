using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Text;
using System.Threading.Tasks;

namespace MyPatchSG.API
{
    public interface ISqlParametersAble
    {
        string StoredProcedureName { get; }
        IEnumerable<SqlParameter> AsSqlParameters();
    }
}