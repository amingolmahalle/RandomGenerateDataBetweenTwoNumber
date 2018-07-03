using System.Data;
using GeneratorData.DAL;

namespace GeneratorData.BLL
{
   public class ProjectBll
    {
        public DataTable FillComboBoxControl(string tableName, string colId, string colName) => ControlUtility.FillCmb("مشخص نشده", $"SELECT {colId},{colName} FROM {tableName}");
        
        public DataTable FillComboBoxControlByFilter(string tableName, string colId, string colName, string conditionName, int conditionValue)=> ControlUtility.FillCmb("مشخص نشده", $"SELECT {colId},{colName} FROM {tableName} where {conditionName}={conditionValue}");
        
        public DataTable GetaAllDataTable(string tableName)=> new ControlUtility().GetAllData(tableName);
        
    }
}
