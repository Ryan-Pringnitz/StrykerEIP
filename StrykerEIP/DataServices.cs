using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Data.Sql;
using System.Linq;

namespace StrykerEIP
{
    class DataServices
    {
        private SqlConnection DataMartConnection = new SqlConnection(System.Configuration.ConfigurationManager.ConnectionStrings["EISConnection"].ConnectionString);
        SqlParameter[] _objectSqlParameters = null;

        public DataSet GetBusinessProcessInfo(string businessProcessName)
        {
            using(SqlCommand cmd = new SqlCommand())
            {
                cmd.Connection = DataMartConnection;

                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "GetBusinessProcessData";

                cmd.Parameters.AddWithValue("@BusinessProcess", businessProcessName);

                using(SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    DataSet dataSetBusinessProcess = new DataSet();
                    da.TableMappings.Add("KPI1", "RawData1");
                    da.TableMappings.Add("KPI2", "RawData2");
                    da.TableMappings.Add("KPI3", "RawData3");
                    da.TableMappings.Add("KPI4", "RawData4");

                    da.TableMappings.Add("KPI5", "KPIResult1");
                    da.TableMappings.Add("KPI6", "KPIResult2");
                    da.TableMappings.Add("KPI7", "KPIResult3");
                    da.TableMappings.Add("KPI8", "KPIResult4");

                    da.TableMappings.Add("KPI9", "States");
                    da.TableMappings.Add("KPI10", "Decisions");

                    da.Fill(dataSetBusinessProcess, "KPI");

                    return dataSetBusinessProcess;
                }
            }
        }
    }
}
