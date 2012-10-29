using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;
using Interfaces;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    /// <summary>
    /// Populates Business Objects
    /// </summary>
    public class DataBaseAccessor : Accessor
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="DataBaseAccessor" /> class.
        /// </summary>
        public DataBaseAccessor(Type type)
        {
            this.ConnectionString =
                ConfigurationManager.ConnectionStrings["hamwicConnectionString"].ToString();
            SetupAccessorObject(type);
        }

        /// <summary>
        /// Gets or sets the accessor object.
        /// </summary>
        /// <value>
        /// The accessor object.
        /// </value>
        public DataSet AccessorDataSet { get; set; }

        /// <summary>
        /// The connection string
        /// </summary>
        private String ConnectionString { get; set;}
        
        /// <summary>
        /// Sets up the accessor object.
        /// </summary>
        private void SetupAccessorObject(Type type)
        {
            SqlDataAdapter sda = new SqlDataAdapter();
            AccessorDataSet = new DataSet();
            SqlConnection sqlConn = new SqlConnection(this.ConnectionString);

            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.Append("SELECT * FROM ");
            stringBuilder.Append(type.Name);

             sda.SelectCommand =
                 new SqlCommand(stringBuilder.ToString(), sqlConn);

             sda.Fill(AccessorDataSet);

        }
    }
}
