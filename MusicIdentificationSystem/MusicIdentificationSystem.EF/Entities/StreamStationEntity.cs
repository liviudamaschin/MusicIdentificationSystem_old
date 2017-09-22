// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.6
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace MusicIdentificationSystem.EF.Entities
{

    // StreamStations
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.32.0.0")]
    public partial class StreamStationEntity
    {
        public int Id { get; set; } // Id (Primary key)
        public string StationName { get; set; } // StationName (length: 250)
        public string Url { get; set; } // URL
        public string LocalPath { get; set; } // LocalPath
        public bool? IsActive { get; set; } // IsActive
        public string Description { get; set; } // Description (length: 250)

        public StreamStationEntity()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

}
// </auto-generated>
