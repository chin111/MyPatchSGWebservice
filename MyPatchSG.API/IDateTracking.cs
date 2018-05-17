using System;

namespace MyPatchSG.API
{
    public interface IDateTracking
    {
        DateTimeOffset? CreatedDate { get; set; }
        DateTimeOffset? LastUpdatedDate { get; set; }

        DateTimeOffset? DeletedDate { get; set; }
    }

    public interface ICreatedDate
    {
        DateTimeOffset CreatedDate { get; set; }
    }

    public interface IUpdatedDate
    {
        DateTimeOffset UpdatedDate { get; set; }
    }
}