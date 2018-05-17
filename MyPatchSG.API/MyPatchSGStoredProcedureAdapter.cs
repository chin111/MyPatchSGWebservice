using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;

namespace MyPatchSG.API
{
    public class MyPatchSGStoredProcedureAdapter : IMyPatchSGStoredProcedureAdapter
    {
        private readonly MyPatchSGWebContext webDBContext;

        public MyPatchSGStoredProcedureAdapter()
        {
            this.webDBContext = new MyPatchSGWebContext("MyPatchSGWebContext");
        }

        public IEnumerable<TResult> ExecuteStoredProcedure<TResult>(
            string procName,
            ISqlParametersAble sqlParametersObject)
        {
            var sqlParameters = sqlParametersObject != null
                ? sqlParametersObject.AsSqlParameters()
                : new SqlParameter[0];

            var sqlStatement = this.CreateSPCommand(procName, sqlParameters);

            return webDBContext.Database.SqlQuery<TResult>(sqlStatement, sqlParameters.ToArray());
        }

        private string CreateSPCommand(string procName, IEnumerable<SqlParameter> sqlParameters)
        {
            var queryString = string.Format("{0}", procName);
            sqlParameters.ToList().ForEach(x => queryString = string.Format("{0} {1},", queryString, x.ParameterName));

            return queryString.TrimEnd(',');
        }
    }
}