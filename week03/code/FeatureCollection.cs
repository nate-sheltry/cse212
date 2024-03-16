using System.Net;

public class FeatureCollection {
    public string? Type {get; set;}
    public MetaData Metadata {get; set;}
    public float?[] Bbox  {get; set;}
    public Feature[] Features {get; set;}

    // Todo Earthquake Problem - ADD YOUR CODE HERE
    public class MetaData {
        public long? Generated {get; set;}
        public string? Url {get; set;}
        public string? Title {get; set;}
        public string? Api {get; set;}
        public int? Count {get; set;}
        public int? Status {get; set;}

    }
    public class Feature {
        public string? Type {get; set;}
        public PropertiesObj Properties {get; set;}
        public GeometryObj Geometry {get; set;}
        public string? Id {get; set;}

        public class PropertiesObj {
            public float? Mag {get; set;}
            public string? Place {get; set;}
            public long? Time {get; set;}
            public long? Updated {get; set;}
            public int? Tz {get; set;}
            public string? Url {get; set;}
            public string? Detail {get; set;}
            public int? Felt {get; set;}
            public float? Cdi {get; set;}
            public float? Mmi {get; set;}
            public string? Alert {get; set;}
            public string? Status {get; set;}
            public int? Tsunami {get; set;}
            public int? Sig {get; set;}
            public string? Net {get; set;}
            public string? Code {get; set;}
            public string? Ids {get; set;}
            public string? Sources {get; set;}
            public string? Types {get; set;}
            public int? Nst {get; set;}
            public float? Dmin {get; set;}
            public float? Rms {get; set;}
            public float? Gap {get; set;}
            public string? MagType {get; set;}
            public string? Type {get; set;}
        }
        public class GeometryObj {
            public string? Type {get; set;}
            public float?[] Coordinates {get; set;}
        }
    }
}