namespace LogolendarzFRONT.Utility
{
    public class SD
    {
        public static string VisitAPIBase { get; set; }
        public static string AuthAPIBase { get; set; }
        public enum ApiType
        {
            GET,
            POST,
            PUT,
            DELETE
        }

    }
}
