namespace ZurroService.Data
{
    public static class Info
    {
        private static string conexion = "DefaultConnection";
        private static string mysqlVersion = "8.0.40";
        private static string mysqlDB = "zurro_db";
        private static string mysqlTable = "zuser";
        private static string errorCreateUser = "Error creating a new ZUser";
        private static string errorFindUser = "ZUser dosn't exist in the DDBB";
        private static string userChangeStatusActive = "Active status was modified successfully for the user id: ";

        public static string Conexion
        {
            get { return conexion; }
        }

        public static string MySQLVersion
        {
            get { return mysqlVersion; }
        }

        public static string MySQLDB
        {
            get { return mysqlDB; }
        }

        public static string MySQLTable
        {
            get { return mysqlTable; }
        }

        public static string ErrorCreateUser
        {
            get { return errorCreateUser; }
        }

        public static string ErrorFindUser
        {
            get { return errorFindUser; }
        }

        public static string UserChangeStatusActive
        {
            get { return userChangeStatusActive; }
        }
    }
}
