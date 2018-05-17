using System.Collections.Generic;

namespace MyPatchSG.API
{
    public interface IMyPatchSGStoredProcedureAdapter
    {
        IEnumerable<TResult> ExecuteStoredProcedure<TResult>(
            string procName,
            ISqlParametersAble sqlParametersObject);
    }
}