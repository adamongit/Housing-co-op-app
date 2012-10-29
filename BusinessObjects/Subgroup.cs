using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DataAccessLayer;

namespace BusinessObjects 
{
    public class Subgroup
    {
        /// <summary>
        /// Gets or sets the id.
        /// </summary>
        /// <value>
        /// The id.
        /// </value>
        public int Id { get; set; }
        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        /// <value>
        /// The name.
        /// </value>
        public String Name { get; set; }

        /// <summary>
        /// Gets all subgroups from the db
        /// </summary>
        /// <returns></returns>
        public static Dictionary<int, String> GetAll()
        {
            DataBaseAccessor dba = new DataBaseAccessor(typeof(Subgroup));
            Dictionary<int, String> dic = new Dictionary<int, String>();

            foreach (System.Data.DataRow dr in dba.AccessorDataSet.Tables[0].Rows)
            {
                dic.Add((int)dr[0], dr[1].ToString());
            }

            return dic;
        }
    }
}
